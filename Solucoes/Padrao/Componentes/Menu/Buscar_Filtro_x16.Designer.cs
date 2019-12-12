namespace Componentes.Menu
{
    partial class Buscar_Filtro_x16
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pm_Menu = new DevExpress.XtraBars.PopupMenu();
            this.bbi_Buscar_200 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Buscar_1000 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Buscar_Todos = new DevExpress.XtraBars.BarButtonItem();
            this.bm_Menu = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pm_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // pm_Menu
            // 
            this.pm_Menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_200),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_1000),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_Todos, true)});
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
            this.bm_Menu.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(94, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 24);
            this.barDockControlBottom.Size = new System.Drawing.Size(94, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 24);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(94, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 24);
            // 
            // Buscar_Filtro_x16
            // 
            this.AllowFocus = false;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DropDownControl = this.pm_Menu;
            this.Location = new System.Drawing.Point(273, 107);
            this.MenuManager = this.bm_Menu;
            this.Name = "Buscar_Filtro_16";
            this.Size = new System.Drawing.Size(94, 24);
            this.TabIndex = 4;
            ((System.ComponentModel.ISupportInitialize)(this.pm_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu pm_Menu;
        private DevExpress.XtraBars.BarManager bm_Menu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_200;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_1000;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_Todos;
    }
}