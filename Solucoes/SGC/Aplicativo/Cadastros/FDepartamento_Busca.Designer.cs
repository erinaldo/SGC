namespace Aplicativo.Cadastros
{
    partial class FDepartamento_Busca
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
            this.gc_Departamento = new DevExpress.XtraGrid.GridControl();
            this.gv_Departamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_DEPARTAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DEPARTAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Departamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Departamento)).BeginInit();
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
            // gc_Departamento
            // 
            this.gc_Departamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Departamento.Location = new System.Drawing.Point(0, 50);
            this.gc_Departamento.MainView = this.gv_Departamento;
            this.gc_Departamento.Name = "gc_Departamento";
            this.gc_Departamento.Size = new System.Drawing.Size(734, 361);
            this.gc_Departamento.TabIndex = 5;
            this.gc_Departamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Departamento});
            // 
            // gv_Departamento
            // 
            this.gv_Departamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_DEPARTAMENTO,
            this.colDS_DEPARTAMENTO});
            this.gv_Departamento.GridControl = this.gc_Departamento;
            this.gv_Departamento.Name = "gv_Departamento";
            this.gv_Departamento.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Departamento.OptionsFind.AlwaysVisible = true;
            this.gv_Departamento.OptionsView.ColumnAutoWidth = false;
            this.gv_Departamento.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Departamento.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_DEPARTAMENTO, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_DEPARTAMENTO
            // 
            this.colID_DEPARTAMENTO.Caption = "Identificador";
            this.colID_DEPARTAMENTO.FieldName = "ID_DEPARTAMENTO";
            this.colID_DEPARTAMENTO.Name = "colID_DEPARTAMENTO";
            this.colID_DEPARTAMENTO.OptionsColumn.AllowEdit = false;
            this.colID_DEPARTAMENTO.OptionsColumn.AllowFocus = false;
            this.colID_DEPARTAMENTO.Visible = true;
            this.colID_DEPARTAMENTO.VisibleIndex = 0;
            this.colID_DEPARTAMENTO.Width = 86;
            // 
            // colDS_DEPARTAMENTO
            // 
            this.colDS_DEPARTAMENTO.Caption = "Descrição";
            this.colDS_DEPARTAMENTO.FieldName = "DS_DEPARTAMENTO";
            this.colDS_DEPARTAMENTO.Name = "colDS_DEPARTAMENTO";
            this.colDS_DEPARTAMENTO.OptionsColumn.AllowEdit = false;
            this.colDS_DEPARTAMENTO.OptionsColumn.AllowFocus = false;
            this.colDS_DEPARTAMENTO.Visible = true;
            this.colDS_DEPARTAMENTO.VisibleIndex = 1;
            // 
            // FDepartamento_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Departamento);
            this.Name = "FDepartamento_Busca";
            this.Text = "Cadastro - Departamento";
            this.Controls.SetChildIndex(this.gc_Departamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Departamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Departamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Departamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Departamento;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DEPARTAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DEPARTAMENTO;
    }
}
