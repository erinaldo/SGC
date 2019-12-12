using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CProgressBarControl : ProgressBarControl
    {
        public CProgressBarControl()
        {
            InitializeComponent();
        }

        public CProgressBarControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}