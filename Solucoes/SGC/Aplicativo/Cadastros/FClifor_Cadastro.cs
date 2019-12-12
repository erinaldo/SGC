using Componentes;
using Consultas;
using Entidades;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FClifor_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_CLIFOR clifor = new E_CLIFOR();

        #endregion

        #region Métodos

        public FClifor_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                clifor = new E_CLIFOR
                {
                    OPERACAO = Operacao,
                    ID_CLIFOR = cte_Identificador.Text.ToInt(),
                    NM_CLIFOR = cte_Descricao.Text.Treat(),
                };

                var transacao = 0;

                if (C_CLIFOR.Salvar(clifor, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FClifor_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = clifor.ID_CLIFOR.ToString();
                    cte_Descricao.Text = clifor.NM_CLIFOR.Treat();
                }

                cte_Descricao.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}