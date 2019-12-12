using DevExpress.XtraWaitForm;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CProgressPanel : ProgressPanel
    {
        public CProgressPanel()
        {
            InitializeComponent();
        }

        public CProgressPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}