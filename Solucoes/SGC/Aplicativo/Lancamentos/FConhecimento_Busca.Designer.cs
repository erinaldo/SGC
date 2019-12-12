namespace Aplicativo.Lancamentos
{
    partial class FConhecimento_Busca
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
            this.components = new System.ComponentModel.Container();
            this.xtc_Abas = new DevExpress.XtraTab.XtraTabControl();
            this.xtp_Conhecimentos = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Conhecimento = new DevExpress.XtraGrid.GridControl();
            this.gv_Conhecimento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_CONHECIMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_TITULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_LANCTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCATEGORIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtp_Anexos = new DevExpress.XtraTab.XtraTabPage();
            this.lbc_Anexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_Anexos = new System.Windows.Forms.BindingSource(this.components);
            this.colLOGIN_CAD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).BeginInit();
            this.xtc_Abas.SuspendLayout();
            this.xtp_Conhecimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Conhecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Conhecimento)).BeginInit();
            this.xtp_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).BeginInit();
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
            // xtc_Abas
            // 
            this.xtc_Abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtc_Abas.Location = new System.Drawing.Point(0, 50);
            this.xtc_Abas.Name = "xtc_Abas";
            this.xtc_Abas.SelectedTabPage = this.xtp_Conhecimentos;
            this.xtc_Abas.Size = new System.Drawing.Size(734, 361);
            this.xtc_Abas.TabIndex = 7;
            this.xtc_Abas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtp_Conhecimentos,
            this.xtp_Anexos});
            // 
            // xtp_Conhecimentos
            // 
            this.xtp_Conhecimentos.Controls.Add(this.gc_Conhecimento);
            this.xtp_Conhecimentos.Name = "xtp_Conhecimentos";
            this.xtp_Conhecimentos.Size = new System.Drawing.Size(728, 333);
            this.xtp_Conhecimentos.Text = "Conhecimentos";
            // 
            // gc_Conhecimento
            // 
            this.gc_Conhecimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Conhecimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Conhecimento.Location = new System.Drawing.Point(0, 0);
            this.gc_Conhecimento.MainView = this.gv_Conhecimento;
            this.gc_Conhecimento.Name = "gc_Conhecimento";
            this.gc_Conhecimento.Size = new System.Drawing.Size(728, 333);
            this.gc_Conhecimento.TabIndex = 7;
            this.gc_Conhecimento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Conhecimento});
            // 
            // gv_Conhecimento
            // 
            this.gv_Conhecimento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_CONHECIMENTO,
            this.colDS_TITULO,
            this.colDT_LANCTO,
            this.colCATEGORIA,
            this.colLOGIN_CAD});
            this.gv_Conhecimento.GridControl = this.gc_Conhecimento;
            this.gv_Conhecimento.GroupCount = 1;
            this.gv_Conhecimento.Name = "gv_Conhecimento";
            this.gv_Conhecimento.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Conhecimento.OptionsFind.AlwaysVisible = true;
            this.gv_Conhecimento.OptionsView.ColumnAutoWidth = false;
            this.gv_Conhecimento.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Conhecimento.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDT_LANCTO, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_CONHECIMENTO, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gv_Conhecimento.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Conhecimento_RowClick);
            // 
            // colID_CONHECIMENTO
            // 
            this.colID_CONHECIMENTO.Caption = "Identificador";
            this.colID_CONHECIMENTO.FieldName = "ID_CONHECIMENTO";
            this.colID_CONHECIMENTO.Name = "colID_CONHECIMENTO";
            this.colID_CONHECIMENTO.OptionsColumn.AllowEdit = false;
            this.colID_CONHECIMENTO.OptionsColumn.AllowFocus = false;
            this.colID_CONHECIMENTO.Visible = true;
            this.colID_CONHECIMENTO.VisibleIndex = 0;
            this.colID_CONHECIMENTO.Width = 86;
            // 
            // colDS_TITULO
            // 
            this.colDS_TITULO.Caption = "Título";
            this.colDS_TITULO.FieldName = "DS_TITULO";
            this.colDS_TITULO.Name = "colDS_TITULO";
            this.colDS_TITULO.OptionsColumn.AllowEdit = false;
            this.colDS_TITULO.OptionsColumn.AllowFocus = false;
            this.colDS_TITULO.Visible = true;
            this.colDS_TITULO.VisibleIndex = 1;
            this.colDS_TITULO.Width = 183;
            // 
            // colDT_LANCTO
            // 
            this.colDT_LANCTO.Caption = "Data";
            this.colDT_LANCTO.DisplayFormat.FormatString = "g";
            this.colDT_LANCTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_LANCTO.FieldName = "DT_LANCTO";
            this.colDT_LANCTO.GroupFormat.FormatString = "d";
            this.colDT_LANCTO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_LANCTO.Name = "colDT_LANCTO";
            this.colDT_LANCTO.OptionsColumn.AllowEdit = false;
            this.colDT_LANCTO.OptionsColumn.AllowFocus = false;
            this.colDT_LANCTO.Visible = true;
            this.colDT_LANCTO.VisibleIndex = 1;
            // 
            // colCATEGORIA
            // 
            this.colCATEGORIA.Caption = "Categoria";
            this.colCATEGORIA.FieldName = "CATEGORIA";
            this.colCATEGORIA.Name = "colCATEGORIA";
            this.colCATEGORIA.OptionsColumn.AllowEdit = false;
            this.colCATEGORIA.OptionsColumn.AllowFocus = false;
            this.colCATEGORIA.Visible = true;
            this.colCATEGORIA.VisibleIndex = 2;
            this.colCATEGORIA.Width = 216;
            // 
            // xtp_Anexos
            // 
            this.xtp_Anexos.Controls.Add(this.lbc_Anexos);
            this.xtp_Anexos.Name = "xtp_Anexos";
            this.xtp_Anexos.PageVisible = false;
            this.xtp_Anexos.Size = new System.Drawing.Size(728, 333);
            this.xtp_Anexos.Text = "Anexos";
            // 
            // lbc_Anexos
            // 
            this.lbc_Anexos.DataSource = this.bs_Anexos;
            this.lbc_Anexos.DisplayMember = "NM_ANEXO";
            this.lbc_Anexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_Anexos.Location = new System.Drawing.Point(0, 0);
            this.lbc_Anexos.Name = "lbc_Anexos";
            this.lbc_Anexos.Size = new System.Drawing.Size(728, 333);
            this.lbc_Anexos.TabIndex = 2;
            this.lbc_Anexos.ValueMember = "ID_ANEXO";
            this.lbc_Anexos.DoubleClick += new System.EventHandler(this.lbc_Anexos_DoubleClick);
            // 
            // bs_Anexos
            // 
            this.bs_Anexos.DataSource = typeof(Entidades.E_ANEXO);
            // 
            // colLOGIN_CAD
            // 
            this.colLOGIN_CAD.Caption = "Cadastrante";
            this.colLOGIN_CAD.FieldName = "LOGIN_CAD";
            this.colLOGIN_CAD.Name = "colLOGIN_CAD";
            this.colLOGIN_CAD.OptionsColumn.AllowEdit = false;
            this.colLOGIN_CAD.OptionsColumn.AllowFocus = false;
            this.colLOGIN_CAD.Visible = true;
            this.colLOGIN_CAD.VisibleIndex = 3;
            this.colLOGIN_CAD.Width = 220;
            // 
            // FConhecimento_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.xtc_Abas);
            this.Name = "FConhecimento_Busca";
            this.Text = "Lançamento - Conhecimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FConhecimento_Busca_FormClosing);
            this.Controls.SetChildIndex(this.xtc_Abas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).EndInit();
            this.xtc_Abas.ResumeLayout(false);
            this.xtp_Conhecimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Conhecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Conhecimento)).EndInit();
            this.xtp_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtc_Abas;
        private DevExpress.XtraTab.XtraTabPage xtp_Conhecimentos;
        private DevExpress.XtraGrid.GridControl gc_Conhecimento;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Conhecimento;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CONHECIMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_TITULO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_LANCTO;
        private DevExpress.XtraTab.XtraTabPage xtp_Anexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_Anexos;
        private System.Windows.Forms.BindingSource bs_Anexos;
        private DevExpress.XtraGrid.Columns.GridColumn colCATEGORIA;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGIN_CAD;

    }
}