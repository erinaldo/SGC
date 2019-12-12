using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Painel_x32 : CPanelControl
    {
        public Painel_x32()
        {
            InitializeComponent();
        }

        public Painel_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}