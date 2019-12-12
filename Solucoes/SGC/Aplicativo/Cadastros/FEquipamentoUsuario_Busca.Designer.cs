namespace Aplicativo.Lancamentos
{
    partial class FEquipamentoUsuario_Busca
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
            this.gc_Equipamento_x_Usuario = new DevExpress.XtraGrid.GridControl();
            this.gv_Equipamento_x_Usuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEQUIPAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_OBSERVACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_USOCOMPARTILHADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_AQUISICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNR_IDENTIFICACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_GRUPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MARCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MODELO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCANCELADOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CANCELAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_ST_REGISTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_REGISTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Equipamento_x_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Equipamento_x_Usuario)).BeginInit();
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
            // gc_Equipamento_x_Usuario
            // 
            this.gc_Equipamento_x_Usuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Equipamento_x_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Equipamento_x_Usuario.Location = new System.Drawing.Point(0, 50);
            this.gc_Equipamento_x_Usuario.MainView = this.gv_Equipamento_x_Usuario;
            this.gc_Equipamento_x_Usuario.Name = "gc_Equipamento_x_Usuario";
            this.gc_Equipamento_x_Usuario.Size = new System.Drawing.Size(734, 361);
            this.gc_Equipamento_x_Usuario.TabIndex = 7;
            this.gc_Equipamento_x_Usuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Equipamento_x_Usuario});
            // 
            // gv_Equipamento_x_Usuario
            // 
            this.gv_Equipamento_x_Usuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEQUIPAMENTO,
            this.colUSUARIO,
            this.colDS_OBSERVACAO,
            this.colST_USOCOMPARTILHADO,
            this.colDT_AQUISICAO,
            this.colNR_IDENTIFICACAO,
            this.colDEPARTAMENTO,
            this.colDS_GRUPO,
            this.colDS_MARCA,
            this.colDS_MODELO,
            this.colCANCELADOR,
            this.colDS_CANCELAMENTO,
            this.colDS_ST_REGISTRO,
            this.colST_REGISTRO});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colST_REGISTRO;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "C";
            this.gv_Equipamento_x_Usuario.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gv_Equipamento_x_Usuario.GridControl = this.gc_Equipamento_x_Usuario;
            this.gv_Equipamento_x_Usuario.Name = "gv_Equipamento_x_Usuario";
            this.gv_Equipamento_x_Usuario.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Equipamento_x_Usuario.OptionsFind.AlwaysVisible = true;
            this.gv_Equipamento_x_Usuario.OptionsView.ColumnAutoWidth = false;
            this.gv_Equipamento_x_Usuario.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Equipamento_x_Usuario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEQUIPAMENTO, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUSUARIO, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colEQUIPAMENTO
            // 
            this.colEQUIPAMENTO.Caption = "Equipamento";
            this.colEQUIPAMENTO.FieldName = "EQUIPAMENTO";
            this.colEQUIPAMENTO.Name = "colEQUIPAMENTO";
            this.colEQUIPAMENTO.OptionsColumn.AllowEdit = false;
            this.colEQUIPAMENTO.OptionsColumn.AllowFocus = false;
            this.colEQUIPAMENTO.Visible = true;
            this.colEQUIPAMENTO.VisibleIndex = 0;
            this.colEQUIPAMENTO.Width = 85;
            // 
            // colUSUARIO
            // 
            this.colUSUARIO.Caption = "Usuário";
            this.colUSUARIO.FieldName = "USUARIO";
            this.colUSUARIO.Name = "colUSUARIO";
            this.colUSUARIO.OptionsColumn.AllowEdit = false;
            this.colUSUARIO.OptionsColumn.AllowFocus = false;
            this.colUSUARIO.Visible = true;
            this.colUSUARIO.VisibleIndex = 1;
            // 
            // colDS_OBSERVACAO
            // 
            this.colDS_OBSERVACAO.Caption = "Observação";
            this.colDS_OBSERVACAO.FieldName = "DS_OBSERVACAO";
            this.colDS_OBSERVACAO.Name = "colDS_OBSERVACAO";
            this.colDS_OBSERVACAO.OptionsColumn.AllowEdit = false;
            this.colDS_OBSERVACAO.OptionsColumn.AllowFocus = false;
            this.colDS_OBSERVACAO.Visible = true;
            this.colDS_OBSERVACAO.VisibleIndex = 3;
            // 
            // colST_USOCOMPARTILHADO
            // 
            this.colST_USOCOMPARTILHADO.Caption = "Uso compartilhado";
            this.colST_USOCOMPARTILHADO.FieldName = "ST_USOCOMPARTILHADO";
            this.colST_USOCOMPARTILHADO.Name = "colST_USOCOMPARTILHADO";
            this.colST_USOCOMPARTILHADO.OptionsColumn.AllowEdit = false;
            this.colST_USOCOMPARTILHADO.OptionsColumn.AllowFocus = false;
            this.colST_USOCOMPARTILHADO.Visible = true;
            this.colST_USOCOMPARTILHADO.VisibleIndex = 4;
            this.colST_USOCOMPARTILHADO.Width = 98;
            // 
            // colDT_AQUISICAO
            // 
            this.colDT_AQUISICAO.Caption = "Aquisição";
            this.colDT_AQUISICAO.FieldName = "DETALHE.DT_AQUISICAO";
            this.colDT_AQUISICAO.Name = "colDT_AQUISICAO";
            this.colDT_AQUISICAO.OptionsColumn.AllowEdit = false;
            this.colDT_AQUISICAO.OptionsColumn.AllowFocus = false;
            this.colDT_AQUISICAO.Visible = true;
            this.colDT_AQUISICAO.VisibleIndex = 5;
            // 
            // colNR_IDENTIFICACAO
            // 
            this.colNR_IDENTIFICACAO.Caption = "Número de identificação";
            this.colNR_IDENTIFICACAO.FieldName = "DETALHE.NR_IDENTIFICACAO";
            this.colNR_IDENTIFICACAO.Name = "colNR_IDENTIFICACAO";
            this.colNR_IDENTIFICACAO.OptionsColumn.AllowEdit = false;
            this.colNR_IDENTIFICACAO.OptionsColumn.AllowFocus = false;
            this.colNR_IDENTIFICACAO.Visible = true;
            this.colNR_IDENTIFICACAO.VisibleIndex = 6;
            this.colNR_IDENTIFICACAO.Width = 125;
            // 
            // colDEPARTAMENTO
            // 
            this.colDEPARTAMENTO.Caption = "Departamento";
            this.colDEPARTAMENTO.FieldName = "DEPARTAMENTO";
            this.colDEPARTAMENTO.Name = "colDEPARTAMENTO";
            this.colDEPARTAMENTO.OptionsColumn.AllowEdit = false;
            this.colDEPARTAMENTO.OptionsColumn.AllowFocus = false;
            this.colDEPARTAMENTO.Visible = true;
            this.colDEPARTAMENTO.VisibleIndex = 2;
            this.colDEPARTAMENTO.Width = 127;
            // 
            // colDS_GRUPO
            // 
            this.colDS_GRUPO.Caption = "Grupo";
            this.colDS_GRUPO.FieldName = "DETALHE.DS_GRUPO";
            this.colDS_GRUPO.Name = "colDS_GRUPO";
            this.colDS_GRUPO.OptionsColumn.AllowEdit = false;
            this.colDS_GRUPO.OptionsColumn.AllowFocus = false;
            this.colDS_GRUPO.Visible = true;
            this.colDS_GRUPO.VisibleIndex = 7;
            // 
            // colDS_MARCA
            // 
            this.colDS_MARCA.Caption = "Marca";
            this.colDS_MARCA.FieldName = "DETALHE.DS_MARCA";
            this.colDS_MARCA.Name = "colDS_MARCA";
            this.colDS_MARCA.OptionsColumn.AllowEdit = false;
            this.colDS_MARCA.OptionsColumn.AllowFocus = false;
            this.colDS_MARCA.Visible = true;
            this.colDS_MARCA.VisibleIndex = 8;
            // 
            // colDS_MODELO
            // 
            this.colDS_MODELO.Caption = "Modelo";
            this.colDS_MODELO.FieldName = "DETALHE.DS_MODELO";
            this.colDS_MODELO.Name = "colDS_MODELO";
            this.colDS_MODELO.OptionsColumn.AllowEdit = false;
            this.colDS_MODELO.OptionsColumn.AllowFocus = false;
            this.colDS_MODELO.Visible = true;
            this.colDS_MODELO.VisibleIndex = 9;
            // 
            // colCANCELADOR
            // 
            this.colCANCELADOR.Caption = "Cancelador";
            this.colCANCELADOR.FieldName = "LOGIN_CANCELAMENTO";
            this.colCANCELADOR.Name = "colCANCELADOR";
            this.colCANCELADOR.OptionsColumn.AllowEdit = false;
            this.colCANCELADOR.OptionsColumn.AllowFocus = false;
            this.colCANCELADOR.Visible = true;
            this.colCANCELADOR.VisibleIndex = 10;
            // 
            // colDS_CANCELAMENTO
            // 
            this.colDS_CANCELAMENTO.Caption = "Descrição do cancelamento";
            this.colDS_CANCELAMENTO.FieldName = "DS_CANCELAMENTO";
            this.colDS_CANCELAMENTO.Name = "colDS_CANCELAMENTO";
            this.colDS_CANCELAMENTO.OptionsColumn.AllowEdit = false;
            this.colDS_CANCELAMENTO.OptionsColumn.AllowFocus = false;
            this.colDS_CANCELAMENTO.Visible = true;
            this.colDS_CANCELAMENTO.VisibleIndex = 11;
            // 
            // colDS_ST_REGISTRO
            // 
            this.colDS_ST_REGISTRO.Caption = "Status";
            this.colDS_ST_REGISTRO.FieldName = "DS_ST_REGISTRO";
            this.colDS_ST_REGISTRO.Name = "colDS_ST_REGISTRO";
            this.colDS_ST_REGISTRO.OptionsColumn.AllowEdit = false;
            this.colDS_ST_REGISTRO.OptionsColumn.AllowFocus = false;
            this.colDS_ST_REGISTRO.Visible = true;
            this.colDS_ST_REGISTRO.VisibleIndex = 12;
            // 
            // colST_REGISTRO
            // 
            this.colST_REGISTRO.Caption = "Status";
            this.colST_REGISTRO.FieldName = "ST_REGISTRO";
            this.colST_REGISTRO.Name = "colST_REGISTRO";
            this.colST_REGISTRO.OptionsColumn.AllowEdit = false;
            this.colST_REGISTRO.OptionsColumn.AllowFocus = false;
            // 
            // FEquipamentoUsuario_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_Equipamento_x_Usuario);
            this.Name = "FEquipamentoUsuario_Busca";
            this.Text = "Lançamento - Equipamento x Usuário";
            this.Controls.SetChildIndex(this.gc_Equipamento_x_Usuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Equipamento_x_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Equipamento_x_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Equipamento_x_Usuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Equipamento_x_Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIPAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colUSUARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_OBSERVACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colST_USOCOMPARTILHADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_AQUISICAO;
        private DevExpress.XtraGrid.Columns.GridColumn colNR_IDENTIFICACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_GRUPO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MARCA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MODELO;
        private DevExpress.XtraGrid.Columns.GridColumn colCANCELADOR;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CANCELAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_ST_REGISTRO;
        private DevExpress.XtraGrid.Columns.GridColumn colST_REGISTRO;
    }
}