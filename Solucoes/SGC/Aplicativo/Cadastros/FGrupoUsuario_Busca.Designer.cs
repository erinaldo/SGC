namespace Aplicativo.Cadastros
{
    partial class FGrupoUsuario_Busca
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
            this.gc_GrupoUsuario = new DevExpress.XtraGrid.GridControl();
            this.gv_GrupoUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_GrupoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_GRUPOUSUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GrupoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GrupoUsuario)).BeginInit();
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
            // gc_GrupoUsuario
            // 
            this.gc_GrupoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GrupoUsuario.Location = new System.Drawing.Point(0, 50);
            this.gc_GrupoUsuario.MainView = this.gv_GrupoUsuario;
            this.gc_GrupoUsuario.Name = "gc_GrupoUsuario";
            this.gc_GrupoUsuario.Size = new System.Drawing.Size(734, 361);
            this.gc_GrupoUsuario.TabIndex = 5;
            this.gc_GrupoUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GrupoUsuario});
            // 
            // gv_GrupoUsuario
            // 
            this.gv_GrupoUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_GrupoUsuario,
            this.colDS_GRUPOUSUARIO});
            this.gv_GrupoUsuario.GridControl = this.gc_GrupoUsuario;
            this.gv_GrupoUsuario.Name = "gv_GrupoUsuario";
            this.gv_GrupoUsuario.OptionsDetail.EnableMasterViewMode = false;
            this.gv_GrupoUsuario.OptionsFind.AlwaysVisible = true;
            this.gv_GrupoUsuario.OptionsView.ColumnAutoWidth = false;
            this.gv_GrupoUsuario.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_GrupoUsuario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_GrupoUsuario, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID_GrupoUsuario
            // 
            this.colID_GrupoUsuario.Caption = "Identificador";
            this.colID_GrupoUsuario.FieldName = "ID_GRUPOUSUARIO";
            this.colID_GrupoUsuario.Name = "colID_GrupoUsuario";
            this.colID_GrupoUsuario.OptionsColumn.AllowEdit = false;
            this.colID_GrupoUsuario.OptionsColumn.AllowFocus = false;
            this.colID_GrupoUsuario.Visible = true;
            this.colID_GrupoUsuario.VisibleIndex = 0;
            this.colID_GrupoUsuario.Width = 86;
            // 
            // colDS_GRUPOUSUARIO
            // 
            this.colDS_GRUPOUSUARIO.Caption = "Descrição";
            this.colDS_GRUPOUSUARIO.FieldName = "DS_GRUPO";
            this.colDS_GRUPOUSUARIO.Name = "colDS_GRUPOUSUARIO";
            this.colDS_GRUPOUSUARIO.OptionsColumn.AllowEdit = false;
            this.colDS_GRUPOUSUARIO.OptionsColumn.AllowFocus = false;
            this.colDS_GRUPOUSUARIO.Visible = true;
            this.colDS_GRUPOUSUARIO.VisibleIndex = 1;
            // 
            // FGrupoUsuario_Busca
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gc_GrupoUsuario);
            this.Name = "FGrupoUsuario_Busca";
            this.Text = "Cadastro - Grupo Usuário";
            this.Controls.SetChildIndex(this.gc_GrupoUsuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GrupoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GrupoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GrupoUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GrupoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colID_GrupoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_GRUPOUSUARIO;
    }
}
