namespace Formas.Pesquisa
{
    partial class FPesquisa
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
            this.gc_Pesquisa = new DevExpress.XtraGrid.GridControl();
            this.gv_Pesquisa = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Pesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Pesquisa
            // 
            this.gc_Pesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Pesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Pesquisa.Location = new System.Drawing.Point(0, 0);
            this.gc_Pesquisa.MainView = this.gv_Pesquisa;
            this.gc_Pesquisa.Name = "gc_Pesquisa";
            this.gc_Pesquisa.Size = new System.Drawing.Size(734, 411);
            this.gc_Pesquisa.TabIndex = 1;
            this.gc_Pesquisa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Pesquisa});
            // 
            // gv_Pesquisa
            // 
            this.gv_Pesquisa.GridControl = this.gc_Pesquisa;
            this.gv_Pesquisa.Name = "gv_Pesquisa";
            this.gv_Pesquisa.OptionsBehavior.AutoExpandAllGroups = true;
            this.gv_Pesquisa.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Pesquisa.OptionsFind.AlwaysVisible = true;
            this.gv_Pesquisa.OptionsView.ColumnAutoWidth = false;
            this.gv_Pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_Pesquisa_KeyDown);
            this.gv_Pesquisa.DoubleClick += new System.EventHandler(this.gv_Pesquisa_DoubleClick);
            // 
            // FPesquisa
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Pesquisa);
            this.Name = "FPesquisa";
            this.Text = "Por favor, selecione o(s) registro(s) desejado(s)!";
            this.Load += new System.EventHandler(this.FPesquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Pesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Pesquisa;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Pesquisa;
    }
}
