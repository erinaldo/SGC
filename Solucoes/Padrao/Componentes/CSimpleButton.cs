using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CSimpleButton : SimpleButton
    {
        public CSimpleButton()
        {
            InitializeComponent();
        }

        public CSimpleButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}