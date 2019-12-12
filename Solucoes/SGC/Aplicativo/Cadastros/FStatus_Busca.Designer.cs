namespace Aplicativo.Cadastros
{
    partial class FStatus_Busca
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gc_Status = new DevExpress.XtraGrid.GridControl();
            this.gv_Status = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSIGLA_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_TEMPORIZAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_AUTORIZAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_INICIAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_FINALIZAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_INTERNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_SOLICITANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_REGISTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Status)).BeginInit();
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
            // gc_Status
            // 
            this.gc_Status.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Status.Location = new System.Drawing.Point(0, 50);
            this.gc_Status.MainView = this.gv_Status;
            this.gc_Status.Name = "gc_Status";
            this.gc_Status.Size = new System.Drawing.Size(734, 361);
            this.gc_Status.TabIndex = 5;
            this.gc_Status.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Status});
            // 
            // gv_Status
            // 
            this.gv_Status.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSIGLA_STATUS,
            this.colDS_STATUS,
            this.colST_TEMPORIZAR,
            this.colST_AUTORIZAR,
            this.colST_INICIAR,
            this.colST_FINALIZAR,
            this.colST_INTERNO,
            this.colST_SOLICITANTE,
            this.colST_REGISTRO});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colST_REGISTRO;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "CANCELADO";
            this.gv_Status.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gv_Status.GridControl = this.gc_Status;
            this.gv_Status.Name = "gv_Status";
            this.gv_Status.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Status.OptionsFind.AlwaysVisible = true;
            this.gv_Status.OptionsView.ColumnAutoWidth = false;
            this.gv_Status.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Status.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSIGLA_STATUS, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_Status.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gv_Status_CustomDrawCell);
            // 
            // colSIGLA_STATUS
            // 
            this.colSIGLA_STATUS.Caption = "Sigla";
            this.colSIGLA_STATUS.FieldName = "SIGLA_STATUS";
            this.colSIGLA_STATUS.Name = "colSIGLA_STATUS";
            this.colSIGLA_STATUS.OptionsColumn.AllowEdit = false;
            this.colSIGLA_STATUS.OptionsColumn.AllowFocus = false;
            this.colSIGLA_STATUS.Visible = true;
            this.colSIGLA_STATUS.VisibleIndex = 0;
            // 
            // colDS_STATUS
            // 
            this.colDS_STATUS.Caption = "Descrição";
            this.colDS_STATUS.FieldName = "DS_STATUS";
            this.colDS_STATUS.Name = "colDS_STATUS";
            this.colDS_STATUS.OptionsColumn.AllowEdit = false;
            this.colDS_STATUS.OptionsColumn.AllowFocus = false;
            this.colDS_STATUS.Visible = true;
            this.colDS_STATUS.VisibleIndex = 1;
            // 
            // colST_TEMPORIZAR
            // 
            this.colST_TEMPORIZAR.Caption = "Temporizar";
            this.colST_TEMPORIZAR.FieldName = "ST_TEMPORIZAR";
            this.colST_TEMPORIZAR.Name = "colST_TEMPORIZAR";
            this.colST_TEMPORIZAR.OptionsColumn.AllowEdit = false;
            this.colST_TEMPORIZAR.OptionsColumn.AllowFocus = false;
            this.colST_TEMPORIZAR.Visible = true;
            this.colST_TEMPORIZAR.VisibleIndex = 2;
            // 
            // colST_AUTORIZAR
            // 
            this.colST_AUTORIZAR.Caption = "Autorizar";
            this.colST_AUTORIZAR.FieldName = "ST_AUTORIZAR";
            this.colST_AUTORIZAR.Name = "colST_AUTORIZAR";
            this.colST_AUTORIZAR.OptionsColumn.AllowEdit = false;
            this.colST_AUTORIZAR.OptionsColumn.AllowFocus = false;
            this.colST_AUTORIZAR.Visible = true;
            this.colST_AUTORIZAR.VisibleIndex = 3;
            // 
            // colST_INICIAR
            // 
            this.colST_INICIAR.Caption = "Iniciar";
            this.colST_INICIAR.FieldName = "ST_INICIAR";
            this.colST_INICIAR.Name = "colST_INICIAR";
            this.colST_INICIAR.OptionsColumn.AllowEdit = false;
            this.colST_INICIAR.OptionsColumn.AllowFocus = false;
            this.colST_INICIAR.Visible = true;
            this.colST_INICIAR.VisibleIndex = 4;
            // 
            // colST_FINALIZAR
            // 
            this.colST_FINALIZAR.Caption = "Finalizar";
            this.colST_FINALIZAR.FieldName = "ST_FINALIZAR";
            this.colST_FINALIZAR.Name = "colST_FINALIZAR";
            this.colST_FINALIZAR.OptionsColumn.AllowEdit = false;
            this.colST_FINALIZAR.OptionsColumn.AllowFocus = false;
            this.colST_FINALIZAR.Visible = true;
            this.colST_FINALIZAR.VisibleIndex = 5;
            // 
            // colST_INTERNO
            // 
            this.colST_INTERNO.Caption = "Interno";
            this.colST_INTERNO.FieldName = "ST_INTERNO";
            this.colST_INTERNO.Name = "colST_INTERNO";
            this.colST_INTERNO.OptionsColumn.AllowEdit = false;
            this.colST_INTERNO.OptionsColumn.AllowFocus = false;
            this.colST_INTERNO.Visible = true;
            this.colST_INTERNO.VisibleIndex = 6;
            // 
            // colST_SOLICITANTE
            // 
            this.colST_SOLICITANTE.Caption = "Solicitante";
            this.colST_SOLICITANTE.FieldName = "ST_SOLICITANTE";
            this.colST_SOLICITANTE.Name = "colST_SOLICITANTE";
            this.colST_SOLICITANTE.OptionsColumn.AllowEdit = false;
            this.colST_SOLICITANTE.OptionsColumn.AllowFocus = false;
            this.colST_SOLICITANTE.Visible = true;
            this.colST_SOLICITANTE.VisibleIndex = 7;
            // 
            // colST_REGISTRO
            // 
            this.colST_REGISTRO.Caption = "Status";
            this.colST_REGISTRO.FieldName = "ST_REGISTRO";
            this.colST_REGISTRO.Name = "colST_REGISTRO";
            this.colST_REGISTRO.OptionsColumn.AllowEdit = false;
            this.colST_REGISTRO.OptionsColumn.AllowFocus = false;
            this.colST_REGISTRO.Visible = true;
            this.colST_REGISTRO.VisibleIndex = 8;
            // 
            // FStatus_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Status);
            this.Name = "FStatus_Busca";
            this.Text = "Cadastro - Status";
            this.Controls.SetChildIndex(this.gc_Status, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Status;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Status;
        private DevExpress.XtraGrid.Columns.GridColumn colSIGLA_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colST_TEMPORIZAR;
        private DevExpress.XtraGrid.Columns.GridColumn colST_AUTORIZAR;
        private DevExpress.XtraGrid.Columns.GridColumn colST_INICIAR;
        private DevExpress.XtraGrid.Columns.GridColumn colST_FINALIZAR;
        private DevExpress.XtraGrid.Columns.GridColumn colST_INTERNO;
        private DevExpress.XtraGrid.Columns.GridColumn colST_SOLICITANTE;
        private DevExpress.XtraGrid.Columns.GridColumn colST_REGISTRO;
    }
}
