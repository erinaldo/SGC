namespace Aplicativo.Lancamentos
{
    partial class FAvaliacao_Lancamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.cme_Sugestao = new Componentes.CMemoEdit(this.components);
            this.clc_Sugestao = new Componentes.CLabelControl(this.components);
            this.tbc_Nota = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Sugestao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbc_Nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbc_Nota.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cme_Sugestao
            // 
            this.cme_Sugestao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cme_Sugestao.Descricao = "a sugestão";
            this.cme_Sugestao.Location = new System.Drawing.Point(12, 23);
            this.cme_Sugestao.Name = "cme_Sugestao";
            this.cme_Sugestao.NaoVazio = false;
            this.cme_Sugestao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Sugestao.Properties.MaxLength = 256;
            this.cme_Sugestao.SemAcentuacao = false;
            this.cme_Sugestao.SemPontuacao = false;
            this.cme_Sugestao.Size = new System.Drawing.Size(710, 81);
            this.cme_Sugestao.SomenteNumeros = false;
            this.cme_Sugestao.TabIndex = 13;
            this.cme_Sugestao.UseOptimizedRendering = true;
            // 
            // clc_Sugestao
            // 
            this.clc_Sugestao.Location = new System.Drawing.Point(12, 9);
            this.clc_Sugestao.Name = "clc_Sugestao";
            this.clc_Sugestao.Size = new System.Drawing.Size(45, 13);
            this.clc_Sugestao.TabIndex = 12;
            this.clc_Sugestao.Text = "Sugestão";
            // 
            // tbc_Nota
            // 
            this.tbc_Nota.EditValue = 10;
            this.tbc_Nota.Location = new System.Drawing.Point(12, 110);
            this.tbc_Nota.Name = "tbc_Nota";
            this.tbc_Nota.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbc_Nota.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "Ruim";
            trackBarLabel2.Label = "";
            trackBarLabel2.Value = 1;
            trackBarLabel3.Label = "";
            trackBarLabel3.Value = 2;
            trackBarLabel4.Label = "";
            trackBarLabel4.Value = 3;
            trackBarLabel5.Label = "";
            trackBarLabel5.Value = 4;
            trackBarLabel6.Label = "Normal";
            trackBarLabel6.Value = 5;
            trackBarLabel7.Label = "";
            trackBarLabel7.Value = 6;
            trackBarLabel8.Label = "";
            trackBarLabel8.Value = 7;
            trackBarLabel9.Label = "";
            trackBarLabel9.Value = 8;
            trackBarLabel10.Label = "";
            trackBarLabel10.Value = 9;
            trackBarLabel11.Label = "Perfeito";
            trackBarLabel11.Value = 10;
            this.tbc_Nota.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5,
            trackBarLabel6,
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10,
            trackBarLabel11});
            this.tbc_Nota.Properties.ShowLabels = true;
            this.tbc_Nota.Size = new System.Drawing.Size(710, 72);
            this.tbc_Nota.TabIndex = 15;
            this.tbc_Nota.Value = 10;
            // 
            // FAvaliacao_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 219);
            this.Controls.Add(this.tbc_Nota);
            this.Controls.Add(this.cme_Sugestao);
            this.Controls.Add(this.clc_Sugestao);
            this.Name = "FAvaliacao_Lancamento";
            this.Text = "Lançamento - Avaliação";
            this.Controls.SetChildIndex(this.clc_Sugestao, 0);
            this.Controls.SetChildIndex(this.cme_Sugestao, 0);
            this.Controls.SetChildIndex(this.tbc_Nota, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cme_Sugestao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbc_Nota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbc_Nota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.CLabelControl clc_Sugestao;
        public Componentes.CMemoEdit cme_Sugestao;
        public DevExpress.XtraEditors.TrackBarControl tbc_Nota;
    }
}
