namespace Aplicativo.Cadastros
{
    partial class FGrupoProduto_Busca
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
            this.gc_GrupoProduto = new DevExpress.XtraGrid.GridControl();
            this.gv_GrupoProduto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_GrupoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_GRUPOPRODUTO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GrupoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GrupoProduto)).BeginInit();
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
            // gc_GrupoProduto
            // 
            this.gc_GrupoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GrupoProduto.Location = new System.Drawing.Point(0, 50);
            this.gc_GrupoProduto.MainView = this.gv_GrupoProduto;
            this.gc_GrupoProduto.Name = "gc_GrupoProduto";
            this.gc_GrupoProduto.Size = new System.Drawing.Size(734, 361);
            this.gc_GrupoProduto.TabIndex = 5;
            this.gc_GrupoProduto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GrupoProduto});
            // 
            // gv_GrupoProduto
            // 
            this.gv_GrupoProduto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_GrupoProduto,
            this.colDS_GRUPOPRODUTO});
            this.gv_GrupoProduto.GridControl = this.gc_GrupoProduto;
            this.gv_GrupoProduto.Name = "gv_GrupoProduto";
            this.gv_GrupoProduto.OptionsDetail.EnableMasterViewMode = false;
            this.gv_GrupoProduto.OptionsFind.AlwaysVisible = true;
            this.gv_GrupoProduto.OptionsView.ColumnAutoWidth = false;
            this.gv_GrupoProduto.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_GrupoProduto.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_GrupoProduto, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_GrupoProduto
            // 
            this.colID_GrupoProduto.Caption = "Identificador";
            this.colID_GrupoProduto.FieldName = "ID_GRUPO";
            this.colID_GrupoProduto.Name = "colID_GrupoProduto";
            this.colID_GrupoProduto.OptionsColumn.AllowEdit = false;
            this.colID_GrupoProduto.OptionsColumn.AllowFocus = false;
            this.colID_GrupoProduto.Visible = true;
            this.colID_GrupoProduto.VisibleIndex = 0;
            this.colID_GrupoProduto.Width = 86;
            // 
            // colDS_GRUPOPRODUTO
            // 
            this.colDS_GRUPOPRODUTO.Caption = "Descrição";
            this.colDS_GRUPOPRODUTO.FieldName = "DS_GRUPO";
            this.colDS_GRUPOPRODUTO.Name = "colDS_GRUPOPRODUTO";
            this.colDS_GRUPOPRODUTO.OptionsColumn.AllowEdit = false;
            this.colDS_GRUPOPRODUTO.OptionsColumn.AllowFocus = false;
            this.colDS_GRUPOPRODUTO.Visible = true;
            this.colDS_GRUPOPRODUTO.VisibleIndex = 1;
            // 
            // FGrupoProduto_Busca
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_GrupoProduto);
            this.Name = "FGrupoProduto_Busca";
            this.Text = "Cadastro - Grupo Produto";
            this.Controls.SetChildIndex(this.gc_GrupoProduto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GrupoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GrupoProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GrupoProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GrupoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colID_GrupoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_GRUPOPRODUTO;
    }
}
