using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CButtonEdit : ButtonEdit
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

        public CButtonEdit()
        {
            InitializeComponent();
        }

        public CButtonEdit(IContainer container)
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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Enter && this.Properties.Buttons.Count > 0 && !this.Properties.ReadOnly)
                this.PerformClick(this.Properties.Buttons[0]);
        }
    }
}