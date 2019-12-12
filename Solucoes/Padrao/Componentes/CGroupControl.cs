using DevExpress.XtraEditors;
using System.ComponentModel;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CGroupControl : GroupControl
    {
        public CGroupControl()
        {
            InitializeComponent();

            this.BackColor = Cores.Sistema();
        }

        public CGroupControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}