using System.Windows.Forms;

namespace Formas.Padrao
{
    public partial class FPadrao_Cadastro_Menu : FPadrao_Cadastro
    {
        public FPadrao_Cadastro_Menu()
        {
            InitializeComponent();
        }

        private void csb_Salvar_Click(object sender = null, System.EventArgs e = null)
        {
            this.Salvar();
        }

        private void csb_Cancelar_Click(object sender = null, System.EventArgs e = null)
        {
            this.Cancelar();
        }

        private void FPadrao_Cadastro_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: csb_Salvar_Click(); return;
                case Keys.Escape: csb_Cancelar_Click(); return;
                default: return;
            }
        }
    }
}