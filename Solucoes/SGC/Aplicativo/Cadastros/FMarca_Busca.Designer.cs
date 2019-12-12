namespace Aplicativo.Cadastros
{
    partial class FMarca_Busca
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
            this.gc_Marca = new DevExpress.XtraGrid.GridControl();
            this.gv_Marca = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_MARCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MARCA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Marca)).BeginInit();
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
            // gc_Marca
            // 
            this.gc_Marca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Marca.Location = new System.Drawing.Point(0, 50);
            this.gc_Marca.MainView = this.gv_Marca;
            this.gc_Marca.Name = "gc_Marca";
            this.gc_Marca.Size = new System.Drawing.Size(734, 361);
            this.gc_Marca.TabIndex = 6;
            this.gc_Marca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Marca});
            // 
            // gv_Marca
            // 
            this.gv_Marca.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_MARCA,
            this.colDS_MARCA});
            this.gv_Marca.GridControl = this.gc_Marca;
            this.gv_Marca.Name = "gv_Marca";
            this.gv_Marca.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Marca.OptionsFind.AlwaysVisible = true;
            this.gv_Marca.OptionsView.ColumnAutoWidth = false;
            this.gv_Marca.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Marca.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_MARCA, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_MARCA
            // 
            this.colID_MARCA.Caption = "Identificador";
            this.colID_MARCA.FieldName = "ID_MARCA";
            this.colID_MARCA.Name = "colID_MARCA";
            this.colID_MARCA.OptionsColumn.AllowEdit = false;
            this.colID_MARCA.OptionsColumn.AllowFocus = false;
            this.colID_MARCA.Visible = true;
            this.colID_MARCA.VisibleIndex = 0;
            this.colID_MARCA.Width = 86;
            // 
            // colDS_MARCA
            // 
            this.colDS_MARCA.Caption = "Descrição";
            this.colDS_MARCA.FieldName = "DS_MARCA";
            this.colDS_MARCA.Name = "colDS_MARCA";
            this.colDS_MARCA.OptionsColumn.AllowEdit = false;
            this.colDS_MARCA.OptionsColumn.AllowFocus = false;
            this.colDS_MARCA.Visible = true;
            this.colDS_MARCA.VisibleIndex = 1;
            // 
            // FMarca_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Marca);
            this.Name = "FMarca_Busca";
            this.Text = "Cadastro - Marca";
            this.Controls.SetChildIndex(this.gc_Marca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Marca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Marca;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn colID_MARCA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MARCA;
    }
}