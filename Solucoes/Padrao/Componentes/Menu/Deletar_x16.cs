using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Deletar_x16 : CSimpleButton
    {
        public Deletar_x16()
        {
            InitializeComponent();
        }

        public Deletar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}