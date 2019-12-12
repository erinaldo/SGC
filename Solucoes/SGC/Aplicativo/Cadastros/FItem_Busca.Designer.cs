namespace Aplicativo.Cadastros
{
    partial class FItem_Busca
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
            this.gc_Item = new DevExpress.XtraGrid.GridControl();
            this.gv_Item = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).BeginInit();
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
            // gc_Item
            // 
            this.gc_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Item.Location = new System.Drawing.Point(0, 50);
            this.gc_Item.MainView = this.gv_Item;
            this.gc_Item.Name = "gc_Item";
            this.gc_Item.Size = new System.Drawing.Size(713, 337);
            this.gc_Item.TabIndex = 6;
            this.gc_Item.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Item});
            // 
            // gv_Item
            // 
            this.gv_Item.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_ITEM,
            this.colDS_ITEM,
            this.colGrupoProduto,
            this.colModelo,
            this.colMarca});
            this.gv_Item.GridControl = this.gc_Item;
            this.gv_Item.Name = "gv_Item";
            this.gv_Item.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Item.OptionsFind.AlwaysVisible = true;
            this.gv_Item.OptionsView.ColumnAutoWidth = false;
            this.gv_Item.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Item.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_ITEM, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_ITEM
            // 
            this.colID_ITEM.Caption = "Identificador";
            this.colID_ITEM.FieldName = "ID_ITEM";
            this.colID_ITEM.Name = "colID_ITEM";
            this.colID_ITEM.OptionsColumn.AllowEdit = false;
            this.colID_ITEM.OptionsColumn.AllowFocus = false;
            this.colID_ITEM.Visible = true;
            this.colID_ITEM.VisibleIndex = 0;
            this.colID_ITEM.Width = 86;
            // 
            // colDS_ITEM
            // 
            this.colDS_ITEM.Caption = "Descrição";
            this.colDS_ITEM.FieldName = "DS_ITEM";
            this.colDS_ITEM.Name = "colDS_ITEM";
            this.colDS_ITEM.OptionsColumn.AllowEdit = false;
            this.colDS_ITEM.OptionsColumn.AllowFocus = false;
            this.colDS_ITEM.Visible = true;
            this.colDS_ITEM.VisibleIndex = 1;
            // 
            // colGrupoProduto
            // 
            this.colGrupoProduto.Caption = "Grupo Produto";
            this.colGrupoProduto.FieldName = "GRUPOPRODUTO.DS_GRUPO";
            this.colGrupoProduto.Name = "colGrupoProduto";
            this.colGrupoProduto.OptionsColumn.AllowEdit = false;
            this.colGrupoProduto.OptionsColumn.AllowFocus = false;
            this.colGrupoProduto.Visible = true;
            this.colGrupoProduto.VisibleIndex = 2;
            this.colGrupoProduto.Width = 82;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "MODELO.DS_MODELO";
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.AllowFocus = false;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 3;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "MODELO.MARCA.DS_MARCA";
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.AllowFocus = false;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 4;
            // 
            // FItem_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 387);
            this.Controls.Add(this.gc_Item);
            this.Name = "FItem_Busca";
            this.Text = "Cadastro - Item";
            this.Controls.SetChildIndex(this.gc_Item, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Item;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Item;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ITEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_ITEM;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
    }
}