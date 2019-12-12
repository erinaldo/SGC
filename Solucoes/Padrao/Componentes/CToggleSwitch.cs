using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CToggleSwitch : ToggleSwitch
    {
        public CToggleSwitch()
        {
            InitializeComponent();
        }

        public CToggleSwitch(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}