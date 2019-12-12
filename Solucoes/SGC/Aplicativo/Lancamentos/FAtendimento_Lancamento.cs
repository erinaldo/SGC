using Componentes;
using Consultas;
using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FAtendimento_Lancamento : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_CHAMADO chamado = new E_CHAMADO();

        #endregion

        #region Métodos

        public FAtendimento_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            var excessaoValicadao = new Exception();

            try
            {
                var validacaoChamado = Conexao.Banco.TB_DIV_CHAMADOs.FirstOrDefault(a => a.ID_CHAMADO == chamado.ID_CHAMADO);

                if (validacaoChamado == null || validacaoChamado.ST_CHAMADO.Treat() == "C")
                    excessaoValicadao = new Exception("O chamado selecionado foi cancelado!");
                else if (validacaoChamado.ST_CHAMADO != "A" || validacaoChamado.TB_DIV_EVENTOs.Count > 0)
                    excessaoValicadao = new Exception(String.Format("Este chamado já foi atendido pelo usuário: {0} - {1}", validacaoChamado.LOGIN_ATENDENTE, Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == validacaoChamado.LOGIN_ATENDENTE).NM_USUARIO.Treat()));
                else if (Parametros.IsAdministrator() && !Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == Parametros.Usuario))
                    excessaoValicadao = new Exception("É necessário cadastrar o usuário administrador para atender um chamado!");

                if (excessaoValicadao.Message != new Exception().Message)
                    throw excessaoValicadao;

                chamado = new E_CHAMADO(validacaoChamado);

                cde_DT_Prevista.DataMinima = Conexao.Banco.GetDate();

                cpc_DadosGerais.Controls.Validate();

                chamado.OPERACAO = Operacao.Alterar;
                chamado.PRIORIDADE = new E_PRIORIDADE { ID_PRIORIDADE = ccbe_Prioridade.GetSelectedValue() };
                chamado.DT_PREVISTA = cde_DT_Prevista.DateTime;
                chamado.DT_ATENDIMENTO = Conexao.Banco.GetDate();
                chamado.DS_OBSERVACAO = cme_Observacao.Text.Treat();
                chamado.LOGIN_ATENDENTE = Parametros.Usuario;

                var transacao = 0;

                if (C_CHAMADO.Salvar(chamado, ref transacao, new E_EVENTO
                {
                    DS_EVENTO = chamado.DS_OBSERVACAO,
                    DT_EVENTO = Conexao.Banco.GetDate(),
                    STATUS = cbce_ProximoStatus.GetSelectedValue(),
                    LOGIN_ATENDENTE = Parametros.Usuario
                }))
                {
                    if (ccbe_NovaCategoria.GetSelectedValue() != cte_Categoria.Text.GetValue())
                        C_TRANSFERENCIACATEGORIA.Salvar(new E_TRANSF_CATEGORIA
                            {
                                ID_CHAMADO = chamado.ID_CHAMADO,
                                LOGIN = Parametros.Usuario,
                                OPERACAO = Utilidades.Operacao.Cadastrar,
                                ID_CATEGORIA_NEW = ccbe_NovaCategoria.GetSelectedValue().ToInt(),
                                ID_CATEGORIA_OLD = cte_Categoria.Text.GetValue().ToInt()
                            }, ref transacao);

                    Finalizar();

                    Email.Enviar(validacaoChamado, OperacaoEmail.Atendimento);
                }
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());

                if (excessaoValicadao.Message == excessao.Message)
                    Cancelar();
            }
        }

        #endregion

        #region Eventos

        private void FAtendimentoChamado_Lancamento_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_Identificador.Text = chamado.ID_CHAMADO.ToString();
                cde_DT_Chamado.DateTime = chamado.DT_CHAMADO.Value;
                cte_Solicitante.Text = String.Format("{0} - {1}", chamado.LOGIN_SOLICITANTE, Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == chamado.LOGIN_SOLICITANTE).NM_USUARIO.Treat());
                cte_Departamento.Text = chamado.DEPARTAMENTO.Treat();
                cte_Categoria.Text = chamado.CATEGORIA.Treat();

                Conexao.Banco.TB_DIV_CATEGORIAs.Where(a => a.ID_DEPARTAMENTO == chamado.DEPARTAMENTO.GetValue().ToInt()).ToList().ForEach(a => ccbe_NovaCategoria.Properties.Items.Add(new CComboBoxEditValue { ID = a.ID_CATEGORIA.ToString(), DS = a.DS_CATEGORIA.Treat() }));
                ccbe_NovaCategoria.SetSelected(chamado.CATEGORIA.GetValue());

                cme_Descricao.Text = chamado.DS_CHAMADO.Treat();

                C_PRIORIDADE.Buscar().ToList().ForEach(a => ccbe_Prioridade.SetValue(new CComboBoxEditValue { ID = a.ID_PRIORIDADE, DS = a.DS_PRIORIDADE.Treat() }));
                ccbe_Prioridade.SetFirst();
                
                cde_DT_Prevista.DateTime = Conexao.Banco.GetDate().AddHours(1d);
                
                Conexao.Banco.TB_DIV_STATUS.Where(a => a.ST_INICIAR == "S").ToList().ForEach(a => cbce_ProximoStatus.SetValue(new CComboBoxEditValue { ID = a.SIGLA_STATUS, DS = a.DS_STATUS.Treat() }));
                cbce_ProximoStatus.SetFirst();

                ccbe_Prioridade.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}