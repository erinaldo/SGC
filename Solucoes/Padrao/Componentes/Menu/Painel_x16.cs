using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Painel_x16 : CPanelControl
    {
        public Painel_x16()
        {
            InitializeComponent();
        }

        public Painel_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}