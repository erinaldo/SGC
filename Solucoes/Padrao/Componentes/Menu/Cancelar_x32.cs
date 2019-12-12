using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Cancelar_x32 : CSimpleButton
    {
        public Cancelar_x32()
        {
            InitializeComponent();
        }

        public Cancelar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}