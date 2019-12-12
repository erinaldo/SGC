using Componentes;
using Consultas;
using Entidades;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FMarca_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_MARCA marca = new E_MARCA();

        #endregion

        #region Métodos

        public FMarca_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                marca = new E_MARCA
                {
                    OPERACAO = Operacao,
                    ID_MARCA = cte_Identificador.Text.ToInt(),
                    DS_MARCA = cte_Descricao.Text.Treat(),
                };

                var transacao = 0;

                if (C_MARCA.Salvar(marca, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FMarca_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = marca.ID_MARCA.ToString();
                    cte_Descricao.Text = marca.DS_MARCA.Treat();
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
