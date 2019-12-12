using Componentes;
using Consultas;
using DevExpress.XtraEditors.Controls;
using Entidades;
using Formas.Padrao;
using Formas.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo.Lancamentos
{
    public partial class FEquipamentoUsuario_Lancamento : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_EQUIPAMENTOUSUARIO equipamentoUsuario = new E_EQUIPAMENTOUSUARIO();

        #endregion

        #region Métodos

        public FEquipamentoUsuario_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                equipamentoUsuario = new E_EQUIPAMENTOUSUARIO
                {
                    OPERACAO = Operacao,
                    EQUIPAMENTO = cbe_Equipamento.Text,
                    USUARIO = cbe_Usuario.Text.Treat(),
                    DS_OBSERVACAO = cte_DS_Observacao.Text.Treat(),
                    ST_REGISTRO = cce_Ativo.Checked ? "A" : "C",
                    ST_USOCOMPARTILHADO = cce_UsoCompartilhado.Checked ? "S" : "N"
                };

                var transacao = 0;

                C_EQUIPAMENTOUSUARIO.Salvar(equipamentoUsuario, ref transacao);

                Finalizar();
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        #endregion

        #region Eventos

        private void FEquipamentoUsuario_Lancamento_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Operacao.Alterar)
                {
                    cbe_Equipamento.Text = equipamentoUsuario.EQUIPAMENTO.GetValue();
                    cbe_Equipamento_Leave();
                    cbe_Usuario.Text = equipamentoUsuario.USUARIO.GetValue();
                    cbe_Usuario_Leave();
                    cte_DS_Observacao.Text = equipamentoUsuario.DS_OBSERVACAO.Treat();
                    cce_Ativo.Checked = equipamentoUsuario.ST_REGISTRO.Treat() == "A";
                    cce_UsoCompartilhado.Checked = equipamentoUsuario.ST_USOCOMPARTILHADO == "S";
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        private void cbe_Equipamento_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_DS_Observacao.Text = "";

                if (cbe_Equipamento.Text.ToInt() <= 0)
                    cbe_Equipamento.Text = "";
                else
                {
                    var equipamento = (from a in Conexao.Banco.TB_DIV_EQUIPAMENTOs where a.ID_EQUIPAMENTO == cbe_Equipamento.Text.ToInt() select new E_EQUIPAMENTO(a)).Take(1);

                    if (equipamento == null || equipamento.Count() == 0)
                        cbe_Equipamento.Text = "";
                    else
                        cte_DS_Observacao.Text = equipamento.First().DS_OBSERVACAO.Treat();
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }
        private void cbe_Departamento_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var id_equipamento = new FPesquisa.Filtro { Descricao = "Identificador", Nome = "ID_EQUIPAMENTO", Tamanho = 100 };
                    var ds_observacao = new FPesquisa.Filtro { Descricao = "Observação", Nome = "DS_OBSERVACAO", Tamanho = 350 };

                    filtros.Add(id_equipamento);
                    filtros.Add(ds_observacao);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Multiplos = false;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_EQUIPAMENTOs select new E_EQUIPAMENTO(a);

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Equipamento.Text = formaPesquisa.Selecionados.Cast<E_EQUIPAMENTO>().First().ID_EQUIPAMENTO.ToString();
                        cte_DS_Observacao.Text = formaPesquisa.Selecionados.Cast<E_EQUIPAMENTO>().First().DS_OBSERVACAO.Treat();
                    }
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        private void cbe_Usuario_Leave(object sender = null, EventArgs e = null)
        {
            try
            {
                cte_NM_Usuario.Text = "";
                cbe_Usuario.Text = cbe_Usuario.Text.Treat();

                var usuario = from a in Conexao.Banco.TB_DIV_USUARIOs where a.LOGIN == cbe_Usuario.Text.Treat() select new { a.NM_USUARIO };

                if (usuario == null || usuario.Count() == 0)
                    cbe_Equipamento.Text = "";
                else
                    cte_NM_Usuario.Text = usuario.First().NM_USUARIO.Treat();
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }
        private void cbe_Usuario_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (var formaPesquisa = new FPesquisa())
                {
                    var filtros = new List<FPesquisa.Filtro>();

                    var login = new FPesquisa.Filtro { Descricao = "Login", Nome = "LOGIN", Tamanho = 100 };
                    var nm_usuario = new FPesquisa.Filtro { Descricao = "Nome do usuário", Nome = "NM_USUARIO", Tamanho = 350 };

                    filtros.Add(login);
                    filtros.Add(nm_usuario);

                    formaPesquisa.Filtros = filtros;
                    formaPesquisa.Multiplos = false;
                    formaPesquisa.Consulta = from a in Conexao.Banco.TB_DIV_USUARIOs select new { a.LOGIN, a.NM_USUARIO };

                    if (formaPesquisa.ShowDialog() == DialogResult.OK)
                    {
                        cbe_Usuario.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["LOGIN"].ToString();
                        cte_NM_Usuario.Text = formaPesquisa.SelecionadosDataTable.Rows[0]["NM_USUARIO"].ToString();
                    }
                }
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }

        #endregion
    }
}