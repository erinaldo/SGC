using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Salvar_x32 : CSimpleButton
    {
        public Salvar_x32()
        {
            InitializeComponent();
        }

        public Salvar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}