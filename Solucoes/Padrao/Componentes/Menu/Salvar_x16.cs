using System.ComponentModel;

namespace Componentes.Menu
{
    [ToolboxItem(true)]
    public partial class Salvar_x16 : CSimpleButton
    {
        public Salvar_x16()
        {
            InitializeComponent();
        }

        public Salvar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}