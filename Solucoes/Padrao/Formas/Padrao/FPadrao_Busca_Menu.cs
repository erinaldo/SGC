using System.Windows.Forms;
using Utilidades;

namespace Formas.Padrao
{
    public partial class FPadrao_Busca_Menu : FPadrao_Busca
    {
        public FPadrao_Busca_Menu()
        {
            InitializeComponent();
        }

        public void DefinirPermissoes()
        {
            Parametros.AcessoBotoes(Identificador, csb_Adicionar, csb_Alterar, csb_Deletar, csb_Relatorio);
        }

        private void csb_Adicionar_Click(object sender = null, System.EventArgs e = null)
        {
            this.Adicionar();
        }

        private void csb_Alterar_Click(object sender = null, System.EventArgs e = null)
        {
            this.Alterar();
        }

        private void csb_Deletar_Click(object sender = null, System.EventArgs e = null)
        {
            this.Deletar();
        }

        private void csb_Buscar_Click(object sender = null, System.EventArgs e = null)
        {
            this.Buscar();
        }

        private void csb_Relatorio_Click(object sender = null, System.EventArgs e = null)
        {
            this.Relatorio();
        }

        private void csb_Sair_Click(object sender = null, System.EventArgs e = null)
        {
            this.Sair();
        }

        private void FPadrao_Busca_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: { if (csb_Adicionar.Enabled) csb_Adicionar_Click(); } return;
                case Keys.F3: { if (csb_Alterar.Enabled) csb_Alterar_Click(); } return;
                case Keys.F4: { if (csb_Deletar.Enabled) csb_Deletar_Click(); } return;
                case Keys.F5: csb_Buscar_Click(); return;
                case Keys.F7: { if (csb_Relatorio.Enabled) csb_Relatorio_Click(); } return;
                case Keys.Escape: csb_Sair_Click(); return;
            }
        }
    }
}