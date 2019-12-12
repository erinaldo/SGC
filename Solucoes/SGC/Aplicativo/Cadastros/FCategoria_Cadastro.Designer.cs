namespace Aplicativo.Cadastros
{
    partial class FCategoria_Cadastro
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
            this.cse_TempoMax = new Componentes.CSpinEdit(this.components);
            this.cse_TempoMin = new Componentes.CSpinEdit(this.components);
            this.cLabelControl2 = new Componentes.CLabelControl(this.components);
            this.cLabelControl1 = new Componentes.CLabelControl(this.components);
            this.cLc_Classificacao = new Componentes.CLabelControl(this.components);
            this.cte_Classificacao = new Componentes.CTextEdit(this.components);
            this.ccbe_Gravidade = new Componentes.CComboBoxEdit(this.components);
            this.clc_Gravidade = new Componentes.CLabelControl(this.components);
            this.cbe_Departamento = new Componentes.CButtonEdit(this.components);
            this.clc_Marca = new Componentes.CLabelControl(this.components);
            this.cte_DS_Departamento = new Componentes.CTextEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.cte_Descricao = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cse_TempoMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cse_TempoMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Classificacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Gravidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Departamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Departamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cse_TempoMax);
            this.cpc_DadosGerais.Controls.Add(this.cse_TempoMin);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl2);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl1);
            this.cpc_DadosGerais.Controls.Add(this.cLc_Classificacao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Classificacao);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Gravidade);
            this.cpc_DadosGerais.Controls.Add(this.clc_Gravidade);
            this.cpc_DadosGerais.Controls.Add(this.cbe_Departamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_Marca);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Departamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cte_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(734, 131);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cse_TempoMax
            // 
            this.cse_TempoMax.Decimais = 0;
            this.cse_TempoMax.Descricao = "o tempo de horas máximas";
            this.cse_TempoMax.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cse_TempoMax.Location = new System.Drawing.Point(576, 98);
            this.cse_TempoMax.Name = "cse_TempoMax";
            this.cse_TempoMax.NaoVazio = false;
            this.cse_TempoMax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cse_TempoMax.Properties.DisplayFormat.FormatString = "d";
            this.cse_TempoMax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cse_TempoMax.Properties.EditFormat.FormatString = "d";
            this.cse_TempoMax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cse_TempoMax.Properties.Mask.EditMask = "d";
            this.cse_TempoMax.Size = new System.Drawing.Size(146, 20);
            this.cse_TempoMax.TabIndex = 14;
            // 
            // cse_TempoMin
            // 
            this.cse_TempoMin.Decimais = 0;
            this.cse_TempoMin.Descricao = "o tempo de horas mínimas";
            this.cse_TempoMin.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cse_TempoMin.Location = new System.Drawing.Point(428, 98);
            this.cse_TempoMin.Name = "cse_TempoMin";
            this.cse_TempoMin.NaoVazio = false;
            this.cse_TempoMin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cse_TempoMin.Properties.DisplayFormat.FormatString = "d";
            this.cse_TempoMin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cse_TempoMin.Properties.EditFormat.FormatString = "d";
            this.cse_TempoMin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cse_TempoMin.Properties.Mask.EditMask = "d";
            this.cse_TempoMin.Size = new System.Drawing.Size(145, 20);
            this.cse_TempoMin.TabIndex = 12;
            // 
            // cLabelControl2
            // 
            this.cLabelControl2.Location = new System.Drawing.Point(576, 84);
            this.cLabelControl2.Name = "cLabelControl2";
            this.cLabelControl2.Size = new System.Drawing.Size(145, 13);
            this.cLabelControl2.TabIndex = 13;
            this.cLabelControl2.Text = "Tempo Max. Atendimento (Hr)";
            // 
            // cLabelControl1
            // 
            this.cLabelControl1.Location = new System.Drawing.Point(428, 84);
            this.cLabelControl1.Name = "cLabelControl1";
            this.cLabelControl1.Size = new System.Drawing.Size(141, 13);
            this.cLabelControl1.TabIndex = 11;
            this.cLabelControl1.Text = "Tempo Min. Atendimento (Hr)";
            // 
            // cLc_Classificacao
            // 
            this.cLc_Classificacao.Location = new System.Drawing.Point(114, 84);
            this.cLc_Classificacao.Name = "cLc_Classificacao";
            this.cLc_Classificacao.Size = new System.Drawing.Size(61, 13);
            this.cLc_Classificacao.TabIndex = 9;
            this.cLc_Classificacao.Text = "Classificação";
            // 
            // cte_Classificacao
            // 
            this.cte_Classificacao.Descricao = "a classificação";
            this.cte_Classificacao.Location = new System.Drawing.Point(114, 98);
            this.cte_Classificacao.Mascara_IPv4 = false;
            this.cte_Classificacao.Mascara_PortaIPv4 = false;
            this.cte_Classificacao.Name = "cte_Classificacao";
            this.cte_Classificacao.NaoVazio = true;
            this.cte_Classificacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Classificacao.Properties.Mask.BeepOnError = true;
            this.cte_Classificacao.Properties.Mask.EditMask = "XX.XX.XX.XX.XX";
            this.cte_Classificacao.Properties.MaxLength = 256;
            this.cte_Classificacao.SemAcentuacao = false;
            this.cte_Classificacao.SemPontuacao = false;
            this.cte_Classificacao.Size = new System.Drawing.Size(311, 20);
            this.cte_Classificacao.SomenteNumeros = false;
            this.cte_Classificacao.TabIndex = 10;
            // 
            // ccbe_Gravidade
            // 
            this.ccbe_Gravidade.Descricao = "a gravidade";
            this.ccbe_Gravidade.Location = new System.Drawing.Point(11, 98);
            this.ccbe_Gravidade.Name = "ccbe_Gravidade";
            this.ccbe_Gravidade.NaoVazio = false;
            this.ccbe_Gravidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Gravidade.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Gravidade.SemAcentuacao = false;
            this.ccbe_Gravidade.SemPontuacao = false;
            this.ccbe_Gravidade.Size = new System.Drawing.Size(100, 20);
            this.ccbe_Gravidade.SomenteNumeros = false;
            this.ccbe_Gravidade.TabIndex = 8;
            // 
            // clc_Gravidade
            // 
            this.clc_Gravidade.Location = new System.Drawing.Point(11, 84);
            this.clc_Gravidade.Name = "clc_Gravidade";
            this.clc_Gravidade.Size = new System.Drawing.Size(49, 13);
            this.clc_Gravidade.TabIndex = 7;
            this.clc_Gravidade.Text = "Gravidade";
            // 
            // cbe_Departamento
            // 
            this.cbe_Departamento.Descricao = "o departamento";
            this.cbe_Departamento.EditValue = "";
            this.cbe_Departamento.Location = new System.Drawing.Point(11, 60);
            this.cbe_Departamento.Name = "cbe_Departamento";
            this.cbe_Departamento.NaoVazio = false;
            this.cbe_Departamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Departamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Departamento.Properties.MaxLength = 9;
            this.cbe_Departamento.SemAcentuacao = false;
            this.cbe_Departamento.SemPontuacao = false;
            this.cbe_Departamento.Size = new System.Drawing.Size(100, 20);
            this.cbe_Departamento.SomenteNumeros = true;
            this.cbe_Departamento.TabIndex = 5;
            this.cbe_Departamento.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Departamento_ButtonClick);
            this.cbe_Departamento.Leave += new System.EventHandler(this.cbe_Departamento_Leave);
            // 
            // clc_Marca
            // 
            this.clc_Marca.Location = new System.Drawing.Point(12, 46);
            this.clc_Marca.Name = "clc_Marca";
            this.clc_Marca.Size = new System.Drawing.Size(69, 13);
            this.clc_Marca.TabIndex = 4;
            this.clc_Marca.Text = "Departamento";
            // 
            // cte_DS_Departamento
            // 
            this.cte_DS_Departamento.Descricao = null;
            this.cte_DS_Departamento.Location = new System.Drawing.Point(114, 60);
            this.cte_DS_Departamento.Mascara_IPv4 = false;
            this.cte_DS_Departamento.Mascara_PortaIPv4 = false;
            this.cte_DS_Departamento.Name = "cte_DS_Departamento";
            this.cte_DS_Departamento.NaoVazio = false;
            this.cte_DS_Departamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Departamento.Properties.ReadOnly = true;
            this.cte_DS_Departamento.SemAcentuacao = false;
            this.cte_DS_Departamento.SemPontuacao = false;
            this.cte_DS_Departamento.Size = new System.Drawing.Size(608, 20);
            this.cte_DS_Departamento.SomenteNumeros = false;
            this.cte_DS_Departamento.TabIndex = 6;
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
            this.cte_Descricao.Size = new System.Drawing.Size(608, 20);
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
            // FCategoria_Cadastro
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 165);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FCategoria_Cadastro";
            this.Text = "Cadastro Categoria";
            this.Load += new System.EventHandler(this.FCategoria_Cadastro_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cse_TempoMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cse_TempoMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Classificacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Gravidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Departamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Departamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CButtonEdit cbe_Departamento;
        private Componentes.CLabelControl clc_Marca;
        private Componentes.CTextEdit cte_DS_Departamento;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CTextEdit cte_Descricao;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CLabelControl cLabelControl2;
        private Componentes.CLabelControl cLabelControl1;
        private Componentes.CLabelControl cLc_Classificacao;
        private Componentes.CTextEdit cte_Classificacao;
        private Componentes.CComboBoxEdit ccbe_Gravidade;
        private Componentes.CLabelControl clc_Gravidade;
        private Componentes.CSpinEdit cse_TempoMax;
        private Componentes.CSpinEdit cse_TempoMin;
    }
}