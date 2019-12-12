using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CListBoxControl : ListBoxControl
    {
        public CListBoxControl()
        {
            InitializeComponent();
        }

        public CListBoxControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            Cores.In(this, false);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            Cores.Out(this, false);
        }
    }
}