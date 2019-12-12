namespace Formas.Padrao
{
    partial class FPadrao_Cadastro_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPadrao_Cadastro_Menu));
            this.cpc_Menu = new Componentes.Menu.Painel_x32();
            this.csb_Cancelar = new Componentes.Menu.Cancelar_x16();
            this.csb_Salvar = new Componentes.Menu.Salvar_x16();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Menu)).BeginInit();
            this.cpc_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpc_Menu
            // 
            this.cpc_Menu.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.cpc_Menu.Appearance.Options.UseBackColor = true;
            this.cpc_Menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cpc_Menu.Controls.Add(this.csb_Cancelar);
            this.cpc_Menu.Controls.Add(this.csb_Salvar);
            this.cpc_Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cpc_Menu.Location = new System.Drawing.Point(0, 377);
            this.cpc_Menu.Name = "cpc_Menu";
            this.cpc_Menu.Size = new System.Drawing.Size(734, 34);
            this.cpc_Menu.TabIndex = 0;
            // 
            // csb_Cancelar
            // 
            this.csb_Cancelar.AllowFocus = false;
            this.csb_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csb_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Cancelar.Image")));
            this.csb_Cancelar.Location = new System.Drawing.Point(629, 5);
            this.csb_Cancelar.Name = "csb_Cancelar";
            this.csb_Cancelar.Size = new System.Drawing.Size(100, 24);
            this.csb_Cancelar.TabIndex = 1;
            this.csb_Cancelar.Text = "(ESC) Cancelar";
            this.csb_Cancelar.Click += new System.EventHandler(this.csb_Cancelar_Click);
            // 
            // csb_Salvar
            // 
            this.csb_Salvar.AllowFocus = false;
            this.csb_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csb_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Salvar.Image")));
            this.csb_Salvar.Location = new System.Drawing.Point(543, 5);
            this.csb_Salvar.Name = "csb_Salvar";
            this.csb_Salvar.Size = new System.Drawing.Size(82, 24);
            this.csb_Salvar.TabIndex = 0;
            this.csb_Salvar.Text = "(F2) Salvar";
            this.csb_Salvar.Click += new System.EventHandler(this.csb_Salvar_Click);
            // 
            // FPadrao_Cadastro_Menu
            // 
            this.Appearance.BackColor = Utilidades.Cores.Sistema();
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.ControlBox = false;
            this.Controls.Add(this.cpc_Menu);
            this.Name = "FPadrao_Cadastro_Menu";
            this.KeyDown += this.FPadrao_Cadastro_Menu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Menu)).EndInit();
            this.cpc_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Menu.Painel_x32 cpc_Menu;
        private Componentes.Menu.Cancelar_x16 csb_Cancelar;
        private Componentes.Menu.Salvar_x16 csb_Salvar;
    }
}
