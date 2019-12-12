using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Adicionar_x32 : CSimpleButton
    {
        public Adicionar_x32()
        {
            InitializeComponent();
        }

        public Adicionar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}