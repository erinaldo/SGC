using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Deletar_x32 : CSimpleButton
    {
        public Deletar_x32()
        {
            InitializeComponent();
        }

        public Deletar_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}