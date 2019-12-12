using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicativo
{
    public partial class FPrincipal : Formas.Padrao.FPadrao
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            bsi_DetalhesConexao.Caption = "<b>Servidor:</b> {0} <b>| Banco de dados:</b> {1}";
        }
    }
}
