using Componentes;
using Consultas;
using Modelo;
using System;
using System.Linq;
using Utilidades;

namespace Aplicativo.Configuracoes
{
    public partial class FConfiguracoesEmail : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Métodos

        public FConfiguracoesEmail()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();

                var transacao = 0;

                if (C_CONFIGEMAIL.Salvar(new TB_DIV_CONFIG_EMAIL
                {
                    SMTP = cte_SMTP.Text.Treat(),
                    PORTA = (int)cse_Porta.Value,
                    SSL = cce_SSL.Checked ? "S" : "N",
                    ST_ENVIAR = cce_EnviarEmails.Checked ? "S" : "N",
                    LOGIN = cte_Email.Text.Treat(),
                    SENHA = cte_Senha.Text
                }, ref transacao))
                    Finalizar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FConfiguracoesEmail_Load(object sender, EventArgs e)
        {
            try
            {
                var configuracaoBanco = (from a in Conexao.Banco.TB_DIV_CONFIG_EMAILs select a).FirstOrDefault() ?? new TB_DIV_CONFIG_EMAIL();

                cte_SMTP.Text = configuracaoBanco.SMTP.Treat();
                cse_Porta.Value = configuracaoBanco.PORTA.GetValueOrDefault();
                cce_SSL.Checked = configuracaoBanco.SSL.Treat() == "S";
                cce_EnviarEmails.Checked = configuracaoBanco.ST_ENVIAR.Treat() == "S";
                cte_Email.Text = configuracaoBanco.LOGIN.Treat();
                cte_Senha.Text = (configuracaoBanco.SENHA ?? "");

                cte_SMTP.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}