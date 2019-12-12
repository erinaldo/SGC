namespace Aplicativo.Cadastros
{
    partial class FCargo_Busca
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
            this.gc_Cargo = new DevExpress.XtraGrid.GridControl();
            this.gv_Cargo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_CARGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CARGO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Cargo)).BeginInit();
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
            // gc_Cargo
            // 
            this.gc_Cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Cargo.Location = new System.Drawing.Point(0, 50);
            this.gc_Cargo.MainView = this.gv_Cargo;
            this.gc_Cargo.Name = "gc_Cargo";
            this.gc_Cargo.Size = new System.Drawing.Size(734, 361);
            this.gc_Cargo.TabIndex = 5;
            this.gc_Cargo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Cargo});
            // 
            // gv_Cargo
            // 
            this.gv_Cargo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_CARGO,
            this.colDS_CARGO});
            this.gv_Cargo.GridControl = this.gc_Cargo;
            this.gv_Cargo.Name = "gv_Cargo";
            this.gv_Cargo.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Cargo.OptionsFind.AlwaysVisible = true;
            this.gv_Cargo.OptionsView.ColumnAutoWidth = false;
            this.gv_Cargo.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Cargo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_CARGO, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_CARGO
            // 
            this.colID_CARGO.Caption = "Identificador";
            this.colID_CARGO.FieldName = "ID_CARGO";
            this.colID_CARGO.Name = "colID_CARGO";
            this.colID_CARGO.OptionsColumn.AllowEdit = false;
            this.colID_CARGO.OptionsColumn.AllowFocus = false;
            this.colID_CARGO.Visible = true;
            this.colID_CARGO.VisibleIndex = 0;
            this.colID_CARGO.Width = 86;
            // 
            // colDS_CARGO
            // 
            this.colDS_CARGO.Caption = "Descrição";
            this.colDS_CARGO.FieldName = "DS_CARGO";
            this.colDS_CARGO.Name = "colDS_CARGO";
            this.colDS_CARGO.OptionsColumn.AllowEdit = false;
            this.colDS_CARGO.OptionsColumn.AllowFocus = false;
            this.colDS_CARGO.Visible = true;
            this.colDS_CARGO.VisibleIndex = 1;
            // 
            // FCargo_Busca
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Cargo);
            this.Name = "FCargo_Busca";
            this.Text = "Cadastro - Cargo";
            this.Controls.SetChildIndex(this.gc_Cargo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Cargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CARGO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CARGO;
    }
}
