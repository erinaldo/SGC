using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CCheckEdit : CheckEdit
    {
        public CCheckEdit()
        {
            InitializeComponent();
        }

        public CCheckEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}