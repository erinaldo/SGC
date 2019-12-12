namespace Aplicativo
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.xtc_Abas = new DevExpress.XtraTab.XtraTabControl();
            this.xtp_Login = new DevExpress.XtraTab.XtraTabPage();
            this.cpc_Login = new Componentes.CPanelControl(this.components);
            this.csb_Entrar = new Componentes.CSimpleButton(this.components);
            this.cte_Senha = new Componentes.CTextEdit(this.components);
            this.clc_Senha = new Componentes.CLabelControl(this.components);
            this.cte_Usuario = new Componentes.CTextEdit(this.components);
            this.clc_Usuario = new Componentes.CLabelControl(this.components);
            this.xtp_Configuracoes = new DevExpress.XtraTab.XtraTabPage();
            this.cpc_Configuracoes = new Componentes.CPanelControl(this.components);
            this.ccbe_BancoDados = new Componentes.CComboBoxEdit(this.components);
            this.ccbe_ServidorInstancia = new Componentes.CComboBoxEdit(this.components);
            this.csb_SalvarConfiguracoes = new Componentes.CSimpleButton(this.components);
            this.clc_BancoDados = new Componentes.CLabelControl(this.components);
            this.clc_ServidorInstancia = new Componentes.CLabelControl(this.components);
            this.cpe_Logo = new Componentes.CPictureEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).BeginInit();
            this.xtc_Abas.SuspendLayout();
            this.xtp_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Login)).BeginInit();
            this.cpc_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Usuario.Properties)).BeginInit();
            this.xtp_Configuracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Configuracoes)).BeginInit();
            this.cpc_Configuracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_BancoDados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_ServidorInstancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe_Logo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtc_Abas
            // 
            this.xtc_Abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtc_Abas.Location = new System.Drawing.Point(0, 112);
            this.xtc_Abas.Name = "xtc_Abas";
            this.xtc_Abas.SelectedTabPage = this.xtp_Login;
            this.xtc_Abas.Size = new System.Drawing.Size(377, 191);
            this.xtc_Abas.TabIndex = 1;
            this.xtc_Abas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtp_Login,
            this.xtp_Configuracoes});
            // 
            // xtp_Login
            // 
            this.xtp_Login.Controls.Add(this.cpc_Login);
            this.xtp_Login.Name = "xtp_Login";
            this.xtp_Login.Size = new System.Drawing.Size(371, 163);
            this.xtp_Login.Text = "Login";
            // 
            // cpc_Login
            // 
            this.cpc_Login.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_Login.Appearance.Options.UseBackColor = true;
            this.cpc_Login.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Login.Controls.Add(this.csb_Entrar);
            this.cpc_Login.Controls.Add(this.cte_Senha);
            this.cpc_Login.Controls.Add(this.clc_Senha);
            this.cpc_Login.Controls.Add(this.cte_Usuario);
            this.cpc_Login.Controls.Add(this.clc_Usuario);
            this.cpc_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_Login.Location = new System.Drawing.Point(0, 0);
            this.cpc_Login.Name = "cpc_Login";
            this.cpc_Login.Size = new System.Drawing.Size(371, 163);
            this.cpc_Login.TabIndex = 0;
            // 
            // csb_Entrar
            // 
            this.csb_Entrar.Appearance.Options.UseTextOptions = true;
            this.csb_Entrar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Entrar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Entrar.Image")));
            this.csb_Entrar.Location = new System.Drawing.Point(225, 110);
            this.csb_Entrar.Name = "csb_Entrar";
            this.csb_Entrar.Size = new System.Drawing.Size(58, 23);
            this.csb_Entrar.TabIndex = 4;
            this.csb_Entrar.Text = "Entrar";
            this.csb_Entrar.Click += new System.EventHandler(this.csb_Entrar_Click);
            // 
            // cte_Senha
            // 
            this.cte_Senha.Descricao = "senha";
            this.cte_Senha.Location = new System.Drawing.Point(88, 84);
            this.cte_Senha.Mascara_IPv4 = false;
            this.cte_Senha.Mascara_PortaIPv4 = false;
            this.cte_Senha.Name = "cte_Senha";
            this.cte_Senha.NaoVazio = true;
            this.cte_Senha.Properties.MaxLength = 20;
            this.cte_Senha.Properties.UseSystemPasswordChar = true;
            this.cte_Senha.SemAcentuacao = false;
            this.cte_Senha.SemPontuacao = false;
            this.cte_Senha.Size = new System.Drawing.Size(195, 20);
            this.cte_Senha.SomenteNumeros = false;
            this.cte_Senha.TabIndex = 3;
            this.cte_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Login);
            // 
            // clc_Senha
            // 
            this.clc_Senha.Location = new System.Drawing.Point(88, 70);
            this.clc_Senha.Name = "clc_Senha";
            this.clc_Senha.Size = new System.Drawing.Size(34, 13);
            this.clc_Senha.TabIndex = 2;
            this.clc_Senha.Text = "Senha:";
            // 
            // cte_Usuario
            // 
            this.cte_Usuario.Descricao = "usuário";
            this.cte_Usuario.Location = new System.Drawing.Point(88, 43);
            this.cte_Usuario.Mascara_IPv4 = false;
            this.cte_Usuario.Mascara_PortaIPv4 = false;
            this.cte_Usuario.Name = "cte_Usuario";
            this.cte_Usuario.NaoVazio = true;
            this.cte_Usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Usuario.Properties.MaxLength = 20;
            this.cte_Usuario.SemAcentuacao = false;
            this.cte_Usuario.SemPontuacao = false;
            this.cte_Usuario.Size = new System.Drawing.Size(195, 20);
            this.cte_Usuario.SomenteNumeros = false;
            this.cte_Usuario.TabIndex = 1;
            this.cte_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Login);
            // 
            // clc_Usuario
            // 
            this.clc_Usuario.Location = new System.Drawing.Point(88, 29);
            this.clc_Usuario.Name = "clc_Usuario";
            this.clc_Usuario.Size = new System.Drawing.Size(40, 13);
            this.clc_Usuario.TabIndex = 0;
            this.clc_Usuario.Text = "Usuário:";
            // 
            // xtp_Configuracoes
            // 
            this.xtp_Configuracoes.Controls.Add(this.cpc_Configuracoes);
            this.xtp_Configuracoes.Name = "xtp_Configuracoes";
            this.xtp_Configuracoes.Size = new System.Drawing.Size(371, 163);
            this.xtp_Configuracoes.Text = "Configurações";
            // 
            // cpc_Configuracoes
            // 
            this.cpc_Configuracoes.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_Configuracoes.Appearance.Options.UseBackColor = true;
            this.cpc_Configuracoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Configuracoes.Controls.Add(this.ccbe_BancoDados);
            this.cpc_Configuracoes.Controls.Add(this.ccbe_ServidorInstancia);
            this.cpc_Configuracoes.Controls.Add(this.csb_SalvarConfiguracoes);
            this.cpc_Configuracoes.Controls.Add(this.clc_BancoDados);
            this.cpc_Configuracoes.Controls.Add(this.clc_ServidorInstancia);
            this.cpc_Configuracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_Configuracoes.Location = new System.Drawing.Point(0, 0);
            this.cpc_Configuracoes.Name = "cpc_Configuracoes";
            this.cpc_Configuracoes.Size = new System.Drawing.Size(371, 163);
            this.cpc_Configuracoes.TabIndex = 0;
            // 
            // ccbe_BancoDados
            // 
            this.ccbe_BancoDados.Descricao = "banco de dados";
            this.ccbe_BancoDados.Location = new System.Drawing.Point(88, 84);
            this.ccbe_BancoDados.Name = "ccbe_BancoDados";
            this.ccbe_BancoDados.NaoVazio = false;
            this.ccbe_BancoDados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_BancoDados.SemAcentuacao = false;
            this.ccbe_BancoDados.SemPontuacao = false;
            this.ccbe_BancoDados.Size = new System.Drawing.Size(195, 20);
            this.ccbe_BancoDados.SomenteNumeros = false;
            this.ccbe_BancoDados.TabIndex = 3;
            this.ccbe_BancoDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Configuracoes);
            // 
            // ccbe_ServidorInstancia
            // 
            this.ccbe_ServidorInstancia.Descricao = "servidor / instância do SQL Server";
            this.ccbe_ServidorInstancia.Location = new System.Drawing.Point(88, 43);
            this.ccbe_ServidorInstancia.Name = "ccbe_ServidorInstancia";
            this.ccbe_ServidorInstancia.NaoVazio = false;
            this.ccbe_ServidorInstancia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_ServidorInstancia.SemAcentuacao = false;
            this.ccbe_ServidorInstancia.SemPontuacao = false;
            this.ccbe_ServidorInstancia.Size = new System.Drawing.Size(195, 20);
            this.ccbe_ServidorInstancia.SomenteNumeros = false;
            this.ccbe_ServidorInstancia.TabIndex = 1;
            this.ccbe_ServidorInstancia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Configuracoes);
            // 
            // csb_SalvarConfiguracoes
            // 
            this.csb_SalvarConfiguracoes.Appearance.Options.UseTextOptions = true;
            this.csb_SalvarConfiguracoes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_SalvarConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("csb_SalvarConfiguracoes.Image")));
            this.csb_SalvarConfiguracoes.Location = new System.Drawing.Point(225, 110);
            this.csb_SalvarConfiguracoes.Name = "csb_SalvarConfiguracoes";
            this.csb_SalvarConfiguracoes.Size = new System.Drawing.Size(58, 23);
            this.csb_SalvarConfiguracoes.TabIndex = 4;
            this.csb_SalvarConfiguracoes.Text = "Salvar";
            this.csb_SalvarConfiguracoes.Click += new System.EventHandler(this.csb_SalvarConfiguracoes_Click);
            // 
            // clc_BancoDados
            // 
            this.clc_BancoDados.Location = new System.Drawing.Point(88, 70);
            this.clc_BancoDados.Name = "clc_BancoDados";
            this.clc_BancoDados.Size = new System.Drawing.Size(80, 13);
            this.clc_BancoDados.TabIndex = 2;
            this.clc_BancoDados.Text = "Banco de dados:";
            // 
            // clc_ServidorInstancia
            // 
            this.clc_ServidorInstancia.Location = new System.Drawing.Point(88, 29);
            this.clc_ServidorInstancia.Name = "clc_ServidorInstancia";
            this.clc_ServidorInstancia.Size = new System.Drawing.Size(153, 13);
            this.clc_ServidorInstancia.TabIndex = 0;
            this.clc_ServidorInstancia.Text = "Servidor / instância SQL Server:";
            // 
            // cpe_Logo
            // 
            this.cpe_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpe_Logo.EditValue = ((object)(resources.GetObject("cpe_Logo.EditValue")));
            this.cpe_Logo.Location = new System.Drawing.Point(0, 0);
            this.cpe_Logo.Name = "cpe_Logo";
            this.cpe_Logo.Size = new System.Drawing.Size(377, 112);
            this.cpe_Logo.TabIndex = 0;
            // 
            // FLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(377, 303);
            this.Controls.Add(this.xtc_Abas);
            this.Controls.Add(this.cpe_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLogin";
            this.ShowInTaskbar = true;
            this.Text = "SGC - Login";
            this.Load += new System.EventHandler(this.FLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).EndInit();
            this.xtc_Abas.ResumeLayout(false);
            this.xtp_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Login)).EndInit();
            this.cpc_Login.ResumeLayout(false);
            this.cpc_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Usuario.Properties)).EndInit();
            this.xtp_Configuracoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Configuracoes)).EndInit();
            this.cpc_Configuracoes.ResumeLayout(false);
            this.cpc_Configuracoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_BancoDados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_ServidorInstancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe_Logo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtc_Abas;
        private DevExpress.XtraTab.XtraTabPage xtp_Login;
        private Componentes.CPanelControl cpc_Login;
        private DevExpress.XtraTab.XtraTabPage xtp_Configuracoes;
        private Componentes.CPanelControl cpc_Configuracoes;
        private Componentes.CPictureEdit cpe_Logo;
        private Componentes.CTextEdit cte_Usuario;
        private Componentes.CLabelControl clc_Usuario;
        private Componentes.CSimpleButton csb_Entrar;
        private Componentes.CTextEdit cte_Senha;
        private Componentes.CLabelControl clc_Senha;
        private Componentes.CComboBoxEdit ccbe_BancoDados;
        private Componentes.CComboBoxEdit ccbe_ServidorInstancia;
        private Componentes.CSimpleButton csb_SalvarConfiguracoes;
        private Componentes.CLabelControl clc_BancoDados;
        private Componentes.CLabelControl clc_ServidorInstancia;

    }
}
