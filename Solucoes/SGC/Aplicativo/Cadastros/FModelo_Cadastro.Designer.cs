namespace Aplicativo.Cadastros
{
    partial class FModelo_Cadastro
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
            this.cbe_Marca = new Componentes.CButtonEdit(this.components);
            this.clc_Marca = new Componentes.CLabelControl(this.components);
            this.cte_DS_Marca = new Componentes.CTextEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.cte_Descricao = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Marca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Marca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cbe_Marca);
            this.cpc_DadosGerais.Controls.Add(this.clc_Marca);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Marca);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cte_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(734, 92);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cbe_Marca
            // 
            this.cbe_Marca.Descricao = "marca";
            this.cbe_Marca.EditValue = "";
            this.cbe_Marca.Location = new System.Drawing.Point(11, 59);
            this.cbe_Marca.Name = "cbe_Marca";
            this.cbe_Marca.NaoVazio = false;
            this.cbe_Marca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Marca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Marca.Properties.MaxLength = 9;
            this.cbe_Marca.SemAcentuacao = false;
            this.cbe_Marca.SemPontuacao = false;
            this.cbe_Marca.Size = new System.Drawing.Size(100, 20);
            this.cbe_Marca.SomenteNumeros = true;
            this.cbe_Marca.TabIndex = 25;
            this.cbe_Marca.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Marca_ButtonClick);
            this.cbe_Marca.Leave += new System.EventHandler(this.cbe_Marca_Leave);
            // 
            // clc_Marca
            // 
            this.clc_Marca.Location = new System.Drawing.Point(12, 45);
            this.clc_Marca.Name = "clc_Marca";
            this.clc_Marca.Size = new System.Drawing.Size(29, 13);
            this.clc_Marca.TabIndex = 24;
            this.clc_Marca.Text = "Marca";
            // 
            // cte_DS_Marca
            // 
            this.cte_DS_Marca.Descricao = null;
            this.cte_DS_Marca.Location = new System.Drawing.Point(114, 59);
            this.cte_DS_Marca.Mascara_IPv4 = false;
            this.cte_DS_Marca.Mascara_PortaIPv4 = false;
            this.cte_DS_Marca.Name = "cte_DS_Marca";
            this.cte_DS_Marca.NaoVazio = false;
            this.cte_DS_Marca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Marca.Properties.ReadOnly = true;
            this.cte_DS_Marca.SemAcentuacao = false;
            this.cte_DS_Marca.SemPontuacao = false;
            this.cte_DS_Marca.Size = new System.Drawing.Size(611, 20);
            this.cte_DS_Marca.SomenteNumeros = false;
            this.cte_DS_Marca.TabIndex = 26;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(114, 8);
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
            // cte_Descricao
            // 
            this.cte_Descricao.Descricao = "descrição Cargo";
            this.cte_Descricao.Location = new System.Drawing.Point(114, 22);
            this.cte_Descricao.Mascara_IPv4 = false;
            this.cte_Descricao.Mascara_PortaIPv4 = false;
            this.cte_Descricao.Name = "cte_Descricao";
            this.cte_Descricao.NaoVazio = true;
            this.cte_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Descricao.Properties.MaxLength = 256;
            this.cte_Descricao.SemAcentuacao = false;
            this.cte_Descricao.SemPontuacao = false;
            this.cte_Descricao.Size = new System.Drawing.Size(611, 20);
            this.cte_Descricao.SomenteNumeros = false;
            this.cte_Descricao.TabIndex = 2;
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Location = new System.Drawing.Point(11, 8);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(61, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Identificador";
            // 
            // FModelo_Cadastro
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 126);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FModelo_Cadastro";
            this.Text = "Cadastro - Modelo";
            this.Load += new System.EventHandler(this.FModelo_Cadastro_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Marca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Marca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CTextEdit cte_Descricao;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CButtonEdit cbe_Marca;
        private Componentes.CLabelControl clc_Marca;
        private Componentes.CTextEdit cte_DS_Marca;

    }
}
