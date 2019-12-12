using Componentes;
using Consultas;
using Entidades;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FStatus_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_STATUS status = new E_STATUS();

        #endregion

        #region Métodos

        public FStatus_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                status = new E_STATUS
                {
                    OPERACAO = Operacao,
                    SIGLA_STATUS = cte_SiglaStatus.Text.Treat(),
                    DS_STATUS = cte_Descricao.Text.Treat(),
                    ST_TEMPORIZAR = cce_Temporizar.Checked,
                    ST_AUTORIZAR = cce_Autorizar.Checked,
                    ST_INICIAR = cce_Iniciar.Checked,
                    ST_FINALIZAR = cce_Finalizar.Checked,
                    ST_INTERNO = cce_Interno.Checked,
                    ST_SOLICITANTE = cce_Solicitante.Checked,
                    ST_REGISTRO = cce_Ativo.Checked ? "A" : "C"
                };

                var transacao = 0;

                if (C_STATUS.Salvar(status, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FStatus_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Operacao.Alterar)
                {
                    cte_SiglaStatus.Text = status.SIGLA_STATUS.Treat();
                    cte_Descricao.Text = status.DS_STATUS.Treat();
                    cce_Temporizar.Checked = status.ST_TEMPORIZAR;
                    cce_Autorizar.Checked = status.ST_AUTORIZAR;
                    cce_Iniciar.Checked = status.ST_INICIAR;
                    cce_Finalizar.Checked = status.ST_FINALIZAR;
                    cce_Interno.Checked = status.ST_INTERNO;
                    cce_Solicitante.Checked = status.ST_SOLICITANTE;
                    cce_Ativo.Checked = status.ST_REGISTRO == "A" || status.ST_REGISTRO == "ATIVO";

                    cte_SiglaStatus.Enabled = false;
                    cte_Descricao.Select();
                }
                else
                    cte_SiglaStatus.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}