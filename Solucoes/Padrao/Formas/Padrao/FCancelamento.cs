using System.Windows.Forms;

namespace Formas.Padrao
{
    public partial class FCancelamento : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        public string DS_Motivo = "";

        public FCancelamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            DS_Motivo = cte_Motivo.Text.Trim();
            DialogResult = DialogResult.OK;
        }
    }
}
