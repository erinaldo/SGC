using Componentes;
using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FCargo_Cadastro : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_CARGO cargo = new E_CARGO();

        #endregion

        #region Métodos

        public FCargo_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                cargo = new E_CARGO
                {
                    OPERACAO = Operacao,
                    ID_CARGO = cte_Identificador.Text.ToInt(),
                    DS_CARGO = cte_Descricao.Text.Treat(),
                };

                var transacao = 0;

                if (C_CARGO.Salvar(cargo, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FCargo_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = cargo.ID_CARGO.ToString();
                    cte_Descricao.Text = cargo.DS_CARGO.Treat();
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