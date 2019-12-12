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
            this.gc_Equipamento_x_Usuario = new DevExpress.XtraGrid.GridControl();
            this.gv_Equipamento_x_Usuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEQUIPAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_OBSERVACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_ATIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_USOCOMPARTILHADO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            // cddb_Buscar
            // 
            this.cddb_Buscar.Appearance.Options.UseTextOptions = true;
            this.cddb_Buscar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            // 
            // gc_Equipamento_x_Usuario
            // 
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
            this.colST_ATIVO,
            this.colST_USOCOMPARTILHADO});
            this.gv_Equipamento_x_Usuario.GridControl = this.gc_Equipamento_x_Usuario;
            this.gv_Equipamento_x_Usuario.Name = "gv_Equipamento_x_Usuario";
            this.gv_Equipamento_x_Usuario.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Equipamento_x_Usuario.OptionsFind.AlwaysVisible = true;
            this.gv_Equipamento_x_Usuario.OptionsView.ColumnAutoWidth = false;
            this.gv_Equipamento_x_Usuario.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Equipamento_x_Usuario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEQUIPAMENTO, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUSUARIO, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_Equipamento_x_Usuario.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gv_Equipamento_x_Usuario_CustomDrawCell);
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
            this.colEQUIPAMENTO.Width = 84;
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
            this.colDS_OBSERVACAO.VisibleIndex = 2;
            // 
            // colST_ATIVO
            // 
            this.colST_ATIVO.Caption = "Ativo";
            this.colST_ATIVO.Name = "colST_ATIVO";
            this.colST_ATIVO.OptionsColumn.AllowEdit = false;
            this.colST_ATIVO.OptionsColumn.AllowFocus = false;
            // 
            // colST_USOCOMPARTILHADO
            // 
            this.colST_USOCOMPARTILHADO.Caption = "Uso compartilhado";
            this.colST_USOCOMPARTILHADO.FieldName = "ST_USOCOMPARTILHADO";
            this.colST_USOCOMPARTILHADO.Name = "colST_USOCOMPARTILHADO";
            this.colST_USOCOMPARTILHADO.OptionsColumn.AllowEdit = false;
            this.colST_USOCOMPARTILHADO.OptionsColumn.AllowFocus = false;
            this.colST_USOCOMPARTILHADO.Visible = true;
            this.colST_USOCOMPARTILHADO.VisibleIndex = 3;
            this.colST_USOCOMPARTILHADO.Width = 97;
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
        private DevExpress.XtraGrid.Columns.GridColumn colST_ATIVO;
        private DevExpress.XtraGrid.Columns.GridColumn colST_USOCOMPARTILHADO;
    }
}