using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Buscar_x16 : CSimpleButton
    {
        public Buscar_x16()
        {
            InitializeComponent();
        }

        public Buscar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}