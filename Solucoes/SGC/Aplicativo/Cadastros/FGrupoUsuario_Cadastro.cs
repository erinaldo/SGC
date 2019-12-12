using Componentes;
using Consultas;
using Entidades;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FGrupoUsuario_Cadastro : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_GRUPOUSUARIO grupousuario = new E_GRUPOUSUARIO();

        #endregion

        #region Métodos

        public FGrupoUsuario_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                grupousuario = new E_GRUPOUSUARIO
                {
                    OPERACAO = Operacao,
                    ID_GRUPOUSUARIO = cte_Identificador.Text.ToInt(),
                    DS_GRUPO = cte_Descricao.Text.Treat(),
                };

                var transacao = 0;

                if (C_GRUPOUSUARIO.Salvar(grupousuario, ref transacao))
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
                    cte_Identificador.Text = grupousuario.ID_GRUPOUSUARIO.ToString();
                    cte_Descricao.Text = grupousuario.DS_GRUPO.Treat();
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