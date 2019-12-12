using Componentes;
using Consultas;
using Entidades;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FGrupoProduto_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_GRUPOPRODUTO grupoproduto = new E_GRUPOPRODUTO();

        #endregion

        #region Métodos

        public FGrupoProduto_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                grupoproduto = new E_GRUPOPRODUTO
                {
                    OPERACAO = Operacao,
                    ID_GRUPO = cte_Identificador.Text.ToInt(),
                    DS_GRUPO = cte_Descricao.Text.Treat(),
                };

                var transacao = 0;

                if (C_GRUPOPRODUTO.Salvar(grupoproduto, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FGrupoProduto_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Utilidades.Operacao.Alterar)
                {
                    cte_Identificador.Text = grupoproduto.ID_GRUPO.ToString();
                    cte_Descricao.Text = grupoproduto.DS_GRUPO.Treat();
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