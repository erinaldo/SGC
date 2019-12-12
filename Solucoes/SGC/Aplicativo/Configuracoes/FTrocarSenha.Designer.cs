namespace Aplicativo.Configuracoes
{
    partial class FTrocarSenha
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
            this.clc_SenhaNova = new Componentes.CLabelControl(this.components);
            this.cte_SenhaNova = new Componentes.CTextEdit(this.components);
            this.clc_SenhaAntiga = new Componentes.CLabelControl(this.components);
            this.cte_SenhaAntiga = new Componentes.CTextEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_SenhaNova.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_SenhaAntiga.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.clc_SenhaNova);
            this.cpc_DadosGerais.Controls.Add(this.cte_SenhaNova);
            this.cpc_DadosGerais.Controls.Add(this.clc_SenhaAntiga);
            this.cpc_DadosGerais.Controls.Add(this.cte_SenhaAntiga);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(196, 94);
            this.cpc_DadosGerais.TabIndex = 1;
            // 
            // clc_SenhaNova
            // 
            this.clc_SenhaNova.Location = new System.Drawing.Point(12, 48);
            this.clc_SenhaNova.Name = "clc_SenhaNova";
            this.clc_SenhaNova.Size = new System.Drawing.Size(57, 13);
            this.clc_SenhaNova.TabIndex = 6;
            this.clc_SenhaNova.Text = "Senha nova";
            // 
            // cte_SenhaNova
            // 
            this.cte_SenhaNova.Descricao = "a senha nova";
            this.cte_SenhaNova.Location = new System.Drawing.Point(12, 62);
            this.cte_SenhaNova.Mascara_IPv4 = false;
            this.cte_SenhaNova.Mascara_PortaIPv4 = false;
            this.cte_SenhaNova.Name = "cte_SenhaNova";
            this.cte_SenhaNova.NaoVazio = true;
            this.cte_SenhaNova.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_SenhaNova.Properties.MaxLength = 256;
            this.cte_SenhaNova.Properties.UseSystemPasswordChar = true;
            this.cte_SenhaNova.SemAcentuacao = false;
            this.cte_SenhaNova.SemPontuacao = false;
            this.cte_SenhaNova.Size = new System.Drawing.Size(173, 20);
            this.cte_SenhaNova.SomenteNumeros = false;
            this.cte_SenhaNova.TabIndex = 7;
            // 
            // clc_SenhaAntiga
            // 
            this.clc_SenhaAntiga.Location = new System.Drawing.Point(12, 8);
            this.clc_SenhaAntiga.Name = "clc_SenhaAntiga";
            this.clc_SenhaAntiga.Size = new System.Drawing.Size(63, 13);
            this.clc_SenhaAntiga.TabIndex = 0;
            this.clc_SenhaAntiga.Text = "Senha antiga";
            // 
            // cte_SenhaAntiga
            // 
            this.cte_SenhaAntiga.Descricao = "a senha antiga";
            this.cte_SenhaAntiga.Location = new System.Drawing.Point(12, 22);
            this.cte_SenhaAntiga.Mascara_IPv4 = false;
            this.cte_SenhaAntiga.Mascara_PortaIPv4 = false;
            this.cte_SenhaAntiga.Name = "cte_SenhaAntiga";
            this.cte_SenhaAntiga.NaoVazio = true;
            this.cte_SenhaAntiga.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_SenhaAntiga.Properties.MaxLength = 256;
            this.cte_SenhaAntiga.Properties.UseSystemPasswordChar = true;
            this.cte_SenhaAntiga.SemAcentuacao = false;
            this.cte_SenhaAntiga.SemPontuacao = false;
            this.cte_SenhaAntiga.Size = new System.Drawing.Size(173, 20);
            this.cte_SenhaAntiga.SomenteNumeros = false;
            this.cte_SenhaAntiga.TabIndex = 1;
            // 
            // FTrocarSenha
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(196, 128);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FTrocarSenha";
            this.Text = "Trocar senha";
            this.Load += new System.EventHandler(this.FTrocarSenha_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_SenhaNova.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_SenhaAntiga.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_SenhaNova;
        private Componentes.CTextEdit cte_SenhaNova;
        private Componentes.CLabelControl clc_SenhaAntiga;
        private Componentes.CTextEdit cte_SenhaAntiga;
    }
}
