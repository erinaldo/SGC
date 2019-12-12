namespace Aplicativo
{
    partial class FTabelas
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
            this.cpc_Dados = new Componentes.CPanelControl(this.components);
            this.csb_ConectarBuscar = new Componentes.CSimpleButton(this.components);
            this.cte_Senha = new Componentes.CTextEdit(this.components);
            this.clc_Senha = new Componentes.CLabelControl(this.components);
            this.cte_Usuario = new Componentes.CTextEdit(this.components);
            this.clc_Usuario = new Componentes.CLabelControl(this.components);
            this.cte_BancoDados = new Componentes.CTextEdit(this.components);
            this.clc_BancoDados = new Componentes.CLabelControl(this.components);
            this.cte_Servidor = new Componentes.CTextEdit(this.components);
            this.clc_Servidor = new Componentes.CLabelControl(this.components);
            this.cpc_Gerar = new Componentes.CPanelControl(this.components);
            this.csb_Gerar = new Componentes.CSimpleButton(this.components);
            this.gc_Tabela = new DevExpress.XtraGrid.GridControl();
            this.gv_Tabela = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fbd_Arquivos = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Dados)).BeginInit();
            this.cpc_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_BancoDados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Servidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Gerar)).BeginInit();
            this.cpc_Gerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_Dados
            // 
            this.cpc_Dados.Controls.Add(this.csb_ConectarBuscar);
            this.cpc_Dados.Controls.Add(this.cte_Senha);
            this.cpc_Dados.Controls.Add(this.clc_Senha);
            this.cpc_Dados.Controls.Add(this.cte_Usuario);
            this.cpc_Dados.Controls.Add(this.clc_Usuario);
            this.cpc_Dados.Controls.Add(this.cte_BancoDados);
            this.cpc_Dados.Controls.Add(this.clc_BancoDados);
            this.cpc_Dados.Controls.Add(this.cte_Servidor);
            this.cpc_Dados.Controls.Add(this.clc_Servidor);
            this.cpc_Dados.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpc_Dados.Location = new System.Drawing.Point(0, 0);
            this.cpc_Dados.Name = "cpc_Dados";
            this.cpc_Dados.Size = new System.Drawing.Size(553, 57);
            this.cpc_Dados.TabIndex = 0;
            // 
            // csb_ConectarBuscar
            // 
            this.csb_ConectarBuscar.Location = new System.Drawing.Point(437, 25);
            this.csb_ConectarBuscar.Name = "csb_ConectarBuscar";
            this.csb_ConectarBuscar.Size = new System.Drawing.Size(105, 22);
            this.csb_ConectarBuscar.TabIndex = 8;
            this.csb_ConectarBuscar.Text = "Conectar e buscar";
            this.csb_ConectarBuscar.Click += new System.EventHandler(this.csb_ConectarBuscar_Click);
            // 
            // cte_Senha
            // 
            this.cte_Senha.Descricao = null;
            this.cte_Senha.Location = new System.Drawing.Point(331, 26);
            this.cte_Senha.Mascara_IPv4 = false;
            this.cte_Senha.Mascara_PortaIPv4 = false;
            this.cte_Senha.Name = "cte_Senha";
            this.cte_Senha.NaoVazio = false;
            this.cte_Senha.Properties.UseSystemPasswordChar = true;
            this.cte_Senha.SemAcentuacao = false;
            this.cte_Senha.SemPontuacao = false;
            this.cte_Senha.Size = new System.Drawing.Size(100, 20);
            this.cte_Senha.SomenteNumeros = false;
            this.cte_Senha.TabIndex = 7;
            // 
            // clc_Senha
            // 
            this.clc_Senha.Location = new System.Drawing.Point(331, 7);
            this.clc_Senha.Name = "clc_Senha";
            this.clc_Senha.Size = new System.Drawing.Size(30, 13);
            this.clc_Senha.TabIndex = 6;
            this.clc_Senha.Text = "Senha";
            // 
            // cte_Usuario
            // 
            this.cte_Usuario.Descricao = null;
            this.cte_Usuario.Location = new System.Drawing.Point(225, 26);
            this.cte_Usuario.Mascara_IPv4 = false;
            this.cte_Usuario.Mascara_PortaIPv4 = false;
            this.cte_Usuario.Name = "cte_Usuario";
            this.cte_Usuario.NaoVazio = false;
            this.cte_Usuario.SemAcentuacao = false;
            this.cte_Usuario.SemPontuacao = false;
            this.cte_Usuario.Size = new System.Drawing.Size(100, 20);
            this.cte_Usuario.SomenteNumeros = false;
            this.cte_Usuario.TabIndex = 5;
            // 
            // clc_Usuario
            // 
            this.clc_Usuario.Location = new System.Drawing.Point(225, 7);
            this.clc_Usuario.Name = "clc_Usuario";
            this.clc_Usuario.Size = new System.Drawing.Size(36, 13);
            this.clc_Usuario.TabIndex = 4;
            this.clc_Usuario.Text = "Usuário";
            // 
            // cte_BancoDados
            // 
            this.cte_BancoDados.Descricao = null;
            this.cte_BancoDados.Location = new System.Drawing.Point(119, 26);
            this.cte_BancoDados.Mascara_IPv4 = false;
            this.cte_BancoDados.Mascara_PortaIPv4 = false;
            this.cte_BancoDados.Name = "cte_BancoDados";
            this.cte_BancoDados.NaoVazio = false;
            this.cte_BancoDados.SemAcentuacao = false;
            this.cte_BancoDados.SemPontuacao = false;
            this.cte_BancoDados.Size = new System.Drawing.Size(100, 20);
            this.cte_BancoDados.SomenteNumeros = false;
            this.cte_BancoDados.TabIndex = 3;
            // 
            // clc_BancoDados
            // 
            this.clc_BancoDados.Location = new System.Drawing.Point(119, 7);
            this.clc_BancoDados.Name = "clc_BancoDados";
            this.clc_BancoDados.Size = new System.Drawing.Size(76, 13);
            this.clc_BancoDados.TabIndex = 2;
            this.clc_BancoDados.Text = "Banco de dados";
            // 
            // cte_Servidor
            // 
            this.cte_Servidor.Descricao = null;
            this.cte_Servidor.Location = new System.Drawing.Point(13, 26);
            this.cte_Servidor.Mascara_IPv4 = false;
            this.cte_Servidor.Mascara_PortaIPv4 = false;
            this.cte_Servidor.Name = "cte_Servidor";
            this.cte_Servidor.NaoVazio = false;
            this.cte_Servidor.SemAcentuacao = false;
            this.cte_Servidor.SemPontuacao = false;
            this.cte_Servidor.Size = new System.Drawing.Size(100, 20);
            this.cte_Servidor.SomenteNumeros = false;
            this.cte_Servidor.TabIndex = 1;
            // 
            // clc_Servidor
            // 
            this.clc_Servidor.Location = new System.Drawing.Point(13, 7);
            this.clc_Servidor.Name = "clc_Servidor";
            this.clc_Servidor.Size = new System.Drawing.Size(40, 13);
            this.clc_Servidor.TabIndex = 0;
            this.clc_Servidor.Text = "Servidor";
            // 
            // cpc_Gerar
            // 
            this.cpc_Gerar.Controls.Add(this.csb_Gerar);
            this.cpc_Gerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cpc_Gerar.Location = new System.Drawing.Point(0, 414);
            this.cpc_Gerar.Name = "cpc_Gerar";
            this.cpc_Gerar.Size = new System.Drawing.Size(553, 40);
            this.cpc_Gerar.TabIndex = 2;
            // 
            // csb_Gerar
            // 
            this.csb_Gerar.Location = new System.Drawing.Point(436, 9);
            this.csb_Gerar.Name = "csb_Gerar";
            this.csb_Gerar.Size = new System.Drawing.Size(105, 22);
            this.csb_Gerar.TabIndex = 0;
            this.csb_Gerar.Text = "Gerar";
            this.csb_Gerar.Click += new System.EventHandler(this.csb_Gerar_Click);
            // 
            // gc_Tabela
            // 
            this.gc_Tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Tabela.Location = new System.Drawing.Point(0, 57);
            this.gc_Tabela.MainView = this.gv_Tabela;
            this.gc_Tabela.Name = "gc_Tabela";
            this.gc_Tabela.Size = new System.Drawing.Size(553, 357);
            this.gc_Tabela.TabIndex = 1;
            this.gc_Tabela.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Tabela});
            // 
            // gv_Tabela
            // 
            this.gv_Tabela.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.gv_Tabela.GridControl = this.gc_Tabela;
            this.gv_Tabela.Name = "gv_Tabela";
            this.gv_Tabela.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Tabela.OptionsFind.AlwaysVisible = true;
            this.gv_Tabela.OptionsSelection.MultiSelect = true;
            // 
            // colName
            // 
            this.colName.Caption = "Tabela";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // FTabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 454);
            this.Controls.Add(this.gc_Tabela);
            this.Controls.Add(this.cpc_Gerar);
            this.Controls.Add(this.cpc_Dados);
            this.Name = "FTabelas";
            this.ShowInTaskbar = true;
            this.Text = "Gerador - Lorensoft";
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Dados)).EndInit();
            this.cpc_Dados.ResumeLayout(false);
            this.cpc_Dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_BancoDados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Servidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Gerar)).EndInit();
            this.cpc_Gerar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_Dados;
        private Componentes.CSimpleButton csb_ConectarBuscar;
        private Componentes.CTextEdit cte_Senha;
        private Componentes.CLabelControl clc_Senha;
        private Componentes.CTextEdit cte_Usuario;
        private Componentes.CLabelControl clc_Usuario;
        private Componentes.CTextEdit cte_BancoDados;
        private Componentes.CLabelControl clc_BancoDados;
        private Componentes.CTextEdit cte_Servidor;
        private Componentes.CLabelControl clc_Servidor;
        private Componentes.CPanelControl cpc_Gerar;
        private Componentes.CSimpleButton csb_Gerar;
        private DevExpress.XtraGrid.GridControl gc_Tabela;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Tabela;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.FolderBrowserDialog fbd_Arquivos;
    }
}
