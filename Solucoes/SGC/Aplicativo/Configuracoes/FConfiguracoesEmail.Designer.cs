namespace Aplicativo.Configuracoes
{
    partial class FConfiguracoesEmail
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
            this.cce_EnviarEmails = new Componentes.CCheckEdit(this.components);
            this.clc_Senha = new Componentes.CLabelControl(this.components);
            this.cte_Senha = new Componentes.CTextEdit(this.components);
            this.clc_Email = new Componentes.CLabelControl(this.components);
            this.cte_Email = new Componentes.CTextEdit(this.components);
            this.cce_SSL = new Componentes.CCheckEdit(this.components);
            this.clc_Porta = new Componentes.CLabelControl(this.components);
            this.cse_Porta = new Componentes.CSpinEdit(this.components);
            this.clc_SMTP = new Componentes.CLabelControl(this.components);
            this.cte_SMTP = new Componentes.CTextEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_EnviarEmails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_SSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cse_Porta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_SMTP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cce_EnviarEmails);
            this.cpc_DadosGerais.Controls.Add(this.clc_Senha);
            this.cpc_DadosGerais.Controls.Add(this.cte_Senha);
            this.cpc_DadosGerais.Controls.Add(this.clc_Email);
            this.cpc_DadosGerais.Controls.Add(this.cte_Email);
            this.cpc_DadosGerais.Controls.Add(this.cce_SSL);
            this.cpc_DadosGerais.Controls.Add(this.clc_Porta);
            this.cpc_DadosGerais.Controls.Add(this.cse_Porta);
            this.cpc_DadosGerais.Controls.Add(this.clc_SMTP);
            this.cpc_DadosGerais.Controls.Add(this.cte_SMTP);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(414, 96);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cce_EnviarEmails
            // 
            this.cce_EnviarEmails.Location = new System.Drawing.Point(319, 22);
            this.cce_EnviarEmails.Name = "cce_EnviarEmails";
            this.cce_EnviarEmails.Properties.AutoWidth = true;
            this.cce_EnviarEmails.Properties.Caption = "Enviar emails";
            this.cce_EnviarEmails.Size = new System.Drawing.Size(84, 19);
            this.cce_EnviarEmails.TabIndex = 5;
            // 
            // clc_Senha
            // 
            this.clc_Senha.Location = new System.Drawing.Point(271, 48);
            this.clc_Senha.Name = "clc_Senha";
            this.clc_Senha.Size = new System.Drawing.Size(30, 13);
            this.clc_Senha.TabIndex = 8;
            this.clc_Senha.Text = "Senha";
            // 
            // cte_Senha
            // 
            this.cte_Senha.Descricao = "a senha";
            this.cte_Senha.Location = new System.Drawing.Point(271, 62);
            this.cte_Senha.Mascara_IPv4 = false;
            this.cte_Senha.Mascara_PortaIPv4 = false;
            this.cte_Senha.Name = "cte_Senha";
            this.cte_Senha.NaoVazio = true;
            this.cte_Senha.Properties.MaxLength = 256;
            this.cte_Senha.Properties.UseSystemPasswordChar = true;
            this.cte_Senha.SemAcentuacao = false;
            this.cte_Senha.SemPontuacao = false;
            this.cte_Senha.Size = new System.Drawing.Size(132, 20);
            this.cte_Senha.SomenteNumeros = false;
            this.cte_Senha.TabIndex = 9;
            // 
            // clc_Email
            // 
            this.clc_Email.Location = new System.Drawing.Point(12, 48);
            this.clc_Email.Name = "clc_Email";
            this.clc_Email.Size = new System.Drawing.Size(24, 13);
            this.clc_Email.TabIndex = 6;
            this.clc_Email.Text = "Email";
            // 
            // cte_Email
            // 
            this.cte_Email.Descricao = "o email";
            this.cte_Email.Location = new System.Drawing.Point(12, 62);
            this.cte_Email.Mascara_IPv4 = false;
            this.cte_Email.Mascara_PortaIPv4 = false;
            this.cte_Email.Name = "cte_Email";
            this.cte_Email.NaoVazio = true;
            this.cte_Email.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Email.Properties.MaxLength = 256;
            this.cte_Email.SemAcentuacao = false;
            this.cte_Email.SemPontuacao = false;
            this.cte_Email.Size = new System.Drawing.Size(256, 20);
            this.cte_Email.SomenteNumeros = false;
            this.cte_Email.TabIndex = 7;
            // 
            // cce_SSL
            // 
            this.cce_SSL.EditValue = true;
            this.cce_SSL.Location = new System.Drawing.Point(274, 22);
            this.cce_SSL.Name = "cce_SSL";
            this.cce_SSL.Properties.AutoWidth = true;
            this.cce_SSL.Properties.Caption = "SSL";
            this.cce_SSL.Size = new System.Drawing.Size(39, 19);
            this.cce_SSL.TabIndex = 4;
            // 
            // clc_Porta
            // 
            this.clc_Porta.Location = new System.Drawing.Point(200, 8);
            this.clc_Porta.Name = "clc_Porta";
            this.clc_Porta.Size = new System.Drawing.Size(26, 13);
            this.clc_Porta.TabIndex = 2;
            this.clc_Porta.Text = "Porta";
            // 
            // cse_Porta
            // 
            this.cse_Porta.Decimais = 0;
            this.cse_Porta.Descricao = "a porta";
            this.cse_Porta.EditValue = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.cse_Porta.Location = new System.Drawing.Point(200, 22);
            this.cse_Porta.Name = "cse_Porta";
            this.cse_Porta.NaoVazio = false;
            this.cse_Porta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cse_Porta.Properties.Appearance.Options.UseBackColor = true;
            this.cse_Porta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cse_Porta.Properties.DisplayFormat.FormatString = "d";
            this.cse_Porta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cse_Porta.Properties.EditFormat.FormatString = "d";
            this.cse_Porta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cse_Porta.Properties.Mask.EditMask = "d";
            this.cse_Porta.Properties.MaxValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.cse_Porta.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cse_Porta.Size = new System.Drawing.Size(68, 20);
            this.cse_Porta.TabIndex = 3;
            // 
            // clc_SMTP
            // 
            this.clc_SMTP.Location = new System.Drawing.Point(12, 8);
            this.clc_SMTP.Name = "clc_SMTP";
            this.clc_SMTP.Size = new System.Drawing.Size(26, 13);
            this.clc_SMTP.TabIndex = 0;
            this.clc_SMTP.Text = "SMTP";
            // 
            // cte_SMTP
            // 
            this.cte_SMTP.Descricao = "o SMTP";
            this.cte_SMTP.Location = new System.Drawing.Point(12, 22);
            this.cte_SMTP.Mascara_IPv4 = false;
            this.cte_SMTP.Mascara_PortaIPv4 = false;
            this.cte_SMTP.Name = "cte_SMTP";
            this.cte_SMTP.NaoVazio = true;
            this.cte_SMTP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_SMTP.Properties.MaxLength = 256;
            this.cte_SMTP.SemAcentuacao = false;
            this.cte_SMTP.SemPontuacao = false;
            this.cte_SMTP.Size = new System.Drawing.Size(185, 20);
            this.cte_SMTP.SomenteNumeros = false;
            this.cte_SMTP.TabIndex = 1;
            // 
            // FConfiguracoesEmail
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(414, 130);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FConfiguracoesEmail";
            this.Text = "Configurações de envio de email";
            this.Load += new System.EventHandler(this.FConfiguracoesEmail_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_EnviarEmails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Senha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_SSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cse_Porta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_SMTP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Porta;
        private Componentes.CSpinEdit cse_Porta;
        private Componentes.CLabelControl clc_SMTP;
        private Componentes.CTextEdit cte_SMTP;
        private Componentes.CCheckEdit cce_SSL;
        private Componentes.CCheckEdit cce_EnviarEmails;
        private Componentes.CLabelControl clc_Senha;
        private Componentes.CTextEdit cte_Senha;
        private Componentes.CLabelControl clc_Email;
        private Componentes.CTextEdit cte_Email;

    }
}
