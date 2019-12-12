namespace Aplicativo.Cadastros
{
    partial class FSalvaSenha_Busca
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
            this.gc_SalvaSenha = new DevExpress.XtraGrid.GridControl();
            this.gv_SalvaSenha = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_SALVASENHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_OBSERVACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SalvaSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SalvaSenha)).BeginInit();
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
            // gc_SalvaSenha
            // 
            this.gc_SalvaSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SalvaSenha.Location = new System.Drawing.Point(0, 50);
            this.gc_SalvaSenha.MainView = this.gv_SalvaSenha;
            this.gc_SalvaSenha.Name = "gc_SalvaSenha";
            this.gc_SalvaSenha.Size = new System.Drawing.Size(734, 361);
            this.gc_SalvaSenha.TabIndex = 7;
            this.gc_SalvaSenha.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SalvaSenha});
            // 
            // gv_SalvaSenha
            // 
            this.gv_SalvaSenha.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_SALVASENHA,
            this.colDS_OBSERVACAO});
            this.gv_SalvaSenha.GridControl = this.gc_SalvaSenha;
            this.gv_SalvaSenha.Name = "gv_SalvaSenha";
            this.gv_SalvaSenha.OptionsDetail.EnableMasterViewMode = false;
            this.gv_SalvaSenha.OptionsFind.AlwaysVisible = true;
            this.gv_SalvaSenha.OptionsView.ColumnAutoWidth = false;
            this.gv_SalvaSenha.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_SALVASENHA, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_SALVASENHA
            // 
            this.colID_SALVASENHA.Caption = "Identificador";
            this.colID_SALVASENHA.FieldName = "ID_SALVASENHA";
            this.colID_SALVASENHA.Name = "colID_SALVASENHA";
            this.colID_SALVASENHA.OptionsColumn.AllowEdit = false;
            this.colID_SALVASENHA.OptionsColumn.AllowFocus = false;
            this.colID_SALVASENHA.Visible = true;
            this.colID_SALVASENHA.VisibleIndex = 0;
            this.colID_SALVASENHA.Width = 83;
            // 
            // colDS_OBSERVACAO
            // 
            this.colDS_OBSERVACAO.Caption = "Descrição";
            this.colDS_OBSERVACAO.FieldName = "DS_OBSERVACAO";
            this.colDS_OBSERVACAO.Name = "colDS_OBSERVACAO";
            this.colDS_OBSERVACAO.OptionsColumn.AllowEdit = false;
            this.colDS_OBSERVACAO.OptionsColumn.AllowFocus = false;
            this.colDS_OBSERVACAO.Visible = true;
            this.colDS_OBSERVACAO.VisibleIndex = 1;
            // 
            // FSalvaSenha_Busca
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_SalvaSenha);
            this.Name = "FSalvaSenha_Busca";
            this.Text = "Consulta - Salva Senha";
            this.Controls.SetChildIndex(this.gc_SalvaSenha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SalvaSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SalvaSenha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_SalvaSenha;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SalvaSenha;
        private DevExpress.XtraGrid.Columns.GridColumn colID_SALVASENHA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_OBSERVACAO;
    }
}