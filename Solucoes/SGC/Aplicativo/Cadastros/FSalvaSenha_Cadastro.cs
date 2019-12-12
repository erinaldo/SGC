using Componentes;
using Consultas;
using Entidades;
using Formas.Padrao;
using System;
using Utilidades;

namespace Aplicativo.Cadastros
{
    public partial class FSalvaSenha_Cadastro : FPadrao_Cadastro_Menu
    {
        #region Declarações

        public E_SALVASENHA salvaSenha = new E_SALVASENHA();

        #endregion

        #region

        public FSalvaSenha_Cadastro()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                salvaSenha = new E_SALVASENHA
                {
                    OPERACAO = Operacao,
                    ID_SALVASENHA = cte_Identificador.Text.ToInt(),
                    SENHA = cte_Senha.Text.Treat(),
                    DS_OBSERVACAO = cte_Observacao.Text.Treat(),
                    LOGIN = new E_USUARIO { LOGIN = Parametros.Usuario }
                };

                var transacao = 0;

                if (C_SALVASENHA.Salvar(salvaSenha, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FSalvaSenha_Cadastro_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                if (Operacao == Operacao.Alterar)
                {
                    cte_Identificador.Text = salvaSenha.ID_SALVASENHA.ToString();
                    cte_Senha.Text = salvaSenha.SENHA.Treat();
                    cte_Observacao.Text = salvaSenha.DS_OBSERVACAO.Treat();
                }

                cte_Senha.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void cce_Visualizar_CheckedChanged(object sender, EventArgs e)
        {
            cte_Senha.Properties.UseSystemPasswordChar = !cce_Visualizar.Checked;
        }

        #endregion
    }
}