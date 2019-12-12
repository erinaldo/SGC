using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Utilidades;

namespace Componentes
{
    [ToolboxItem(true)]
    public partial class CTextEdit : TextEdit
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
        public bool Mascara_IPv4 { get; set; }
        public bool Mascara_PortaIPv4 { get; set; }

        public CTextEdit()
        {
            InitializeComponent();
        }

        public CTextEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            if (this.Mascara_IPv4)
            {
                this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                this.Properties.Mask.EditMask = @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
            }
            else if (this.Mascara_PortaIPv4)
            {
                this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                this.Properties.Mask.ShowPlaceHolders = false;
            }
        }

        public void Validate()
        {
            this.Text.Treat();
            this.OnTextChanged(new EventArgs { });

            if ((this.NaoVazio && !this.Text.HasValue()) || (this.Mascara_IPv4 && !this.Text.IPv4()))
            {
                //this.Required();
                this.Focus();
                throw new Exception(String.Format("{0}{1}!", Metodos.Prefixo, (this.Descricao.HasValue() ? this.Descricao : this.Name)));
            }
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

            OnTextChanged(e);

            Cores.Out(this, this.Properties.ReadOnly);
        }

        protected override void OnEditValueChanging(DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (this.SomenteNumeros && (e.NewValue ?? "").ToString().OnlyNumbers())
                e.NewValue = e.OldValue;
            if (this.SemAcentuacao)
                e.NewValue = (e.NewValue ?? "").ToString().WithoutAccentuation();
            if (this.SemPontuacao)
                e.NewValue = (e.NewValue ?? "").ToString().WithoutPunctuation();
            if (this.Mascara_IPv4 && !(e.NewValue ?? "").ToString().IPv4())
                e.NewValue = "255.255.255.255";
            if (this.Mascara_PortaIPv4)
                e.NewValue = ((e.NewValue ?? "").ToString().ToInt() > 65535 ? 65535 : ((e.NewValue ?? "").ToString().ToInt() < 1 ? 1 : (e.NewValue ?? "").ToString().ToInt())).ToString();

            base.OnEditValueChanging(e);
        }

    }
}