using DevExpress.XtraEditors;
using System.Windows.Forms;
using Utilidades;

namespace Formas.Padrao
{
    public partial class FPadrao : XtraForm
    {
        public FPadrao()
        {
            InitializeComponent();
        }

        public void AdicionarForma(Form forma)
        {
            AddOwnedForm(forma);
            forma.MdiParent = this;
        }

        public void MostrarForma(Form forma)
        {
            AdicionarForma(forma);
            forma.Show();
        }

        public void MostrarFormaDialog(Form forma)
        {
            forma.ShowDialog();
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            Extensoes.Layout(this, true);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            Extensoes.Layout(this, false);
        }
    }
}