using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CRadioGroup : RadioGroup
    {
        public CRadioGroup()
        {
            InitializeComponent();
        }

        public CRadioGroup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            Cores.In(this, this.Properties.ReadOnly);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            Cores.Out(this, this.Properties.ReadOnly);
        }
    }
}