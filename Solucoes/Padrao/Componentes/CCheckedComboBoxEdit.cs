using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CCheckedComboBoxEdit : CheckedComboBoxEdit
    {
        public CCheckedComboBoxEdit()
        {
            InitializeComponent();
        }

        public CCheckedComboBoxEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            Cores.In(this, this.Properties.ReadOnly);

            this.Select(this.Text.Length, 0);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            Cores.Out(this, this.Properties.ReadOnly);
        }
    }
}
