namespace Aplicativo.Cadastros
{
    partial class FItem_Cadastro
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
            this.cbe_GrupoProduto = new Componentes.CButtonEdit(this.components);
            this.cLabelControl2 = new Componentes.CLabelControl(this.components);
            this.cte_DS_GrupoProduto = new Componentes.CTextEdit(this.components);
            this.cLabelControl1 = new Componentes.CLabelControl(this.components);
            this.cte_DS_Marca = new Componentes.CTextEdit(this.components);
            this.cbe_Modelo = new Componentes.CButtonEdit(this.components);
            this.clc_Marca = new Componentes.CLabelControl(this.components);
            this.cte_DS_Modelo = new Componentes.CTextEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.cte_Descricao = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_GrupoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_GrupoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Marca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Modelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Modelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cbe_GrupoProduto);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl2);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_GrupoProduto);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl1);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Marca);
            this.cpc_DadosGerais.Controls.Add(this.cbe_Modelo);
            this.cpc_DadosGerais.Controls.Add(this.clc_Marca);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Modelo);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cte_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(736, 128);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cbe_GrupoProduto
            // 
            this.cbe_GrupoProduto.Descricao = "o grupo do produto";
            this.cbe_GrupoProduto.EditValue = "";
            this.cbe_GrupoProduto.Location = new System.Drawing.Point(12, 96);
            this.cbe_GrupoProduto.Name = "cbe_GrupoProduto";
            this.cbe_GrupoProduto.NaoVazio = false;
            this.cbe_GrupoProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_GrupoProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_GrupoProduto.Properties.MaxLength = 9;
            this.cbe_GrupoProduto.SemAcentuacao = false;
            this.cbe_GrupoProduto.SemPontuacao = false;
            this.cbe_GrupoProduto.Size = new System.Drawing.Size(100, 20);
            this.cbe_GrupoProduto.SomenteNumeros = true;
            this.cbe_GrupoProduto.TabIndex = 10;
            this.cbe_GrupoProduto.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_GrupoProduto_ButtonClick);
            this.cbe_GrupoProduto.Leave += new System.EventHandler(this.cbe_GrupoProduto_Leave);
            // 
            // cLabelControl2
            // 
            this.cLabelControl2.Location = new System.Drawing.Point(13, 82);
            this.cLabelControl2.Name = "cLabelControl2";
            this.cLabelControl2.Size = new System.Drawing.Size(70, 13);
            this.cLabelControl2.TabIndex = 9;
            this.cLabelControl2.Text = "Grupo Produto";
            // 
            // cte_DS_GrupoProduto
            // 
            this.cte_DS_GrupoProduto.Descricao = null;
            this.cte_DS_GrupoProduto.Location = new System.Drawing.Point(115, 96);
            this.cte_DS_GrupoProduto.Mascara_IPv4 = false;
            this.cte_DS_GrupoProduto.Mascara_PortaIPv4 = false;
            this.cte_DS_GrupoProduto.Name = "cte_DS_GrupoProduto";
            this.cte_DS_GrupoProduto.NaoVazio = false;
            this.cte_DS_GrupoProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_GrupoProduto.Properties.ReadOnly = true;
            this.cte_DS_GrupoProduto.SemAcentuacao = false;
            this.cte_DS_GrupoProduto.SemPontuacao = false;
            this.cte_DS_GrupoProduto.Size = new System.Drawing.Size(609, 20);
            this.cte_DS_GrupoProduto.SomenteNumeros = false;
            this.cte_DS_GrupoProduto.TabIndex = 11;
            // 
            // cLabelControl1
            // 
            this.cLabelControl1.Location = new System.Drawing.Point(545, 45);
            this.cLabelControl1.Name = "cLabelControl1";
            this.cLabelControl1.Size = new System.Drawing.Size(29, 13);
            this.cLabelControl1.TabIndex = 7;
            this.cLabelControl1.Text = "Marca";
            // 
            // cte_DS_Marca
            // 
            this.cte_DS_Marca.Descricao = null;
            this.cte_DS_Marca.Location = new System.Drawing.Point(545, 59);
            this.cte_DS_Marca.Mascara_IPv4 = false;
            this.cte_DS_Marca.Mascara_PortaIPv4 = false;
            this.cte_DS_Marca.Name = "cte_DS_Marca";
            this.cte_DS_Marca.NaoVazio = false;
            this.cte_DS_Marca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Marca.Properties.ReadOnly = true;
            this.cte_DS_Marca.SemAcentuacao = false;
            this.cte_DS_Marca.SemPontuacao = false;
            this.cte_DS_Marca.Size = new System.Drawing.Size(179, 20);
            this.cte_DS_Marca.SomenteNumeros = false;
            this.cte_DS_Marca.TabIndex = 8;
            // 
            // cbe_Modelo
            // 
            this.cbe_Modelo.Descricao = "o modelo";
            this.cbe_Modelo.EditValue = "";
            this.cbe_Modelo.Location = new System.Drawing.Point(11, 59);
            this.cbe_Modelo.Name = "cbe_Modelo";
            this.cbe_Modelo.NaoVazio = false;
            this.cbe_Modelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Modelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Modelo.Properties.MaxLength = 9;
            this.cbe_Modelo.SemAcentuacao = false;
            this.cbe_Modelo.SemPontuacao = false;
            this.cbe_Modelo.Size = new System.Drawing.Size(100, 20);
            this.cbe_Modelo.SomenteNumeros = true;
            this.cbe_Modelo.TabIndex = 5;
            this.cbe_Modelo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Modelo_ButtonClick);
            this.cbe_Modelo.Leave += new System.EventHandler(this.cbe_Modelo_Leave);
            // 
            // clc_Marca
            // 
            this.clc_Marca.Location = new System.Drawing.Point(12, 45);
            this.clc_Marca.Name = "clc_Marca";
            this.clc_Marca.Size = new System.Drawing.Size(34, 13);
            this.clc_Marca.TabIndex = 4;
            this.clc_Marca.Text = "Modelo";
            // 
            // cte_DS_Modelo
            // 
            this.cte_DS_Modelo.Descricao = null;
            this.cte_DS_Modelo.Location = new System.Drawing.Point(114, 59);
            this.cte_DS_Modelo.Mascara_IPv4 = false;
            this.cte_DS_Modelo.Mascara_PortaIPv4 = false;
            this.cte_DS_Modelo.Name = "cte_DS_Modelo";
            this.cte_DS_Modelo.NaoVazio = false;
            this.cte_DS_Modelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Modelo.Properties.ReadOnly = true;
            this.cte_DS_Modelo.SemAcentuacao = false;
            this.cte_DS_Modelo.SemPontuacao = false;
            this.cte_DS_Modelo.Size = new System.Drawing.Size(428, 20);
            this.cte_DS_Modelo.SomenteNumeros = false;
            this.cte_DS_Modelo.TabIndex = 6;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(114, 8);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 2;
            this.clc_Descricao.Text = "Descrição";
            // 
            // cte_Identificador
            // 
            this.cte_Identificador.Descricao = "código do item";
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
            this.cte_Descricao.Descricao = "a descrição";
            this.cte_Descricao.Location = new System.Drawing.Point(114, 22);
            this.cte_Descricao.Mascara_IPv4 = false;
            this.cte_Descricao.Mascara_PortaIPv4 = false;
            this.cte_Descricao.Name = "cte_Descricao";
            this.cte_Descricao.NaoVazio = true;
            this.cte_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Descricao.Properties.MaxLength = 256;
            this.cte_Descricao.SemAcentuacao = false;
            this.cte_Descricao.SemPontuacao = false;
            this.cte_Descricao.Size = new System.Drawing.Size(610, 20);
            this.cte_Descricao.SomenteNumeros = false;
            this.cte_Descricao.TabIndex = 3;
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Location = new System.Drawing.Point(11, 8);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(61, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Identificador";
            // 
            // FItem_Cadastro
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 162);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FItem_Cadastro";
            this.Text = "Cadastro - Item";
            this.Load += new System.EventHandler(this.FItem_Cadastro_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_GrupoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_GrupoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Marca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Modelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Modelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CButtonEdit cbe_Modelo;
        private Componentes.CLabelControl clc_Marca;
        private Componentes.CTextEdit cte_DS_Modelo;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CTextEdit cte_Descricao;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CLabelControl cLabelControl1;
        private Componentes.CTextEdit cte_DS_Marca;
        private Componentes.CButtonEdit cbe_GrupoProduto;
        private Componentes.CLabelControl cLabelControl2;
        private Componentes.CTextEdit cte_DS_GrupoProduto;
    }
}