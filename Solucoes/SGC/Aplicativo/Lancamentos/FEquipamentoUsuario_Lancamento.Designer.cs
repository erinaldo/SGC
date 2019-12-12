namespace Aplicativo.Lancamentos
{
    partial class FEquipamentoUsuario_Lancamento
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
            this.cce_Ativo = new Componentes.CCheckEdit(this.components);
            this.cce_UsoCompartilhado = new Componentes.CCheckEdit(this.components);
            this.cbe_Equipamento = new Componentes.CButtonEdit(this.components);
            this.clc_Cargo = new Componentes.CLabelControl(this.components);
            this.cte_DS_Observacao = new Componentes.CTextEdit(this.components);
            this.cbe_Usuario = new Componentes.CButtonEdit(this.components);
            this.clc_Usuario = new Componentes.CLabelControl(this.components);
            this.cte_NM_Usuario = new Componentes.CTextEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Descricao = new Componentes.CTextEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Ativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_UsoCompartilhado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Equipamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Observacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_NM_Usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cce_Ativo);
            this.cpc_DadosGerais.Controls.Add(this.cce_UsoCompartilhado);
            this.cpc_DadosGerais.Controls.Add(this.cbe_Equipamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_Cargo);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Observacao);
            this.cpc_DadosGerais.Controls.Add(this.cbe_Usuario);
            this.cpc_DadosGerais.Controls.Add(this.clc_Usuario);
            this.cpc_DadosGerais.Controls.Add(this.cte_NM_Usuario);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Descricao);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(741, 128);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cce_Ativo
            // 
            this.cce_Ativo.EditValue = true;
            this.cce_Ativo.Location = new System.Drawing.Point(564, 98);
            this.cce_Ativo.Name = "cce_Ativo";
            this.cce_Ativo.Properties.AutoWidth = true;
            this.cce_Ativo.Properties.Caption = "Ativo";
            this.cce_Ativo.Size = new System.Drawing.Size(47, 19);
            this.cce_Ativo.TabIndex = 8;
            // 
            // cce_UsoCompartilhado
            // 
            this.cce_UsoCompartilhado.Location = new System.Drawing.Point(617, 97);
            this.cce_UsoCompartilhado.Name = "cce_UsoCompartilhado";
            this.cce_UsoCompartilhado.Properties.AutoWidth = true;
            this.cce_UsoCompartilhado.Properties.Caption = "Uso Compartilhado";
            this.cce_UsoCompartilhado.Size = new System.Drawing.Size(112, 19);
            this.cce_UsoCompartilhado.TabIndex = 9;
            // 
            // cbe_Equipamento
            // 
            this.cbe_Equipamento.Descricao = "o equipamento";
            this.cbe_Equipamento.EditValue = "";
            this.cbe_Equipamento.Location = new System.Drawing.Point(12, 23);
            this.cbe_Equipamento.Name = "cbe_Equipamento";
            this.cbe_Equipamento.NaoVazio = false;
            this.cbe_Equipamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Equipamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Equipamento.Properties.MaxLength = 9;
            this.cbe_Equipamento.SemAcentuacao = false;
            this.cbe_Equipamento.SemPontuacao = false;
            this.cbe_Equipamento.Size = new System.Drawing.Size(100, 20);
            this.cbe_Equipamento.SomenteNumeros = true;
            this.cbe_Equipamento.TabIndex = 1;
            this.cbe_Equipamento.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Departamento_ButtonClick);
            this.cbe_Equipamento.Leave += new System.EventHandler(this.cbe_Equipamento_Leave);
            // 
            // clc_Cargo
            // 
            this.clc_Cargo.Location = new System.Drawing.Point(12, 9);
            this.clc_Cargo.Name = "clc_Cargo";
            this.clc_Cargo.Size = new System.Drawing.Size(62, 13);
            this.clc_Cargo.TabIndex = 0;
            this.clc_Cargo.Text = "Equipamento";
            // 
            // cte_DS_Observacao
            // 
            this.cte_DS_Observacao.Descricao = null;
            this.cte_DS_Observacao.Location = new System.Drawing.Point(115, 23);
            this.cte_DS_Observacao.Mascara_IPv4 = false;
            this.cte_DS_Observacao.Mascara_PortaIPv4 = false;
            this.cte_DS_Observacao.Name = "cte_DS_Observacao";
            this.cte_DS_Observacao.NaoVazio = false;
            this.cte_DS_Observacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Observacao.Properties.ReadOnly = true;
            this.cte_DS_Observacao.SemAcentuacao = false;
            this.cte_DS_Observacao.SemPontuacao = false;
            this.cte_DS_Observacao.Size = new System.Drawing.Size(614, 20);
            this.cte_DS_Observacao.SomenteNumeros = false;
            this.cte_DS_Observacao.TabIndex = 2;
            // 
            // cbe_Usuario
            // 
            this.cbe_Usuario.Descricao = "o usuário";
            this.cbe_Usuario.EditValue = "";
            this.cbe_Usuario.Location = new System.Drawing.Point(12, 60);
            this.cbe_Usuario.Name = "cbe_Usuario";
            this.cbe_Usuario.NaoVazio = false;
            this.cbe_Usuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Usuario.Properties.MaxLength = 9;
            this.cbe_Usuario.SemAcentuacao = false;
            this.cbe_Usuario.SemPontuacao = false;
            this.cbe_Usuario.Size = new System.Drawing.Size(100, 20);
            this.cbe_Usuario.SomenteNumeros = true;
            this.cbe_Usuario.TabIndex = 4;
            this.cbe_Usuario.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Usuario_ButtonClick);
            this.cbe_Usuario.Leave += new System.EventHandler(this.cbe_Usuario_Leave);
            // 
            // clc_Usuario
            // 
            this.clc_Usuario.Location = new System.Drawing.Point(12, 46);
            this.clc_Usuario.Name = "clc_Usuario";
            this.clc_Usuario.Size = new System.Drawing.Size(36, 13);
            this.clc_Usuario.TabIndex = 3;
            this.clc_Usuario.Text = "Usuário";
            // 
            // cte_NM_Usuario
            // 
            this.cte_NM_Usuario.Descricao = null;
            this.cte_NM_Usuario.Location = new System.Drawing.Point(115, 60);
            this.cte_NM_Usuario.Mascara_IPv4 = false;
            this.cte_NM_Usuario.Mascara_PortaIPv4 = false;
            this.cte_NM_Usuario.Name = "cte_NM_Usuario";
            this.cte_NM_Usuario.NaoVazio = false;
            this.cte_NM_Usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_NM_Usuario.Properties.ReadOnly = true;
            this.cte_NM_Usuario.SemAcentuacao = false;
            this.cte_NM_Usuario.SemPontuacao = false;
            this.cte_NM_Usuario.Size = new System.Drawing.Size(614, 20);
            this.cte_NM_Usuario.SomenteNumeros = false;
            this.cte_NM_Usuario.TabIndex = 5;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(12, 83);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(58, 13);
            this.clc_Descricao.TabIndex = 6;
            this.clc_Descricao.Text = "Observação";
            // 
            // cte_Descricao
            // 
            this.cte_Descricao.Descricao = "a observação";
            this.cte_Descricao.Location = new System.Drawing.Point(12, 97);
            this.cte_Descricao.Mascara_IPv4 = false;
            this.cte_Descricao.Mascara_PortaIPv4 = false;
            this.cte_Descricao.Name = "cte_Descricao";
            this.cte_Descricao.NaoVazio = true;
            this.cte_Descricao.Properties.MaxLength = 256;
            this.cte_Descricao.SemAcentuacao = false;
            this.cte_Descricao.SemPontuacao = false;
            this.cte_Descricao.Size = new System.Drawing.Size(546, 20);
            this.cte_Descricao.SomenteNumeros = false;
            this.cte_Descricao.TabIndex = 7;
            // 
            // FEquipamentoUsuario_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 162);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FEquipamentoUsuario_Lancamento";
            this.Text = "Lançamento - Equipamento x Usuário";
            this.Load += new System.EventHandler(this.FEquipamentoUsuario_Lancamento_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Ativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_UsoCompartilhado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Equipamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Observacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_NM_Usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CTextEdit cte_Descricao;
        private Componentes.CButtonEdit cbe_Equipamento;
        private Componentes.CLabelControl clc_Cargo;
        private Componentes.CTextEdit cte_DS_Observacao;
        private Componentes.CButtonEdit cbe_Usuario;
        private Componentes.CLabelControl clc_Usuario;
        private Componentes.CTextEdit cte_NM_Usuario;
        private Componentes.CCheckEdit cce_Ativo;
        private Componentes.CCheckEdit cce_UsoCompartilhado;
    }
}