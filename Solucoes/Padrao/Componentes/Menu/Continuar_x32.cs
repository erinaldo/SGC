using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Continuar_x32 : CSimpleButton
    {
        public Continuar_x32()
        {
            InitializeComponent();
        }

        public Continuar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}