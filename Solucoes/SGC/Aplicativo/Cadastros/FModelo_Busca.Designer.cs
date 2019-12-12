namespace Aplicativo.Cadastros
{
    partial class FModelo_Busca
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
            this.gc_Modelo = new DevExpress.XtraGrid.GridControl();
            this.gv_Modelo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_MODELO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MODELO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MARCA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Modelo)).BeginInit();
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
            // gc_Modelo
            // 
            this.gc_Modelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Modelo.Location = new System.Drawing.Point(0, 50);
            this.gc_Modelo.MainView = this.gv_Modelo;
            this.gc_Modelo.Name = "gc_Modelo";
            this.gc_Modelo.Size = new System.Drawing.Size(734, 361);
            this.gc_Modelo.TabIndex = 5;
            this.gc_Modelo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Modelo});
            // 
            // gv_Modelo
            // 
            this.gv_Modelo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_MODELO,
            this.colDS_MODELO,
            this.colDS_MARCA});
            this.gv_Modelo.GridControl = this.gc_Modelo;
            this.gv_Modelo.Name = "gv_Modelo";
            this.gv_Modelo.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Modelo.OptionsFind.AlwaysVisible = true;
            this.gv_Modelo.OptionsView.ColumnAutoWidth = false;
            this.gv_Modelo.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Modelo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_MODELO, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_MODELO
            // 
            this.colID_MODELO.Caption = "Identificador";
            this.colID_MODELO.FieldName = "ID_MODELO";
            this.colID_MODELO.Name = "colID_MODELO";
            this.colID_MODELO.OptionsColumn.AllowEdit = false;
            this.colID_MODELO.OptionsColumn.AllowFocus = false;
            this.colID_MODELO.Visible = true;
            this.colID_MODELO.VisibleIndex = 0;
            this.colID_MODELO.Width = 86;
            // 
            // colDS_MODELO
            // 
            this.colDS_MODELO.Caption = "Modelo";
            this.colDS_MODELO.FieldName = "DS_MODELO";
            this.colDS_MODELO.Name = "colDS_MODELO";
            this.colDS_MODELO.OptionsColumn.AllowEdit = false;
            this.colDS_MODELO.OptionsColumn.AllowFocus = false;
            this.colDS_MODELO.Visible = true;
            this.colDS_MODELO.VisibleIndex = 1;
            // 
            // colDS_MARCA
            // 
            this.colDS_MARCA.Caption = "Marca";
            this.colDS_MARCA.FieldName = "MARCA.DS_MARCA";
            this.colDS_MARCA.Name = "colDS_MARCA";
            this.colDS_MARCA.OptionsColumn.AllowEdit = false;
            this.colDS_MARCA.OptionsColumn.AllowFocus = false;
            this.colDS_MARCA.Visible = true;
            this.colDS_MARCA.VisibleIndex = 2;
            // 
            // FModelo_Busca
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Modelo);
            this.Name = "FModelo_Busca";
            this.Text = "Cadastro - Modelo";
            this.Controls.SetChildIndex(this.gc_Modelo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Modelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Modelo;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn colID_MODELO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MODELO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MARCA;
    }
}
