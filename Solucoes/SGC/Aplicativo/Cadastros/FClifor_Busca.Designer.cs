namespace Aplicativo.Cadastros
{
    partial class FClifor_Busca
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
            this.gc_Clifor = new DevExpress.XtraGrid.GridControl();
            this.gv_Clifor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_CLIFOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CLIFOR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Clifor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Clifor)).BeginInit();
            this.SuspendLayout();
            // 
            // csb_Adicionar
            // 
            this.csb_Adicionar.Appearance.Options.UseTextOptions = true;
            this.csb_Adicionar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // csb_Deletar
            // 
            this.csb_Deletar.Appearance.Options.UseTextOptions = true;
            this.csb_Deletar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // csb_Alterar
            // 
            this.csb_Alterar.Appearance.Options.UseTextOptions = true;
            this.csb_Alterar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // csb_Relatorio
            // 
            this.csb_Relatorio.Appearance.Options.UseTextOptions = true;
            this.csb_Relatorio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // gc_Clifor
            // 
            this.gc_Clifor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Clifor.Location = new System.Drawing.Point(0, 50);
            this.gc_Clifor.MainView = this.gv_Clifor;
            this.gc_Clifor.Name = "gc_Clifor";
            this.gc_Clifor.Size = new System.Drawing.Size(734, 361);
            this.gc_Clifor.TabIndex = 5;
            this.gc_Clifor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Clifor});
            // 
            // gv_Clifor
            // 
            this.gv_Clifor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_CLIFOR,
            this.colNM_CLIFOR});
            this.gv_Clifor.GridControl = this.gc_Clifor;
            this.gv_Clifor.Name = "gv_Clifor";
            this.gv_Clifor.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Clifor.OptionsFind.AlwaysVisible = true;
            this.gv_Clifor.OptionsView.ColumnAutoWidth = false;
            this.gv_Clifor.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Clifor.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_CLIFOR, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_CLIFOR
            // 
            this.colID_CLIFOR.Caption = "Identificador";
            this.colID_CLIFOR.FieldName = "ID_CLIFOR";
            this.colID_CLIFOR.Name = "colID_CLIFOR";
            this.colID_CLIFOR.OptionsColumn.AllowEdit = false;
            this.colID_CLIFOR.OptionsColumn.AllowFocus = false;
            this.colID_CLIFOR.Visible = true;
            this.colID_CLIFOR.VisibleIndex = 0;
            this.colID_CLIFOR.Width = 86;
            // 
            // colNM_CLIFOR
            // 
            this.colNM_CLIFOR.Caption = "Descrição";
            this.colNM_CLIFOR.FieldName = "NM_CLIFOR";
            this.colNM_CLIFOR.Name = "colNM_CLIFOR";
            this.colNM_CLIFOR.OptionsColumn.AllowEdit = false;
            this.colNM_CLIFOR.OptionsColumn.AllowFocus = false;
            this.colNM_CLIFOR.Visible = true;
            this.colNM_CLIFOR.VisibleIndex = 1;
            // 
            // FClifor_Busca
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Clifor);
            this.Name = "FClifor_Busca";
            this.Text = "Cadastro - Cliente";
            this.Controls.SetChildIndex(this.gc_Clifor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Clifor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Clifor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Clifor;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Clifor;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CLIFOR;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CLIFOR;
    }
}
