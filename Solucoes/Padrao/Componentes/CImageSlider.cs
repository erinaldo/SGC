using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CImageSlider : ImageSlider
    {
        public CImageSlider()
        {
            InitializeComponent();
        }

        public CImageSlider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
