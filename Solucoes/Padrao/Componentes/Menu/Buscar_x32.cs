using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Buscar_x32 : CSimpleButton
    {
        public Buscar_x32()
        {
            InitializeComponent();
        }

        public Buscar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}