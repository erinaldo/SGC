using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CPictureEdit : PictureEdit
    {
        public CPictureEdit()
        {
            InitializeComponent();
        }

        public CPictureEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}