using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Relatorio_x32 : CSimpleButton
    {
        public Relatorio_x32()
        {
            InitializeComponent();
        }

        public Relatorio_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}