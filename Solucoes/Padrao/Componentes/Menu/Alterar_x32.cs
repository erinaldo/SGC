using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Alterar_x32 : CSimpleButton
    {
        public Alterar_x32()
        {
            InitializeComponent();
        }

        public Alterar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}