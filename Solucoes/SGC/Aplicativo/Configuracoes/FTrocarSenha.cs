using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Componentes;
using Utilidades;

namespace Aplicativo.Configuracoes
{
    public partial class FTrocarSenha : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        #region Métodos

        public FTrocarSenha()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                cpc_DadosGerais.Controls.Validate();


                var configuracaoBanco = (from a in Conexao.Banco.TB_DIV_USUARIOs where a.LOGIN == Parametros.Usuario select a).FirstOrDefault();
                if (configuracaoBanco == null)
                    throw new Exception("Só é possível alterar a senha de usuários cadastrados!");
                else if (configuracaoBanco.SENHA != cte_SenhaAntiga.Text)
                {
                    cte_SenhaAntiga.Select();
                    throw new Exception("A senha antiga informada está incorreta!");
                }

                configuracaoBanco.SENHA = cte_SenhaNova.Text;
                
                Conexao.Enviar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion

        #region Eventos

        private void FTrocarSenha_Load(object sender, EventArgs e)
        {
            try
            {
                cte_SenhaAntiga.Select();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }

        #endregion
    }
}