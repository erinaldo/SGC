using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CSpinEdit : SpinEdit
    {
        public int Decimais { get; set; }
        public bool NaoVazio { get; set; }
        public string DescricaoPrefixo
        {
            get
            {
                return Metodos.Prefixo;
            }
        }
        public string Descricao { get; set; }

        public void Validate()
        {
            OnLeave(null);

            if (this.NaoVazio && this.Value == 0m)
            {
                //this.Required();
                this.Focus();
                throw new Exception(String.Format("{0}{1}!", Metodos.Prefixo, (this.Descricao.HasValue() ? this.Descricao : this.Name)));
            }
        }

        public CSpinEdit()
        {
            InitializeComponent();
        }

        public CSpinEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.Properties.Buttons[0].Visible = false;
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

            if (this.Properties.MinValue != 0 || this.Properties.MaxValue != 0)
                this.Value = this.Value < this.Properties.MinValue ? this.Properties.MinValue : (this.Value > this.Properties.MaxValue ? this.Properties.MaxValue : this.Value);

            Cores.Out(this, this.Properties.ReadOnly);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            OnLeave(e);
        }
    }
}