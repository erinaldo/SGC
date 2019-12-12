using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Cancelar_x16 : CSimpleButton
    {
        public Cancelar_x16()
        {
            InitializeComponent();
        }

        public Cancelar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}