namespace Formas.Padrao
{
    partial class FPadrao_Busca_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPadrao_Busca_Menu));
            this.cpc_Menu = new Componentes.Menu.Painel_x32();
            this.csb_Sair = new Componentes.Menu.Cancelar_x32();
            this.csb_Relatorio = new Componentes.Menu.Relatorio_x32();
            this.pm_Menu = new DevExpress.XtraBars.PopupMenu();
            this.bbi_Buscar_200 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Buscar_1000 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Buscar_Todos = new DevExpress.XtraBars.BarButtonItem();
            this.bm_Menu = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.csb_Deletar = new Componentes.Menu.Deletar_x32();
            this.csb_Alterar = new Componentes.Menu.Alterar_x32();
            this.csb_Adicionar = new Componentes.Menu.Adicionar_x32();
            this.csb_Buscar = new Componentes.Menu.Buscar_x32();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Menu)).BeginInit();
            this.cpc_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pm_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_Menu
            // 
            this.cpc_Menu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_Menu.Appearance.Options.UseBackColor = true;
            this.cpc_Menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cpc_Menu.Controls.Add(this.csb_Buscar);
            this.cpc_Menu.Controls.Add(this.csb_Sair);
            this.cpc_Menu.Controls.Add(this.csb_Relatorio);
            this.cpc_Menu.Controls.Add(this.csb_Deletar);
            this.cpc_Menu.Controls.Add(this.csb_Alterar);
            this.cpc_Menu.Controls.Add(this.csb_Adicionar);
            this.cpc_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpc_Menu.Location = new System.Drawing.Point(0, 0);
            this.cpc_Menu.Name = "cpc_Menu";
            this.cpc_Menu.Size = new System.Drawing.Size(734, 50);
            this.cpc_Menu.TabIndex = 0;
            // 
            // csb_Sair
            // 
            this.csb_Sair.AllowFocus = false;
            this.csb_Sair.Appearance.Options.UseTextOptions = true;
            this.csb_Sair.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Sair.Image = ((System.Drawing.Image)(resources.GetObject("csb_Sair.Image")));
            this.csb_Sair.Location = new System.Drawing.Point(440, 5);
            this.csb_Sair.Name = "csb_Sair";
            this.csb_Sair.Size = new System.Drawing.Size(70, 40);
            this.csb_Sair.TabIndex = 5;
            this.csb_Sair.Text = "(ESC)\nSair";
            this.csb_Sair.Click += new System.EventHandler(this.csb_Sair_Click);
            // 
            // csb_Relatorio
            // 
            this.csb_Relatorio.AllowFocus = false;
            this.csb_Relatorio.Appearance.Options.UseTextOptions = true;
            this.csb_Relatorio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Relatorio.Image = ((System.Drawing.Image)(resources.GetObject("csb_Relatorio.Image")));
            this.csb_Relatorio.Location = new System.Drawing.Point(348, 5);
            this.csb_Relatorio.Name = "csb_Relatorio";
            this.csb_Relatorio.Size = new System.Drawing.Size(88, 40);
            this.csb_Relatorio.TabIndex = 4;
            this.csb_Relatorio.Text = "(F7)\nRelatório";
            this.csb_Relatorio.Click += new System.EventHandler(this.csb_Relatorio_Click);
            // 
            // pm_Menu
            // 
            this.pm_Menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_200),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_1000),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_Todos)});
            this.pm_Menu.Manager = this.bm_Menu;
            this.pm_Menu.Name = "pm_Menu";
            // 
            // bbi_Buscar_200
            // 
            this.bbi_Buscar_200.Caption = "Buscar até 200 registros";
            this.bbi_Buscar_200.Id = 0;
            this.bbi_Buscar_200.Name = "bbi_Buscar_200";
            // 
            // bbi_Buscar_1000
            // 
            this.bbi_Buscar_1000.Caption = "Buscar até 1000 registros";
            this.bbi_Buscar_1000.Id = 1;
            this.bbi_Buscar_1000.Name = "bbi_Buscar_1000";
            // 
            // bbi_Buscar_Todos
            // 
            this.bbi_Buscar_Todos.Caption = "Buscar todos os registros";
            this.bbi_Buscar_Todos.Id = 2;
            this.bbi_Buscar_Todos.Name = "bbi_Buscar_Todos";
            // 
            // bm_Menu
            // 
            this.bm_Menu.DockControls.Add(this.barDockControlTop);
            this.bm_Menu.DockControls.Add(this.barDockControlBottom);
            this.bm_Menu.DockControls.Add(this.barDockControlLeft);
            this.bm_Menu.DockControls.Add(this.barDockControlRight);
            this.bm_Menu.Form = this;
            this.bm_Menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_Buscar_200,
            this.bbi_Buscar_1000,
            this.bbi_Buscar_Todos});
            this.bm_Menu.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(734, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 411);
            this.barDockControlBottom.Size = new System.Drawing.Size(734, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 411);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(734, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 411);
            // 
            // csb_Deletar
            // 
            this.csb_Deletar.AllowFocus = false;
            this.csb_Deletar.Appearance.Options.UseTextOptions = true;
            this.csb_Deletar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Deletar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Deletar.Image")));
            this.csb_Deletar.Location = new System.Drawing.Point(180, 5);
            this.csb_Deletar.Name = "csb_Deletar";
            this.csb_Deletar.Size = new System.Drawing.Size(81, 40);
            this.csb_Deletar.TabIndex = 2;
            this.csb_Deletar.Text = "(F4)\nDeletar";
            this.csb_Deletar.Click += new System.EventHandler(this.csb_Deletar_Click);
            // 
            // csb_Alterar
            // 
            this.csb_Alterar.AllowFocus = false;
            this.csb_Alterar.Appearance.Options.UseTextOptions = true;
            this.csb_Alterar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Alterar.Image")));
            this.csb_Alterar.Location = new System.Drawing.Point(97, 5);
            this.csb_Alterar.Name = "csb_Alterar";
            this.csb_Alterar.Size = new System.Drawing.Size(79, 40);
            this.csb_Alterar.TabIndex = 1;
            this.csb_Alterar.Text = "(F3)\nAlterar";
            this.csb_Alterar.Click += new System.EventHandler(this.csb_Alterar_Click);
            // 
            // csb_Adicionar
            // 
            this.csb_Adicionar.AllowFocus = false;
            this.csb_Adicionar.Appearance.Options.UseTextOptions = true;
            this.csb_Adicionar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Adicionar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Adicionar.Image")));
            this.csb_Adicionar.Location = new System.Drawing.Point(5, 5);
            this.csb_Adicionar.Name = "csb_Adicionar";
            this.csb_Adicionar.Size = new System.Drawing.Size(88, 40);
            this.csb_Adicionar.TabIndex = 0;
            this.csb_Adicionar.Text = "(F2)\nAdicionar";
            this.csb_Adicionar.Click += new System.EventHandler(this.csb_Adicionar_Click);
            // 
            // csb_Buscar
            // 
            this.csb_Buscar.AllowFocus = false;
            this.csb_Buscar.Appearance.Options.UseTextOptions = true;
            this.csb_Buscar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Buscar.Image")));
            this.csb_Buscar.Location = new System.Drawing.Point(265, 5);
            this.csb_Buscar.Name = "csb_Buscar";
            this.csb_Buscar.Size = new System.Drawing.Size(79, 40);
            this.csb_Buscar.TabIndex = 6;
            this.csb_Buscar.Text = "(F5)\nBuscar";
            this.csb_Buscar.Click += new System.EventHandler(this.csb_Buscar_Click);
            // 
            // FPadrao_Busca_Menu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cpc_Menu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FPadrao_Busca_Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPadrao_Busca_Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Menu)).EndInit();
            this.cpc_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pm_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Menu.Painel_x32 cpc_Menu;
        private DevExpress.XtraBars.PopupMenu pm_Menu;
        private DevExpress.XtraBars.BarManager bm_Menu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_200;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_1000;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_Todos;
        public Componentes.Menu.Adicionar_x32 csb_Adicionar;
        public Componentes.Menu.Deletar_x32 csb_Deletar;
        public Componentes.Menu.Alterar_x32 csb_Alterar;
        public Componentes.Menu.Relatorio_x32 csb_Relatorio;
        private Componentes.Menu.Cancelar_x32 csb_Sair;
        private Componentes.Menu.Buscar_x32 csb_Buscar;
    }
}
