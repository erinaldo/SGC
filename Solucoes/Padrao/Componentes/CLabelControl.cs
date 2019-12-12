using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CLabelControl : LabelControl
    {
        public CLabelControl()
        {
            InitializeComponent();
        }

        public CLabelControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}