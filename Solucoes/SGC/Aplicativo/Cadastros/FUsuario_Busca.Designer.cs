namespace Aplicativo.Cadastros
{
    partial class FUsuario_Busca
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
            this.colST_REGISTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cpc_Componentes = new Componentes.CPanelControl(this.components);
            this.gc_Usuario = new DevExpress.XtraGrid.GridControl();
            this.gv_Usuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLOGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_CARGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_CLIFOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DEPARTAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_USUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNR_CELULAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNR_TELEFONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CARGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CLIFOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DEPARTAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Componentes)).BeginInit();
            this.cpc_Componentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Usuario)).BeginInit();
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
            // 
            // cpc_Componentes
            // 
            this.cpc_Componentes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Componentes.Controls.Add(this.gc_Usuario);
            this.cpc_Componentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_Componentes.Location = new System.Drawing.Point(0, 50);
            this.cpc_Componentes.Name = "cpc_Componentes";
            this.cpc_Componentes.Size = new System.Drawing.Size(734, 361);
            this.cpc_Componentes.TabIndex = 1;
            // 
            // gc_Usuario
            // 
            this.gc_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Usuario.Location = new System.Drawing.Point(0, 0);
            this.gc_Usuario.MainView = this.gv_Usuario;
            this.gc_Usuario.Name = "gc_Usuario";
            this.gc_Usuario.Size = new System.Drawing.Size(734, 361);
            this.gc_Usuario.TabIndex = 2;
            this.gc_Usuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Usuario});
            // 
            // gv_Usuario
            // 
            this.gv_Usuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLOGIN,
            this.colID_CARGO,
            this.colID_CLIFOR,
            this.colID_DEPARTAMENTO,
            this.colNM_USUARIO,
            this.colNR_CELULAR,
            this.colNR_TELEFONE,
            this.colEMAIL,
            this.colSKYPE,
            this.colST_REGISTRO,
            this.colDS_CARGO,
            this.colNM_CLIFOR,
            this.colDS_DEPARTAMENTO});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.colST_REGISTRO;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "C";
            this.gv_Usuario.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gv_Usuario.GridControl = this.gc_Usuario;
            this.gv_Usuario.Name = "gv_Usuario";
            this.gv_Usuario.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Usuario.OptionsFind.AlwaysVisible = true;
            this.gv_Usuario.OptionsView.ColumnAutoWidth = false;
            this.gv_Usuario.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Usuario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLOGIN, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colLOGIN
            // 
            this.colLOGIN.Caption = "Login";
            this.colLOGIN.FieldName = "LOGIN";
            this.colLOGIN.Name = "colLOGIN";
            this.colLOGIN.OptionsColumn.AllowEdit = false;
            this.colLOGIN.OptionsColumn.AllowFocus = false;
            this.colLOGIN.Visible = true;
            this.colLOGIN.VisibleIndex = 0;
            // 
            // colID_CARGO
            // 
            this.colID_CARGO.Caption = "Id. Cargo";
            this.colID_CARGO.FieldName = "CARGO.ID_CARGO";
            this.colID_CARGO.Name = "colID_CARGO";
            this.colID_CARGO.OptionsColumn.AllowEdit = false;
            this.colID_CARGO.OptionsColumn.AllowFocus = false;
            this.colID_CARGO.Visible = true;
            this.colID_CARGO.VisibleIndex = 8;
            // 
            // colID_CLIFOR
            // 
            this.colID_CLIFOR.Caption = "Id. Cliente / Fornecedor";
            this.colID_CLIFOR.FieldName = "CLIFOR.ID_CLIFOR";
            this.colID_CLIFOR.Name = "colID_CLIFOR";
            this.colID_CLIFOR.OptionsColumn.AllowEdit = false;
            this.colID_CLIFOR.OptionsColumn.AllowFocus = false;
            this.colID_CLIFOR.Visible = true;
            this.colID_CLIFOR.VisibleIndex = 6;
            this.colID_CLIFOR.Width = 127;
            // 
            // colID_DEPARTAMENTO
            // 
            this.colID_DEPARTAMENTO.Caption = "Id. Departamento";
            this.colID_DEPARTAMENTO.FieldName = "DEPARTAMENTO.ID_DEPARTAMENTO";
            this.colID_DEPARTAMENTO.Name = "colID_DEPARTAMENTO";
            this.colID_DEPARTAMENTO.OptionsColumn.AllowEdit = false;
            this.colID_DEPARTAMENTO.OptionsColumn.AllowFocus = false;
            this.colID_DEPARTAMENTO.Visible = true;
            this.colID_DEPARTAMENTO.VisibleIndex = 10;
            this.colID_DEPARTAMENTO.Width = 98;
            // 
            // colNM_USUARIO
            // 
            this.colNM_USUARIO.Caption = "Nome";
            this.colNM_USUARIO.FieldName = "NM_USUARIO";
            this.colNM_USUARIO.Name = "colNM_USUARIO";
            this.colNM_USUARIO.OptionsColumn.AllowEdit = false;
            this.colNM_USUARIO.OptionsColumn.AllowFocus = false;
            this.colNM_USUARIO.Visible = true;
            this.colNM_USUARIO.VisibleIndex = 1;
            // 
            // colNR_CELULAR
            // 
            this.colNR_CELULAR.Caption = "Celular";
            this.colNR_CELULAR.FieldName = "NR_CELULAR";
            this.colNR_CELULAR.Name = "colNR_CELULAR";
            this.colNR_CELULAR.OptionsColumn.AllowEdit = false;
            this.colNR_CELULAR.OptionsColumn.AllowFocus = false;
            this.colNR_CELULAR.Visible = true;
            this.colNR_CELULAR.VisibleIndex = 3;
            // 
            // colNR_TELEFONE
            // 
            this.colNR_TELEFONE.Caption = "Telefone";
            this.colNR_TELEFONE.FieldName = "NR_TELEFONE";
            this.colNR_TELEFONE.Name = "colNR_TELEFONE";
            this.colNR_TELEFONE.OptionsColumn.AllowEdit = false;
            this.colNR_TELEFONE.OptionsColumn.AllowFocus = false;
            this.colNR_TELEFONE.Visible = true;
            this.colNR_TELEFONE.VisibleIndex = 2;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "E-mail";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            this.colEMAIL.OptionsColumn.AllowFocus = false;
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 4;
            // 
            // colSKYPE
            // 
            this.colSKYPE.Caption = "Skype";
            this.colSKYPE.FieldName = "SKYPE";
            this.colSKYPE.Name = "colSKYPE";
            this.colSKYPE.OptionsColumn.AllowEdit = false;
            this.colSKYPE.OptionsColumn.AllowFocus = false;
            this.colSKYPE.Visible = true;
            this.colSKYPE.VisibleIndex = 5;
            // 
            // colDS_CARGO
            // 
            this.colDS_CARGO.Caption = "Ds. Cargo";
            this.colDS_CARGO.FieldName = "CARGO.DS_CARGO";
            this.colDS_CARGO.Name = "colDS_CARGO";
            this.colDS_CARGO.OptionsColumn.AllowEdit = false;
            this.colDS_CARGO.OptionsColumn.AllowFocus = false;
            this.colDS_CARGO.Visible = true;
            this.colDS_CARGO.VisibleIndex = 9;
            // 
            // colNM_CLIFOR
            // 
            this.colNM_CLIFOR.Caption = "Nm. Cliente / Fornecedor";
            this.colNM_CLIFOR.FieldName = "CLIFOR.NM_CLIFOR";
            this.colNM_CLIFOR.Name = "colNM_CLIFOR";
            this.colNM_CLIFOR.OptionsColumn.AllowEdit = false;
            this.colNM_CLIFOR.OptionsColumn.AllowFocus = false;
            this.colNM_CLIFOR.Visible = true;
            this.colNM_CLIFOR.VisibleIndex = 7;
            this.colNM_CLIFOR.Width = 132;
            // 
            // colDS_DEPARTAMENTO
            // 
            this.colDS_DEPARTAMENTO.Caption = "Ds. Departamento";
            this.colDS_DEPARTAMENTO.FieldName = "DEPARTAMENTO.DS_DEPARTAMENTO";
            this.colDS_DEPARTAMENTO.Name = "colDS_DEPARTAMENTO";
            this.colDS_DEPARTAMENTO.OptionsColumn.AllowEdit = false;
            this.colDS_DEPARTAMENTO.OptionsColumn.AllowFocus = false;
            this.colDS_DEPARTAMENTO.Visible = true;
            this.colDS_DEPARTAMENTO.VisibleIndex = 11;
            this.colDS_DEPARTAMENTO.Width = 100;
            // 
            // FUsuario_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cpc_Componentes);
            this.Name = "FUsuario_Busca";
            this.Text = "Cadastro - Usuário";
            this.Controls.SetChildIndex(this.cpc_Componentes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Componentes)).EndInit();
            this.cpc_Componentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_Componentes;
        private DevExpress.XtraGrid.GridControl gc_Usuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CARGO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CLIFOR;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DEPARTAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_USUARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNR_CELULAR;
        private DevExpress.XtraGrid.Columns.GridColumn colNR_TELEFONE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colSKYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colST_REGISTRO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CARGO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CLIFOR;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DEPARTAMENTO;
    }
}
