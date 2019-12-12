using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Relatorio_x16 : CSimpleButton
    {
        public Relatorio_x16()
        {
            InitializeComponent();
        }

        public Relatorio_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}