namespace Aplicativo.Cadastros
{
    partial class FEquipamento_Busca
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
            this.gc_Equipamento = new DevExpress.XtraGrid.GridControl();
            this.gv_Equipamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_EQUIPAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_OBSERVACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_AQUISICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNR_IDENTIFICACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRUPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_ATIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Equipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Equipamento)).BeginInit();
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
            // gc_Equipamento
            // 
            this.gc_Equipamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Equipamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Equipamento.Location = new System.Drawing.Point(0, 50);
            this.gc_Equipamento.MainView = this.gv_Equipamento;
            this.gc_Equipamento.Name = "gc_Equipamento";
            this.gc_Equipamento.Size = new System.Drawing.Size(734, 361);
            this.gc_Equipamento.TabIndex = 6;
            this.gc_Equipamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Equipamento});
            // 
            // gv_Equipamento
            // 
            this.gv_Equipamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_EQUIPAMENTO,
            this.colDS_OBSERVACAO,
            this.colDT_AQUISICAO,
            this.colNR_IDENTIFICACAO,
            this.colGRUPO,
            this.colST_ATIVO,
            this.colModelo});
            this.gv_Equipamento.GridControl = this.gc_Equipamento;
            this.gv_Equipamento.Name = "gv_Equipamento";
            this.gv_Equipamento.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Equipamento.OptionsFind.AlwaysVisible = true;
            this.gv_Equipamento.OptionsView.ColumnAutoWidth = false;
            this.gv_Equipamento.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Equipamento.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_EQUIPAMENTO, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_EQUIPAMENTO
            // 
            this.colID_EQUIPAMENTO.Caption = "Identificador";
            this.colID_EQUIPAMENTO.FieldName = "ID_EQUIPAMENTO";
            this.colID_EQUIPAMENTO.Name = "colID_EQUIPAMENTO";
            this.colID_EQUIPAMENTO.OptionsColumn.AllowEdit = false;
            this.colID_EQUIPAMENTO.OptionsColumn.AllowFocus = false;
            this.colID_EQUIPAMENTO.Visible = true;
            this.colID_EQUIPAMENTO.VisibleIndex = 0;
            this.colID_EQUIPAMENTO.Width = 86;
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
            // colDT_AQUISICAO
            // 
            this.colDT_AQUISICAO.Caption = "Aquisição";
            this.colDT_AQUISICAO.DisplayFormat.FormatString = "d";
            this.colDT_AQUISICAO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_AQUISICAO.FieldName = "DT_AQUISICAO";
            this.colDT_AQUISICAO.GroupFormat.FormatString = "d";
            this.colDT_AQUISICAO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_AQUISICAO.Name = "colDT_AQUISICAO";
            this.colDT_AQUISICAO.OptionsColumn.AllowEdit = false;
            this.colDT_AQUISICAO.OptionsColumn.AllowFocus = false;
            this.colDT_AQUISICAO.Visible = true;
            this.colDT_AQUISICAO.VisibleIndex = 2;
            // 
            // colNR_IDENTIFICACAO
            // 
            this.colNR_IDENTIFICACAO.Caption = "Número de identificação";
            this.colNR_IDENTIFICACAO.FieldName = "NR_IDENTIFICACAO";
            this.colNR_IDENTIFICACAO.Name = "colNR_IDENTIFICACAO";
            this.colNR_IDENTIFICACAO.OptionsColumn.AllowEdit = false;
            this.colNR_IDENTIFICACAO.OptionsColumn.AllowFocus = false;
            this.colNR_IDENTIFICACAO.Visible = true;
            this.colNR_IDENTIFICACAO.VisibleIndex = 3;
            this.colNR_IDENTIFICACAO.Width = 125;
            // 
            // colGRUPO
            // 
            this.colGRUPO.Caption = "Grupo";
            this.colGRUPO.FieldName = "DS_GRUPO";
            this.colGRUPO.Name = "colGRUPO";
            this.colGRUPO.OptionsColumn.AllowEdit = false;
            this.colGRUPO.OptionsColumn.AllowFocus = false;
            this.colGRUPO.Visible = true;
            this.colGRUPO.VisibleIndex = 4;
            // 
            // colST_ATIVO
            // 
            this.colST_ATIVO.Caption = "Ativo";
            this.colST_ATIVO.FieldName = "ST_ATIVO";
            this.colST_ATIVO.Name = "colST_ATIVO";
            this.colST_ATIVO.OptionsColumn.AllowEdit = false;
            this.colST_ATIVO.OptionsColumn.AllowFocus = false;
            this.colST_ATIVO.Visible = true;
            this.colST_ATIVO.VisibleIndex = 6;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.FieldName = "DS_MODELO";
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.AllowFocus = false;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 5;
            // 
            // FEquipamento_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Equipamento);
            this.Name = "FEquipamento_Busca";
            this.Text = "Cadastro - Equipamento";
            this.Controls.SetChildIndex(this.gc_Equipamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Equipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Equipamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Equipamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Equipamento;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EQUIPAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_OBSERVACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_AQUISICAO;
        private DevExpress.XtraGrid.Columns.GridColumn colNR_IDENTIFICACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colGRUPO;
        private DevExpress.XtraGrid.Columns.GridColumn colST_ATIVO;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
    }
}