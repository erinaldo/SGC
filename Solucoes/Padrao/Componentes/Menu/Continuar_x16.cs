using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Continuar_x16 : CSimpleButton
    {
        public Continuar_x16()
        {
            InitializeComponent();
        }

        public Continuar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}