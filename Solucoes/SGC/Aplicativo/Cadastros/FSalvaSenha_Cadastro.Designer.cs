namespace Aplicativo.Cadastros
{
    partial class FSalvaSenha_Cadastro
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
            this.cpc_DadosGerais = new Componentes.CPanelControl(this.components);
            this.cce_Visualizar = new Componentes.CCheckEdit(this.components);
            this.clc_Senha = new Componentes.CLabelControl(this.components);
            this.cte_Senha = new Componentes.CTextEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.cte_Observacao = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Visualizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Observacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cce_Visualizar);
            this.cpc_DadosGerais.Controls.Add(this.clc_Senha);
            this.cpc_DadosGerais.Controls.Add(this.cte_Senha);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cte_Observacao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(732, 58);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cce_Visualizar
            // 
            this.cce_Visualizar.Location = new System.Drawing.Point(657, 22);
            this.cce_Visualizar.Name = "cce_Visualizar";
            this.cce_Visualizar.Properties.AutoWidth = true;
            this.cce_Visualizar.Properties.Caption = "Visualizar";
            this.cce_Visualizar.Size = new System.Drawing.Size(66, 19);
            this.cce_Visualizar.TabIndex = 6;
            this.cce_Visualizar.CheckedChanged += new System.EventHandler(this.cce_Visualizar_CheckedChanged);
            // 
            // clc_Senha
            // 
            this.clc_Senha.Location = new System.Drawing.Point(114, 8);
            this.clc_Senha.Name = "clc_Senha";
            this.clc_Senha.Size = new System.Drawing.Size(30, 13);
            this.clc_Senha.TabIndex = 2;
            this.clc_Senha.Text = "Senha";
            // 
            // cte_Senha
            // 
            this.cte_Senha.Descricao = "a senha";
            this.cte_Senha.Location = new System.Drawing.Point(114, 22);
            this.cte_Senha.Mascara_IPv4 = false;
            this.cte_Senha.Mascara_PortaIPv4 = false;
            this.cte_Senha.Name = "cte_Senha";
            this.cte_Senha.NaoVazio = true;
            this.cte_Senha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Senha.Properties.MaxLength = 256;
            this.cte_Senha.Properties.UseSystemPasswordChar = true;
            this.cte_Senha.SemAcentuacao = false;
            this.cte_Senha.SemPontuacao = false;
            this.cte_Senha.Size = new System.Drawing.Size(116, 20);
            this.cte_Senha.SomenteNumeros = false;
            this.cte_Senha.TabIndex = 3;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(233, 8);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 4;
            this.clc_Descricao.Text = "Descrição";
            // 
            // cte_Identificador
            // 
            this.cte_Identificador.Descricao = "código do cargo";
            this.cte_Identificador.Location = new System.Drawing.Point(11, 22);
            this.cte_Identificador.Mascara_IPv4 = false;
            this.cte_Identificador.Mascara_PortaIPv4 = false;
            this.cte_Identificador.Name = "cte_Identificador";
            this.cte_Identificador.NaoVazio = false;
            this.cte_Identificador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Identificador.Properties.ReadOnly = true;
            this.cte_Identificador.SemAcentuacao = false;
            this.cte_Identificador.SemPontuacao = false;
            this.cte_Identificador.Size = new System.Drawing.Size(100, 20);
            this.cte_Identificador.SomenteNumeros = true;
            this.cte_Identificador.TabIndex = 1;
            // 
            // cte_Observacao
            // 
            this.cte_Observacao.Descricao = "a descrição";
            this.cte_Observacao.Location = new System.Drawing.Point(233, 22);
            this.cte_Observacao.Mascara_IPv4 = false;
            this.cte_Observacao.Mascara_PortaIPv4 = false;
            this.cte_Observacao.Name = "cte_Observacao";
            this.cte_Observacao.NaoVazio = true;
            this.cte_Observacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Observacao.Properties.MaxLength = 256;
            this.cte_Observacao.SemAcentuacao = false;
            this.cte_Observacao.SemPontuacao = false;
            this.cte_Observacao.Size = new System.Drawing.Size(421, 20);
            this.cte_Observacao.SomenteNumeros = false;
            this.cte_Observacao.TabIndex = 5;
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Location = new System.Drawing.Point(11, 8);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(61, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Identificador";
            // 
            // FSalvaSenha_Cadastro
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 92);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FSalvaSenha_Cadastro";
            this.Text = "Cadastro Senhas";
            this.Load += new System.EventHandler(this.FSalvaSenha_Cadastro_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Visualizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Observacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CTextEdit cte_Observacao;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CLabelControl clc_Senha;
        private Componentes.CTextEdit cte_Senha;
        private Componentes.CCheckEdit cce_Visualizar;
    }
}