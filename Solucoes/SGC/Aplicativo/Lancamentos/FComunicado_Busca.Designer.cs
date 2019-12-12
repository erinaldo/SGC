namespace Aplicativo.Lancamentos
{
    partial class FComunicado_Busca
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colST_REGISTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRUPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtp_Anexos = new DevExpress.XtraTab.XtraTabPage();
            this.lbc_Anexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_Anexos = new System.Windows.Forms.BindingSource(this.components);
            this.xtp_Comunicados = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Comunicado = new DevExpress.XtraGrid.GridControl();
            this.gv_Comunicado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_COMUNICADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_COMUNICADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGIN_COMUNICADOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtc_Abas = new DevExpress.XtraTab.XtraTabControl();
            this.xtp_GruposComunicados = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Grupos = new DevExpress.XtraGrid.GridControl();
            this.gv_Grupos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtp_UsuariosComunicados = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Usuarios = new DevExpress.XtraGrid.GridControl();
            this.gv_Usuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            this.xtp_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).BeginInit();
            this.xtp_Comunicados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Comunicado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Comunicado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).BeginInit();
            this.xtc_Abas.SuspendLayout();
            this.xtp_GruposComunicados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Grupos)).BeginInit();
            this.xtp_UsuariosComunicados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Usuarios)).BeginInit();
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
            // colST_REGISTRO
            // 
            this.colST_REGISTRO.Caption = "Status";
            this.colST_REGISTRO.FieldName = "ST_REGISTRO";
            this.colST_REGISTRO.Name = "colST_REGISTRO";
            this.colST_REGISTRO.OptionsColumn.AllowEdit = false;
            this.colST_REGISTRO.OptionsColumn.AllowFocus = false;
            this.colST_REGISTRO.Visible = true;
            this.colST_REGISTRO.VisibleIndex = 3;
            // 
            // colGRUPO
            // 
            this.colGRUPO.Caption = "Grupo";
            this.colGRUPO.FieldName = "GRUPO";
            this.colGRUPO.Name = "colGRUPO";
            this.colGRUPO.OptionsColumn.AllowEdit = false;
            this.colGRUPO.OptionsColumn.AllowFocus = false;
            this.colGRUPO.Visible = true;
            this.colGRUPO.VisibleIndex = 0;
            this.colGRUPO.Width = 686;
            // 
            // colUSUARIO
            // 
            this.colUSUARIO.Caption = "Usuário";
            this.colUSUARIO.FieldName = "USUARIO";
            this.colUSUARIO.Name = "colUSUARIO";
            this.colUSUARIO.OptionsColumn.AllowEdit = false;
            this.colUSUARIO.OptionsColumn.AllowFocus = false;
            this.colUSUARIO.Visible = true;
            this.colUSUARIO.VisibleIndex = 0;
            this.colUSUARIO.Width = 686;
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
            // xtp_Comunicados
            // 
            this.xtp_Comunicados.Controls.Add(this.gc_Comunicado);
            this.xtp_Comunicados.Name = "xtp_Comunicados";
            this.xtp_Comunicados.Size = new System.Drawing.Size(728, 333);
            this.xtp_Comunicados.Text = "Comunicados";
            // 
            // gc_Comunicado
            // 
            this.gc_Comunicado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Comunicado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Comunicado.Location = new System.Drawing.Point(0, 0);
            this.gc_Comunicado.MainView = this.gv_Comunicado;
            this.gc_Comunicado.Name = "gc_Comunicado";
            this.gc_Comunicado.Size = new System.Drawing.Size(728, 333);
            this.gc_Comunicado.TabIndex = 7;
            this.gc_Comunicado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Comunicado});
            // 
            // gv_Comunicado
            // 
            this.gv_Comunicado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_COMUNICADO,
            this.colDS_COMUNICADO,
            this.colLOGIN_COMUNICADOR,
            this.colST_REGISTRO});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colST_REGISTRO;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "CANCELADO";
            this.gv_Comunicado.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gv_Comunicado.GridControl = this.gc_Comunicado;
            this.gv_Comunicado.Name = "gv_Comunicado";
            this.gv_Comunicado.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Comunicado.OptionsFind.AlwaysVisible = true;
            this.gv_Comunicado.OptionsView.ColumnAutoWidth = false;
            this.gv_Comunicado.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Comunicado.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_COMUNICADO, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gv_Comunicado.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Comunicado_RowClick);
            // 
            // colID_COMUNICADO
            // 
            this.colID_COMUNICADO.Caption = "Identificador";
            this.colID_COMUNICADO.FieldName = "ID_COMUNICADO";
            this.colID_COMUNICADO.Name = "colID_COMUNICADO";
            this.colID_COMUNICADO.OptionsColumn.AllowEdit = false;
            this.colID_COMUNICADO.OptionsColumn.AllowFocus = false;
            this.colID_COMUNICADO.Visible = true;
            this.colID_COMUNICADO.VisibleIndex = 0;
            this.colID_COMUNICADO.Width = 86;
            // 
            // colDS_COMUNICADO
            // 
            this.colDS_COMUNICADO.Caption = "Descrição";
            this.colDS_COMUNICADO.FieldName = "DS_COMUNICADO";
            this.colDS_COMUNICADO.Name = "colDS_COMUNICADO";
            this.colDS_COMUNICADO.OptionsColumn.AllowEdit = false;
            this.colDS_COMUNICADO.OptionsColumn.AllowFocus = false;
            this.colDS_COMUNICADO.Visible = true;
            this.colDS_COMUNICADO.VisibleIndex = 1;
            // 
            // colLOGIN_COMUNICADOR
            // 
            this.colLOGIN_COMUNICADOR.Caption = "Comunicador";
            this.colLOGIN_COMUNICADOR.FieldName = "LOGIN_COMUNICADOR";
            this.colLOGIN_COMUNICADOR.Name = "colLOGIN_COMUNICADOR";
            this.colLOGIN_COMUNICADOR.OptionsColumn.AllowEdit = false;
            this.colLOGIN_COMUNICADOR.OptionsColumn.AllowFocus = false;
            this.colLOGIN_COMUNICADOR.Visible = true;
            this.colLOGIN_COMUNICADOR.VisibleIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // xtc_Abas
            // 
            this.xtc_Abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtc_Abas.Location = new System.Drawing.Point(0, 50);
            this.xtc_Abas.Name = "xtc_Abas";
            this.xtc_Abas.SelectedTabPage = this.xtp_Comunicados;
            this.xtc_Abas.Size = new System.Drawing.Size(734, 361);
            this.xtc_Abas.TabIndex = 8;
            this.xtc_Abas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtp_Comunicados,
            this.xtp_GruposComunicados,
            this.xtp_UsuariosComunicados,
            this.xtp_Anexos});
            // 
            // xtp_GruposComunicados
            // 
            this.xtp_GruposComunicados.Controls.Add(this.gc_Grupos);
            this.xtp_GruposComunicados.Name = "xtp_GruposComunicados";
            this.xtp_GruposComunicados.PageVisible = false;
            this.xtp_GruposComunicados.Size = new System.Drawing.Size(728, 333);
            this.xtp_GruposComunicados.Text = "Grupos comunicados";
            // 
            // gc_Grupos
            // 
            this.gc_Grupos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Grupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Grupos.Location = new System.Drawing.Point(0, 0);
            this.gc_Grupos.MainView = this.gv_Grupos;
            this.gc_Grupos.Name = "gc_Grupos";
            this.gc_Grupos.Size = new System.Drawing.Size(728, 333);
            this.gc_Grupos.TabIndex = 8;
            this.gc_Grupos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Grupos});
            // 
            // gv_Grupos
            // 
            this.gv_Grupos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGRUPO});
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colGRUPO;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "CANCELADO";
            this.gv_Grupos.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gv_Grupos.GridControl = this.gc_Grupos;
            this.gv_Grupos.Name = "gv_Grupos";
            this.gv_Grupos.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Grupos.OptionsView.ColumnAutoWidth = false;
            this.gv_Grupos.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Grupos.OptionsView.ShowGroupPanel = false;
            // 
            // xtp_UsuariosComunicados
            // 
            this.xtp_UsuariosComunicados.Controls.Add(this.gc_Usuarios);
            this.xtp_UsuariosComunicados.Name = "xtp_UsuariosComunicados";
            this.xtp_UsuariosComunicados.PageVisible = false;
            this.xtp_UsuariosComunicados.Size = new System.Drawing.Size(728, 333);
            this.xtp_UsuariosComunicados.Text = "Usuários comunicados";
            // 
            // gc_Usuarios
            // 
            this.gc_Usuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Usuarios.Location = new System.Drawing.Point(0, 0);
            this.gc_Usuarios.MainView = this.gv_Usuarios;
            this.gc_Usuarios.Name = "gc_Usuarios";
            this.gc_Usuarios.Size = new System.Drawing.Size(728, 333);
            this.gc_Usuarios.TabIndex = 9;
            this.gc_Usuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Usuarios});
            // 
            // gv_Usuarios
            // 
            this.gv_Usuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSUARIO});
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colUSUARIO;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "CANCELADO";
            this.gv_Usuarios.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.gv_Usuarios.GridControl = this.gc_Usuarios;
            this.gv_Usuarios.Name = "gv_Usuarios";
            this.gv_Usuarios.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Usuarios.OptionsView.ColumnAutoWidth = false;
            this.gv_Usuarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Usuarios.OptionsView.ShowGroupPanel = false;
            // 
            // FComunicado_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.xtc_Abas);
            this.Name = "FComunicado_Busca";
            this.Text = "Lançamento - Comunicado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FComunicado_Busca_FormClosing);
            this.Controls.SetChildIndex(this.xtc_Abas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            this.xtp_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).EndInit();
            this.xtp_Comunicados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Comunicado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Comunicado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).EndInit();
            this.xtc_Abas.ResumeLayout(false);
            this.xtp_GruposComunicados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Grupos)).EndInit();
            this.xtp_UsuariosComunicados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtp_Anexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_Anexos;
        private DevExpress.XtraTab.XtraTabPage xtp_Comunicados;
        private DevExpress.XtraGrid.GridControl gc_Comunicado;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Comunicado;
        private DevExpress.XtraGrid.Columns.GridColumn colID_COMUNICADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_COMUNICADO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGIN_COMUNICADOR;
        private DevExpress.XtraGrid.Columns.GridColumn colST_REGISTRO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtc_Abas;
        private System.Windows.Forms.BindingSource bs_Anexos;
        private DevExpress.XtraTab.XtraTabPage xtp_GruposComunicados;
        private DevExpress.XtraGrid.GridControl gc_Grupos;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Grupos;
        private DevExpress.XtraGrid.Columns.GridColumn colGRUPO;
        private DevExpress.XtraTab.XtraTabPage xtp_UsuariosComunicados;
        private DevExpress.XtraGrid.GridControl gc_Usuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Usuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colUSUARIO;

    }
}