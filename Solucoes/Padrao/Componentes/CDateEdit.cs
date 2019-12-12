using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CDateEdit : DateEdit
    {
        public DateTime DataMinima { get; set; }
        public DateTime DataMaxima { get; set; }
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
            this.Text.Treat();

            OnTextChanged(null);

            if (this.NaoVazio && !this.Text.HasValue())
            {
                //this.Required();
                this.Focus();
                throw new Exception(String.Format("{0}{1}!", Metodos.Prefixo, (this.Descricao.HasValue() ? this.Descricao : this.Name)));
            }
        }

        public CDateEdit()
        {
            InitializeComponent();
        }

        public CDateEdit(IContainer container)
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

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            this.DateTime = this.DateTime < this.DataMinima ? this.DataMinima : (this.DateTime > this.DataMaxima ? this.DataMaxima : this.DateTime);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            OnTextChanged(e);

            Cores.Out(this, this.Properties.ReadOnly);
        }
    }
}