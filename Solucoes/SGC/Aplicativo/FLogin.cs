using Aplicativo.Properties;
using Componentes;
using Formas.Padrao;
using System;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo
{
    public partial class FLogin : FPadrao
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void csb_Entrar_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                cpc_Configuracoes.Controls.Validate();
                cpc_Login.Controls.Validate();

                Conexao.Parametros.Servidor = ccbe_ServidorInstancia.Text.Trim();
                Conexao.Parametros.Banco = ccbe_BancoDados.Text.Trim();
                

                Conexao.Testar();

                if (Conexao.Banco.TB_DIV_USUARIOs.Any(a => a.LOGIN == cte_Usuario.Text.Trim() && a.SENHA == cte_Senha.Text.Trim()) || (cte_Usuario.Text.Trim() == Parametros.Administrador && cte_Senha.Text.Trim() == Parametros.Senha))
                    DialogResult = DialogResult.OK;
                else
                {
                    cte_Usuario.Select();
                    throw new Exception("Usuário / senha inválido(s)!\nPor favor, verifique!");
                }

                Parametros.Logado = true;
                Parametros.Usuario = cte_Usuario.Text.ToUpper().Trim();

                Dispose();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        private void KeyDown_Login(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cte_Usuario.Text.HasValue() && cte_Senha.Text.HasValue())
                csb_Entrar.PerformClick();
        }

        private void KeyDown_Configuracoes(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ccbe_ServidorInstancia.Text.HasValue() && ccbe_BancoDados.Text.HasValue())
                csb_SalvarConfiguracoes.PerformClick();
        }

        private void csb_SalvarConfiguracoes_Click(object sender = null, EventArgs e = null)
        {
            Settings.Default.Servidor = ccbe_ServidorInstancia.Text.Trim();
            Settings.Default.Banco = ccbe_BancoDados.Text.Trim();
            Settings.Default.Save();

            Mensagens.Sucesso("Configurações salvas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FLogin_Load(object sender = null, EventArgs e = null)
        {
            ccbe_ServidorInstancia.Text = Settings.Default.Servidor.Treat();
            ccbe_BancoDados.Text = Settings.Default.Banco.Treat();

            xtc_Abas.SelectedTabPage = xtp_Configuracoes;

            if (!ccbe_ServidorInstancia.Text.HasValue())
                ccbe_ServidorInstancia.Select();
            else if (!ccbe_BancoDados.Text.HasValue())
                ccbe_BancoDados.Select();
            else
            {
                xtc_Abas.SelectedTabPage = xtp_Login;
                cte_Usuario.Select();
            }
        }
    }
}