namespace Aplicativo.Lancamentos
{
    partial class FAlocacaoRecurso_Lancamento
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
            this.cbe_Grupo = new Componentes.CButtonEdit(this.components);
            this.clc_Grupo = new Componentes.CLabelControl(this.components);
            this.cte_DS_Grupo = new Componentes.CTextEdit(this.components);
            this.cbe_Equipamento = new Componentes.CButtonEdit(this.components);
            this.clc_Equipamento = new Componentes.CLabelControl(this.components);
            this.cte_DS_Observacao = new Componentes.CTextEdit(this.components);
            this.cLabelControl1 = new Componentes.CLabelControl(this.components);
            this.cde_DT_FINAL_HMS = new Componentes.CDateEdit(this.components);
            this.cce_Status = new Componentes.CCheckEdit(this.components);
            this.cLabelControl5 = new Componentes.CLabelControl(this.components);
            this.cde_DT_INICIO_HMS = new Componentes.CDateEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.cte_Descricao = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Grupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Grupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Equipamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Observacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_FINAL_HMS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_FINAL_HMS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_INICIO_HMS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_INICIO_HMS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cbe_Grupo);
            this.cpc_DadosGerais.Controls.Add(this.clc_Grupo);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Grupo);
            this.cpc_DadosGerais.Controls.Add(this.cbe_Equipamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_Equipamento);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Observacao);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl1);
            this.cpc_DadosGerais.Controls.Add(this.cde_DT_FINAL_HMS);
            this.cpc_DadosGerais.Controls.Add(this.cce_Status);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl5);
            this.cpc_DadosGerais.Controls.Add(this.cde_DT_INICIO_HMS);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cte_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(729, 127);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cbe_Grupo
            // 
            this.cbe_Grupo.Descricao = "o grupo";
            this.cbe_Grupo.EditValue = "";
            this.cbe_Grupo.Location = new System.Drawing.Point(11, 96);
            this.cbe_Grupo.Name = "cbe_Grupo";
            this.cbe_Grupo.NaoVazio = true;
            this.cbe_Grupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Grupo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Grupo.Properties.MaxLength = 9;
            this.cbe_Grupo.SemAcentuacao = false;
            this.cbe_Grupo.SemPontuacao = false;
            this.cbe_Grupo.Size = new System.Drawing.Size(99, 20);
            this.cbe_Grupo.SomenteNumeros = true;
            this.cbe_Grupo.TabIndex = 13;
            this.cbe_Grupo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Grupo_ButtonClick);
            this.cbe_Grupo.Leave += new System.EventHandler(this.cbe_Grupo_Leave);
            // 
            // clc_Grupo
            // 
            this.clc_Grupo.Location = new System.Drawing.Point(12, 82);
            this.clc_Grupo.Name = "clc_Grupo";
            this.clc_Grupo.Size = new System.Drawing.Size(29, 13);
            this.clc_Grupo.TabIndex = 12;
            this.clc_Grupo.Text = "Grupo";
            // 
            // cte_DS_Grupo
            // 
            this.cte_DS_Grupo.Descricao = null;
            this.cte_DS_Grupo.Location = new System.Drawing.Point(113, 96);
            this.cte_DS_Grupo.Mascara_IPv4 = false;
            this.cte_DS_Grupo.Mascara_PortaIPv4 = false;
            this.cte_DS_Grupo.Name = "cte_DS_Grupo";
            this.cte_DS_Grupo.NaoVazio = false;
            this.cte_DS_Grupo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Grupo.Properties.ReadOnly = true;
            this.cte_DS_Grupo.SemAcentuacao = false;
            this.cte_DS_Grupo.SemPontuacao = false;
            this.cte_DS_Grupo.Size = new System.Drawing.Size(313, 20);
            this.cte_DS_Grupo.SomenteNumeros = false;
            this.cte_DS_Grupo.TabIndex = 14;
            // 
            // cbe_Equipamento
            // 
            this.cbe_Equipamento.Descricao = "o equipamento";
            this.cbe_Equipamento.EditValue = "";
            this.cbe_Equipamento.Location = new System.Drawing.Point(10, 59);
            this.cbe_Equipamento.Name = "cbe_Equipamento";
            this.cbe_Equipamento.NaoVazio = true;
            this.cbe_Equipamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Equipamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Equipamento.Properties.MaxLength = 9;
            this.cbe_Equipamento.SemAcentuacao = false;
            this.cbe_Equipamento.SemPontuacao = false;
            this.cbe_Equipamento.Size = new System.Drawing.Size(100, 20);
            this.cbe_Equipamento.SomenteNumeros = true;
            this.cbe_Equipamento.TabIndex = 6;
            this.cbe_Equipamento.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Equipamento_ButtonClick);
            this.cbe_Equipamento.Leave += new System.EventHandler(this.cbe_Equipamento_Leave);
            // 
            // clc_Equipamento
            // 
            this.clc_Equipamento.Location = new System.Drawing.Point(11, 45);
            this.clc_Equipamento.Name = "clc_Equipamento";
            this.clc_Equipamento.Size = new System.Drawing.Size(62, 13);
            this.clc_Equipamento.TabIndex = 5;
            this.clc_Equipamento.Text = "Equipamento";
            // 
            // cte_DS_Observacao
            // 
            this.cte_DS_Observacao.Descricao = null;
            this.cte_DS_Observacao.Location = new System.Drawing.Point(113, 59);
            this.cte_DS_Observacao.Mascara_IPv4 = false;
            this.cte_DS_Observacao.Mascara_PortaIPv4 = false;
            this.cte_DS_Observacao.Name = "cte_DS_Observacao";
            this.cte_DS_Observacao.NaoVazio = false;
            this.cte_DS_Observacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Observacao.Properties.ReadOnly = true;
            this.cte_DS_Observacao.SemAcentuacao = false;
            this.cte_DS_Observacao.SemPontuacao = false;
            this.cte_DS_Observacao.Size = new System.Drawing.Size(604, 20);
            this.cte_DS_Observacao.SomenteNumeros = false;
            this.cte_DS_Observacao.TabIndex = 7;
            // 
            // cLabelControl1
            // 
            this.cLabelControl1.Location = new System.Drawing.Point(572, 82);
            this.cLabelControl1.Name = "cLabelControl1";
            this.cLabelControl1.Size = new System.Drawing.Size(111, 13);
            this.cLabelControl1.TabIndex = 17;
            this.cLabelControl1.Text = "Data/Hora/Minuto Final";
            // 
            // cde_DT_FINAL_HMS
            // 
            this.cde_DT_FINAL_HMS.DataMaxima = new System.DateTime(2099, 12, 31, 23, 59, 0, 0);
            this.cde_DT_FINAL_HMS.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_FINAL_HMS.Descricao = "data final";
            this.cde_DT_FINAL_HMS.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_FINAL_HMS.Location = new System.Drawing.Point(572, 96);
            this.cde_DT_FINAL_HMS.Name = "cde_DT_FINAL_HMS";
            this.cde_DT_FINAL_HMS.NaoVazio = true;
            this.cde_DT_FINAL_HMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_FINAL_HMS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_FINAL_HMS.Properties.DisplayFormat.FormatString = "g";
            this.cde_DT_FINAL_HMS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cde_DT_FINAL_HMS.Properties.EditFormat.FormatString = "g";
            this.cde_DT_FINAL_HMS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cde_DT_FINAL_HMS.Properties.Mask.EditMask = "g";
            this.cde_DT_FINAL_HMS.Size = new System.Drawing.Size(145, 20);
            this.cde_DT_FINAL_HMS.TabIndex = 18;
            // 
            // cce_Status
            // 
            this.cce_Status.EditValue = true;
            this.cce_Status.Location = new System.Drawing.Point(670, 22);
            this.cce_Status.Name = "cce_Status";
            this.cce_Status.Properties.AutoWidth = true;
            this.cce_Status.Properties.Caption = "Ativo";
            this.cce_Status.Size = new System.Drawing.Size(47, 19);
            this.cce_Status.TabIndex = 4;
            // 
            // cLabelControl5
            // 
            this.cLabelControl5.Location = new System.Drawing.Point(432, 82);
            this.cLabelControl5.Name = "cLabelControl5";
            this.cLabelControl5.Size = new System.Drawing.Size(114, 13);
            this.cLabelControl5.TabIndex = 15;
            this.cLabelControl5.Text = "Data/Hora/Minuto Inicio";
            // 
            // cde_DT_INICIO_HMS
            // 
            this.cde_DT_INICIO_HMS.DataMaxima = new System.DateTime(2099, 12, 31, 23, 59, 59, 0);
            this.cde_DT_INICIO_HMS.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_INICIO_HMS.Descricao = "data inicial";
            this.cde_DT_INICIO_HMS.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_INICIO_HMS.Location = new System.Drawing.Point(432, 96);
            this.cde_DT_INICIO_HMS.Name = "cde_DT_INICIO_HMS";
            this.cde_DT_INICIO_HMS.NaoVazio = true;
            this.cde_DT_INICIO_HMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_INICIO_HMS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_INICIO_HMS.Properties.DisplayFormat.FormatString = "g";
            this.cde_DT_INICIO_HMS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cde_DT_INICIO_HMS.Properties.EditFormat.FormatString = "g";
            this.cde_DT_INICIO_HMS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cde_DT_INICIO_HMS.Properties.Mask.EditMask = "g";
            this.cde_DT_INICIO_HMS.Size = new System.Drawing.Size(134, 20);
            this.cde_DT_INICIO_HMS.TabIndex = 16;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(113, 8);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 2;
            this.clc_Descricao.Text = "Descrição";
            // 
            // cte_Identificador
            // 
            this.cte_Identificador.Descricao = "identificador";
            this.cte_Identificador.Enabled = false;
            this.cte_Identificador.Location = new System.Drawing.Point(10, 22);
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
            this.cte_Descricao.Descricao = "descrição";
            this.cte_Descricao.Location = new System.Drawing.Point(113, 22);
            this.cte_Descricao.Mascara_IPv4 = false;
            this.cte_Descricao.Mascara_PortaIPv4 = false;
            this.cte_Descricao.Name = "cte_Descricao";
            this.cte_Descricao.NaoVazio = true;
            this.cte_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Descricao.Properties.MaxLength = 256;
            this.cte_Descricao.SemAcentuacao = false;
            this.cte_Descricao.SemPontuacao = false;
            this.cte_Descricao.Size = new System.Drawing.Size(551, 20);
            this.cte_Descricao.SomenteNumeros = false;
            this.cte_Descricao.TabIndex = 3;
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Location = new System.Drawing.Point(10, 8);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(61, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Identificador";
            // 
            // FAlocacaoRecurso_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 161);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FAlocacaoRecurso_Lancamento";
            this.Text = "Lançamento - Alocação de recurso";
            this.Load += new System.EventHandler(this.FAlocacaoRecurso_Lancamento_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Grupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Grupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Equipamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Observacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_FINAL_HMS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_FINAL_HMS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_INICIO_HMS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_INICIO_HMS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Descricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CTextEdit cte_Descricao;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CCheckEdit cce_Status;
        private Componentes.CLabelControl cLabelControl5;
        private Componentes.CDateEdit cde_DT_INICIO_HMS;
        private Componentes.CLabelControl cLabelControl1;
        private Componentes.CDateEdit cde_DT_FINAL_HMS;
        private Componentes.CButtonEdit cbe_Equipamento;
        private Componentes.CLabelControl clc_Equipamento;
        private Componentes.CTextEdit cte_DS_Observacao;
        private Componentes.CButtonEdit cbe_Grupo;
        private Componentes.CLabelControl clc_Grupo;
        private Componentes.CTextEdit cte_DS_Grupo;
    }
}