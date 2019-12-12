using DevExpress.XtraEditors;
using System.ComponentModel;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CPanelControl : PanelControl
    {
        public CPanelControl()
        {
            InitializeComponent();
        }

        public CPanelControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}