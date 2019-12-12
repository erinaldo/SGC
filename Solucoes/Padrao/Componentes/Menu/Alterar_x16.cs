using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Alterar_x16 : CSimpleButton
    {
        public Alterar_x16()
        {
            InitializeComponent();
        }

        public Alterar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}