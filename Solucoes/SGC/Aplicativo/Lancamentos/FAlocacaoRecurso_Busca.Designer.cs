namespace Aplicativo.Lancamentos
{
    partial class FAlocacaoRecurso_Busca
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
            this.gc_AlocacaoRecurso = new DevExpress.XtraGrid.GridControl();
            this.gv_AlocacaoRecurso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_ALOCACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_OBSERVACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRUPOUSUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIPAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_INICIO_HMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_FINAL_HMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MARCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MODELO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AlocacaoRecurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AlocacaoRecurso)).BeginInit();
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
            // gc_AlocacaoRecurso
            // 
            this.gc_AlocacaoRecurso.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_AlocacaoRecurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_AlocacaoRecurso.Location = new System.Drawing.Point(0, 50);
            this.gc_AlocacaoRecurso.MainView = this.gv_AlocacaoRecurso;
            this.gc_AlocacaoRecurso.Name = "gc_AlocacaoRecurso";
            this.gc_AlocacaoRecurso.Size = new System.Drawing.Size(734, 361);
            this.gc_AlocacaoRecurso.TabIndex = 7;
            this.gc_AlocacaoRecurso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AlocacaoRecurso});
            // 
            // gv_AlocacaoRecurso
            // 
            this.gv_AlocacaoRecurso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_ALOCACAO,
            this.colDS_OBSERVACAO,
            this.colGRUPOUSUARIO,
            this.colEQUIPAMENTO,
            this.colDT_INICIO_HMS,
            this.colDT_FINAL_HMS,
            this.colDS_MARCA,
            this.colDS_MODELO});
            this.gv_AlocacaoRecurso.GridControl = this.gc_AlocacaoRecurso;
            this.gv_AlocacaoRecurso.Name = "gv_AlocacaoRecurso";
            this.gv_AlocacaoRecurso.OptionsDetail.EnableMasterViewMode = false;
            this.gv_AlocacaoRecurso.OptionsFind.AlwaysVisible = true;
            this.gv_AlocacaoRecurso.OptionsView.ColumnAutoWidth = false;
            this.gv_AlocacaoRecurso.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_AlocacaoRecurso.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_ALOCACAO, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_ALOCACAO
            // 
            this.colID_ALOCACAO.Caption = "Identificador";
            this.colID_ALOCACAO.FieldName = "ID_ALOCACAO";
            this.colID_ALOCACAO.Name = "colID_ALOCACAO";
            this.colID_ALOCACAO.OptionsColumn.AllowEdit = false;
            this.colID_ALOCACAO.OptionsColumn.AllowFocus = false;
            this.colID_ALOCACAO.Visible = true;
            this.colID_ALOCACAO.VisibleIndex = 0;
            this.colID_ALOCACAO.Width = 86;
            // 
            // colDS_OBSERVACAO
            // 
            this.colDS_OBSERVACAO.Caption = "Observação";
            this.colDS_OBSERVACAO.FieldName = "DS_OBSERVACAO";
            this.colDS_OBSERVACAO.Name = "colDS_OBSERVACAO";
            this.colDS_OBSERVACAO.OptionsColumn.AllowEdit = false;
            this.colDS_OBSERVACAO.OptionsColumn.AllowFocus = false;
            this.colDS_OBSERVACAO.Visible = true;
            this.colDS_OBSERVACAO.VisibleIndex = 1;
            // 
            // colGRUPOUSUARIO
            // 
            this.colGRUPOUSUARIO.Caption = "Grupo";
            this.colGRUPOUSUARIO.FieldName = "GRUPOUSUARIO";
            this.colGRUPOUSUARIO.Name = "colGRUPOUSUARIO";
            this.colGRUPOUSUARIO.OptionsColumn.AllowEdit = false;
            this.colGRUPOUSUARIO.OptionsColumn.AllowFocus = false;
            this.colGRUPOUSUARIO.Visible = true;
            this.colGRUPOUSUARIO.VisibleIndex = 2;
            // 
            // colEQUIPAMENTO
            // 
            this.colEQUIPAMENTO.Caption = "Equipamento";
            this.colEQUIPAMENTO.FieldName = "EQUIPAMENTO";
            this.colEQUIPAMENTO.Name = "colEQUIPAMENTO";
            this.colEQUIPAMENTO.OptionsColumn.AllowEdit = false;
            this.colEQUIPAMENTO.OptionsColumn.AllowFocus = false;
            this.colEQUIPAMENTO.Visible = true;
            this.colEQUIPAMENTO.VisibleIndex = 3;
            // 
            // colDT_INICIO_HMS
            // 
            this.colDT_INICIO_HMS.Caption = "Data Inicio";
            this.colDT_INICIO_HMS.DisplayFormat.FormatString = "g";
            this.colDT_INICIO_HMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_INICIO_HMS.FieldName = "DT_INICIO_HMS";
            this.colDT_INICIO_HMS.GroupFormat.FormatString = "d";
            this.colDT_INICIO_HMS.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_INICIO_HMS.Name = "colDT_INICIO_HMS";
            this.colDT_INICIO_HMS.OptionsColumn.AllowEdit = false;
            this.colDT_INICIO_HMS.OptionsColumn.AllowFocus = false;
            this.colDT_INICIO_HMS.Visible = true;
            this.colDT_INICIO_HMS.VisibleIndex = 4;
            // 
            // colDT_FINAL_HMS
            // 
            this.colDT_FINAL_HMS.Caption = "Data final";
            this.colDT_FINAL_HMS.DisplayFormat.FormatString = "g";
            this.colDT_FINAL_HMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_FINAL_HMS.FieldName = "DT_FINAL_HMS";
            this.colDT_FINAL_HMS.GroupFormat.FormatString = "d";
            this.colDT_FINAL_HMS.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_FINAL_HMS.Name = "colDT_FINAL_HMS";
            this.colDT_FINAL_HMS.OptionsColumn.AllowEdit = false;
            this.colDT_FINAL_HMS.OptionsColumn.AllowFocus = false;
            this.colDT_FINAL_HMS.Visible = true;
            this.colDT_FINAL_HMS.VisibleIndex = 5;
            // 
            // colDS_MARCA
            // 
            this.colDS_MARCA.Caption = "Marca";
            this.colDS_MARCA.FieldName = "DS_MARCA";
            this.colDS_MARCA.Name = "colDS_MARCA";
            this.colDS_MARCA.OptionsColumn.AllowEdit = false;
            this.colDS_MARCA.OptionsColumn.AllowFocus = false;
            this.colDS_MARCA.Visible = true;
            this.colDS_MARCA.VisibleIndex = 6;
            // 
            // colDS_MODELO
            // 
            this.colDS_MODELO.Caption = "Modelo";
            this.colDS_MODELO.FieldName = "DS_MODELO";
            this.colDS_MODELO.Name = "colDS_MODELO";
            this.colDS_MODELO.OptionsColumn.AllowEdit = false;
            this.colDS_MODELO.OptionsColumn.AllowFocus = false;
            this.colDS_MODELO.Visible = true;
            this.colDS_MODELO.VisibleIndex = 7;
            // 
            // FAlocacaoRecurso_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_AlocacaoRecurso);
            this.Name = "FAlocacaoRecurso_Busca";
            this.Text = "Lançamento - Alocação de recurso";
            this.Controls.SetChildIndex(this.gc_AlocacaoRecurso, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AlocacaoRecurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AlocacaoRecurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_AlocacaoRecurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AlocacaoRecurso;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ALOCACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_OBSERVACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colGRUPOUSUARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIPAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_INICIO_HMS;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_FINAL_HMS;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MARCA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MODELO;
    }
}