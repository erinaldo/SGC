namespace Aplicativo.Cadastros
{
    partial class FCategoria_Busca
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
            this.gc_Categoria = new DevExpress.XtraGrid.GridControl();
            this.gv_Categoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_CATEGORIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CATEGORIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGravidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempoMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempoMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificacao = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Categoria)).BeginInit();
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
            // gc_Categoria
            // 
            this.gc_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Categoria.Location = new System.Drawing.Point(0, 50);
            this.gc_Categoria.MainView = this.gv_Categoria;
            this.gc_Categoria.Name = "gc_Categoria";
            this.gc_Categoria.Size = new System.Drawing.Size(734, 361);
            this.gc_Categoria.TabIndex = 6;
            this.gc_Categoria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Categoria});
            // 
            // gv_Categoria
            // 
            this.gv_Categoria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_CATEGORIA,
            this.colDS_CATEGORIA,
            this.colDepartamento,
            this.colGravidade,
            this.colTempoMin,
            this.colTempoMax,
            this.colTipo,
            this.colClassificacao});
            this.gv_Categoria.GridControl = this.gc_Categoria;
            this.gv_Categoria.Name = "gv_Categoria";
            this.gv_Categoria.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Categoria.OptionsFind.AlwaysVisible = true;
            this.gv_Categoria.OptionsView.ColumnAutoWidth = false;
            this.gv_Categoria.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_CATEGORIA, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_CATEGORIA
            // 
            this.colID_CATEGORIA.Caption = "Identificador";
            this.colID_CATEGORIA.FieldName = "ID_CATEGORIA";
            this.colID_CATEGORIA.Name = "colID_CATEGORIA";
            this.colID_CATEGORIA.OptionsColumn.AllowEdit = false;
            this.colID_CATEGORIA.OptionsColumn.AllowFocus = false;
            this.colID_CATEGORIA.Visible = true;
            this.colID_CATEGORIA.VisibleIndex = 0;
            this.colID_CATEGORIA.Width = 83;
            // 
            // colDS_CATEGORIA
            // 
            this.colDS_CATEGORIA.Caption = "Descrição";
            this.colDS_CATEGORIA.FieldName = "DS_CATEGORIA";
            this.colDS_CATEGORIA.Name = "colDS_CATEGORIA";
            this.colDS_CATEGORIA.OptionsColumn.AllowEdit = false;
            this.colDS_CATEGORIA.OptionsColumn.AllowFocus = false;
            this.colDS_CATEGORIA.Visible = true;
            this.colDS_CATEGORIA.VisibleIndex = 1;
            // 
            // colDepartamento
            // 
            this.colDepartamento.Caption = "Departamento";
            this.colDepartamento.FieldName = "DS_DEPARTAMENTO";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.OptionsColumn.AllowEdit = false;
            this.colDepartamento.OptionsColumn.AllowFocus = false;
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 2;
            this.colDepartamento.Width = 78;
            // 
            // colGravidade
            // 
            this.colGravidade.Caption = "Gravidade";
            this.colGravidade.FieldName = "GRAVIDADE";
            this.colGravidade.Name = "colGravidade";
            this.colGravidade.OptionsColumn.AllowEdit = false;
            this.colGravidade.OptionsColumn.AllowFocus = false;
            this.colGravidade.Visible = true;
            this.colGravidade.VisibleIndex = 3;
            // 
            // colTempoMin
            // 
            this.colTempoMin.Caption = "Tempo Min.";
            this.colTempoMin.FieldName = "TEMPO_HORA_MIN";
            this.colTempoMin.Name = "colTempoMin";
            this.colTempoMin.OptionsColumn.AllowEdit = false;
            this.colTempoMin.OptionsColumn.AllowFocus = false;
            this.colTempoMin.Visible = true;
            this.colTempoMin.VisibleIndex = 4;
            // 
            // colTempoMax
            // 
            this.colTempoMax.Caption = "Tempo Max.";
            this.colTempoMax.FieldName = "TEMPO_HORA_MAX";
            this.colTempoMax.Name = "colTempoMax";
            this.colTempoMax.OptionsColumn.AllowEdit = false;
            this.colTempoMax.OptionsColumn.AllowFocus = false;
            this.colTempoMax.Visible = true;
            this.colTempoMax.VisibleIndex = 5;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "TIPO";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.OptionsColumn.AllowFocus = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 6;
            // 
            // colClassificacao
            // 
            this.colClassificacao.Caption = "Classificação";
            this.colClassificacao.FieldName = "CLASSIFICACAO";
            this.colClassificacao.Name = "colClassificacao";
            this.colClassificacao.OptionsColumn.AllowEdit = false;
            this.colClassificacao.OptionsColumn.AllowFocus = false;
            this.colClassificacao.Visible = true;
            this.colClassificacao.VisibleIndex = 7;
            // 
            // FCategoria_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Categoria);
            this.Name = "FCategoria_Busca";
            this.Text = "Cadastro - Categorias";
            this.Controls.SetChildIndex(this.gc_Categoria, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Categoria;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CATEGORIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CATEGORIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colGravidade;
        private DevExpress.XtraGrid.Columns.GridColumn colTempoMin;
        private DevExpress.XtraGrid.Columns.GridColumn colTempoMax;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificacao;
    }
}