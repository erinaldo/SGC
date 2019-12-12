using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CDropDownButton : DropDownButton
    {
        public CDropDownButton()
        {
            InitializeComponent();
        }

        public CDropDownButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}