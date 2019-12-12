
namespace Aplicativo.Lancamentos
{
    public partial class FAvaliacao_Lancamento : Formas.Padrao.FPadrao_Cadastro_Menu
    {
        public FAvaliacao_Lancamento()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            base.Salvar();

            Finalizar();
        }
    }
}
