using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CMemoEdit : MemoEdit
    {
        public bool SomenteNumeros { get; set; }
        public bool SemAcentuacao { get; set; }
        public bool SemPontuacao { get; set; }
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

            if (this.NaoVazio && !this.Text.HasValue())
            {
                //this.Required();
                this.Focus();
                throw new Exception(String.Format("{0}{1}!", Metodos.Prefixo, (this.Descricao.HasValue() ? this.Descricao : this.Name)));
            }
        }

        public CMemoEdit()
        {
            InitializeComponent();
        }

        public CMemoEdit(IContainer container)
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

            if (this.SomenteNumeros)
                this.Text.OnlyNumbers();
            if (this.SemAcentuacao)
                this.Text.WithoutAccentuation();
            if (this.SemPontuacao)
                this.Text.WithoutPunctuation();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            OnTextChanged(e);

            Cores.Out(this, this.Properties.ReadOnly);
        }
    }
}