namespace Aplicativo.Lancamentos
{
    partial class FAtendimento_Lancamento
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
            this.cLabelControl1 = new Componentes.CLabelControl(this.components);
            this.ccbe_NovaCategoria = new Componentes.CComboBoxEdit(this.components);
            this.cgc_DetalhesAtendimento = new Componentes.CGroupControl(this.components);
            this.cpc_DetalhesAtendimento = new Componentes.CPanelControl(this.components);
            this.cbce_ProximoStatus = new Componentes.CComboBoxEdit(this.components);
            this.clc_ProximoStatus = new Componentes.CLabelControl(this.components);
            this.ccbe_Prioridade = new Componentes.CComboBoxEdit(this.components);
            this.cme_Observacao = new Componentes.CMemoEdit(this.components);
            this.clc_Observacao = new Componentes.CLabelControl(this.components);
            this.clc_Prioridade = new Componentes.CLabelControl(this.components);
            this.clc_DT_Prevista = new Componentes.CLabelControl(this.components);
            this.cde_DT_Prevista = new Componentes.CDateEdit(this.components);
            this.cme_Descricao = new Componentes.CMemoEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.cte_Categoria = new Componentes.CTextEdit(this.components);
            this.cte_Departamento = new Componentes.CTextEdit(this.components);
            this.clc_Departamento = new Componentes.CLabelControl(this.components);
            this.cte_Solicitante = new Componentes.CTextEdit(this.components);
            this.clc_Solicitante = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            this.cde_DT_Chamado = new Componentes.CDateEdit(this.components);
            this.clc_DT_Chamado = new Componentes.CLabelControl(this.components);
            this.clc_Categoria = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_NovaCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_DetalhesAtendimento)).BeginInit();
            this.cgc_DetalhesAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DetalhesAtendimento)).BeginInit();
            this.cpc_DetalhesAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbce_ProximoStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Prioridade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Observacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Prevista.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Prevista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Departamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Solicitante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Chamado.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Chamado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.Appearance.Options.UseTextOptions = true;
            this.cpc_DadosGerais.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl1);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_NovaCategoria);
            this.cpc_DadosGerais.Controls.Add(this.cgc_DetalhesAtendimento);
            this.cpc_DadosGerais.Controls.Add(this.cme_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cte_Categoria);
            this.cpc_DadosGerais.Controls.Add(this.cte_Departamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_Departamento);
            this.cpc_DadosGerais.Controls.Add(this.cte_Solicitante);
            this.cpc_DadosGerais.Controls.Add(this.clc_Solicitante);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cde_DT_Chamado);
            this.cpc_DadosGerais.Controls.Add(this.clc_DT_Chamado);
            this.cpc_DadosGerais.Controls.Add(this.clc_Categoria);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(734, 383);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cLabelControl1
            // 
            this.cLabelControl1.Location = new System.Drawing.Point(12, 85);
            this.cLabelControl1.Name = "cLabelControl1";
            this.cLabelControl1.Size = new System.Drawing.Size(74, 13);
            this.cLabelControl1.TabIndex = 10;
            this.cLabelControl1.Text = "Categoria nova";
            // 
            // ccbe_NovaCategoria
            // 
            this.ccbe_NovaCategoria.Descricao = null;
            this.ccbe_NovaCategoria.Location = new System.Drawing.Point(12, 99);
            this.ccbe_NovaCategoria.Name = "ccbe_NovaCategoria";
            this.ccbe_NovaCategoria.NaoVazio = false;
            this.ccbe_NovaCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_NovaCategoria.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_NovaCategoria.SemAcentuacao = false;
            this.ccbe_NovaCategoria.SemPontuacao = false;
            this.ccbe_NovaCategoria.Size = new System.Drawing.Size(710, 20);
            this.ccbe_NovaCategoria.SomenteNumeros = false;
            this.ccbe_NovaCategoria.TabIndex = 11;
            // 
            // cgc_DetalhesAtendimento
            // 
            this.cgc_DetalhesAtendimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cgc_DetalhesAtendimento.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cgc_DetalhesAtendimento.Appearance.Options.UseBackColor = true;
            this.cgc_DetalhesAtendimento.Appearance.Options.UseTextOptions = true;
            this.cgc_DetalhesAtendimento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_DetalhesAtendimento.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_DetalhesAtendimento.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_DetalhesAtendimento.Controls.Add(this.cpc_DetalhesAtendimento);
            this.cgc_DetalhesAtendimento.Location = new System.Drawing.Point(12, 215);
            this.cgc_DetalhesAtendimento.Name = "cgc_DetalhesAtendimento";
            this.cgc_DetalhesAtendimento.Size = new System.Drawing.Size(710, 155);
            this.cgc_DetalhesAtendimento.TabIndex = 14;
            this.cgc_DetalhesAtendimento.Text = "Detalhes do atendimento";
            // 
            // cpc_DetalhesAtendimento
            // 
            this.cpc_DetalhesAtendimento.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DetalhesAtendimento.Appearance.Options.UseBackColor = true;
            this.cpc_DetalhesAtendimento.Appearance.Options.UseTextOptions = true;
            this.cpc_DetalhesAtendimento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cpc_DetalhesAtendimento.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DetalhesAtendimento.Controls.Add(this.cbce_ProximoStatus);
            this.cpc_DetalhesAtendimento.Controls.Add(this.clc_ProximoStatus);
            this.cpc_DetalhesAtendimento.Controls.Add(this.ccbe_Prioridade);
            this.cpc_DetalhesAtendimento.Controls.Add(this.cme_Observacao);
            this.cpc_DetalhesAtendimento.Controls.Add(this.clc_Observacao);
            this.cpc_DetalhesAtendimento.Controls.Add(this.clc_Prioridade);
            this.cpc_DetalhesAtendimento.Controls.Add(this.clc_DT_Prevista);
            this.cpc_DetalhesAtendimento.Controls.Add(this.cde_DT_Prevista);
            this.cpc_DetalhesAtendimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DetalhesAtendimento.Location = new System.Drawing.Point(2, 21);
            this.cpc_DetalhesAtendimento.Name = "cpc_DetalhesAtendimento";
            this.cpc_DetalhesAtendimento.Size = new System.Drawing.Size(706, 132);
            this.cpc_DetalhesAtendimento.TabIndex = 0;
            // 
            // cbce_ProximoStatus
            // 
            this.cbce_ProximoStatus.Descricao = "o próximo status";
            this.cbce_ProximoStatus.Location = new System.Drawing.Point(235, 19);
            this.cbce_ProximoStatus.Name = "cbce_ProximoStatus";
            this.cbce_ProximoStatus.NaoVazio = true;
            this.cbce_ProximoStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbce_ProximoStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbce_ProximoStatus.SemAcentuacao = false;
            this.cbce_ProximoStatus.SemPontuacao = false;
            this.cbce_ProximoStatus.Size = new System.Drawing.Size(110, 20);
            this.cbce_ProximoStatus.SomenteNumeros = false;
            this.cbce_ProximoStatus.TabIndex = 5;
            // 
            // clc_ProximoStatus
            // 
            this.clc_ProximoStatus.Location = new System.Drawing.Point(235, 5);
            this.clc_ProximoStatus.Name = "clc_ProximoStatus";
            this.clc_ProximoStatus.Size = new System.Drawing.Size(71, 13);
            this.clc_ProximoStatus.TabIndex = 4;
            this.clc_ProximoStatus.Text = "Próximo status";
            // 
            // ccbe_Prioridade
            // 
            this.ccbe_Prioridade.Descricao = "a prioridade";
            this.ccbe_Prioridade.Location = new System.Drawing.Point(9, 19);
            this.ccbe_Prioridade.Name = "ccbe_Prioridade";
            this.ccbe_Prioridade.NaoVazio = true;
            this.ccbe_Prioridade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Prioridade.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Prioridade.SemAcentuacao = false;
            this.ccbe_Prioridade.SemPontuacao = false;
            this.ccbe_Prioridade.Size = new System.Drawing.Size(110, 20);
            this.ccbe_Prioridade.SomenteNumeros = false;
            this.ccbe_Prioridade.TabIndex = 1;
            // 
            // cme_Observacao
            // 
            this.cme_Observacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cme_Observacao.Descricao = "a observação";
            this.cme_Observacao.Location = new System.Drawing.Point(9, 57);
            this.cme_Observacao.Name = "cme_Observacao";
            this.cme_Observacao.NaoVazio = false;
            this.cme_Observacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Observacao.SemAcentuacao = false;
            this.cme_Observacao.SemPontuacao = false;
            this.cme_Observacao.Size = new System.Drawing.Size(689, 65);
            this.cme_Observacao.SomenteNumeros = false;
            this.cme_Observacao.TabIndex = 7;
            this.cme_Observacao.UseOptimizedRendering = true;
            // 
            // clc_Observacao
            // 
            this.clc_Observacao.Location = new System.Drawing.Point(9, 43);
            this.clc_Observacao.Name = "clc_Observacao";
            this.clc_Observacao.Size = new System.Drawing.Size(58, 13);
            this.clc_Observacao.TabIndex = 6;
            this.clc_Observacao.Text = "Observação";
            // 
            // clc_Prioridade
            // 
            this.clc_Prioridade.Location = new System.Drawing.Point(9, 5);
            this.clc_Prioridade.Name = "clc_Prioridade";
            this.clc_Prioridade.Size = new System.Drawing.Size(48, 13);
            this.clc_Prioridade.TabIndex = 0;
            this.clc_Prioridade.Text = "Prioridade";
            // 
            // clc_DT_Prevista
            // 
            this.clc_DT_Prevista.Location = new System.Drawing.Point(122, 5);
            this.clc_DT_Prevista.Name = "clc_DT_Prevista";
            this.clc_DT_Prevista.Size = new System.Drawing.Size(65, 13);
            this.clc_DT_Prevista.TabIndex = 2;
            this.clc_DT_Prevista.Text = "Data prevista";
            // 
            // cde_DT_Prevista
            // 
            this.cde_DT_Prevista.DataMaxima = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.cde_DT_Prevista.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_Prevista.Descricao = "a data prevista";
            this.cde_DT_Prevista.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_Prevista.Location = new System.Drawing.Point(122, 19);
            this.cde_DT_Prevista.Name = "cde_DT_Prevista";
            this.cde_DT_Prevista.NaoVazio = true;
            this.cde_DT_Prevista.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_Prevista.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_Prevista.Properties.DisplayFormat.FormatString = "g";
            this.cde_DT_Prevista.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DT_Prevista.Properties.EditFormat.FormatString = "g";
            this.cde_DT_Prevista.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DT_Prevista.Properties.Mask.EditMask = "g";
            this.cde_DT_Prevista.Size = new System.Drawing.Size(110, 20);
            this.cde_DT_Prevista.TabIndex = 3;
            // 
            // cme_Descricao
            // 
            this.cme_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cme_Descricao.Descricao = "a descrição";
            this.cme_Descricao.Location = new System.Drawing.Point(12, 137);
            this.cme_Descricao.Name = "cme_Descricao";
            this.cme_Descricao.NaoVazio = false;
            this.cme_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Descricao.Properties.ReadOnly = true;
            this.cme_Descricao.SemAcentuacao = false;
            this.cme_Descricao.SemPontuacao = false;
            this.cme_Descricao.Size = new System.Drawing.Size(710, 72);
            this.cme_Descricao.SomenteNumeros = false;
            this.cme_Descricao.TabIndex = 13;
            this.cme_Descricao.UseOptimizedRendering = true;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(12, 123);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 12;
            this.clc_Descricao.Text = "Descrição";
            // 
            // cte_Categoria
            // 
            this.cte_Categoria.Descricao = "a categoria";
            this.cte_Categoria.Location = new System.Drawing.Point(228, 61);
            this.cte_Categoria.Mascara_IPv4 = false;
            this.cte_Categoria.Mascara_PortaIPv4 = false;
            this.cte_Categoria.Name = "cte_Categoria";
            this.cte_Categoria.NaoVazio = false;
            this.cte_Categoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Categoria.Properties.ReadOnly = true;
            this.cte_Categoria.SemAcentuacao = false;
            this.cte_Categoria.SemPontuacao = false;
            this.cte_Categoria.Size = new System.Drawing.Size(494, 20);
            this.cte_Categoria.SomenteNumeros = false;
            this.cte_Categoria.TabIndex = 9;
            // 
            // cte_Departamento
            // 
            this.cte_Departamento.Descricao = "o departamento";
            this.cte_Departamento.Location = new System.Drawing.Point(12, 61);
            this.cte_Departamento.Mascara_IPv4 = false;
            this.cte_Departamento.Mascara_PortaIPv4 = false;
            this.cte_Departamento.Name = "cte_Departamento";
            this.cte_Departamento.NaoVazio = false;
            this.cte_Departamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Departamento.Properties.ReadOnly = true;
            this.cte_Departamento.SemAcentuacao = false;
            this.cte_Departamento.SemPontuacao = false;
            this.cte_Departamento.Size = new System.Drawing.Size(213, 20);
            this.cte_Departamento.SomenteNumeros = false;
            this.cte_Departamento.TabIndex = 7;
            // 
            // clc_Departamento
            // 
            this.clc_Departamento.Location = new System.Drawing.Point(12, 47);
            this.clc_Departamento.Name = "clc_Departamento";
            this.clc_Departamento.Size = new System.Drawing.Size(69, 13);
            this.clc_Departamento.TabIndex = 6;
            this.clc_Departamento.Text = "Departamento";
            // 
            // cte_Solicitante
            // 
            this.cte_Solicitante.Descricao = "o solicitante";
            this.cte_Solicitante.Location = new System.Drawing.Point(228, 23);
            this.cte_Solicitante.Mascara_IPv4 = false;
            this.cte_Solicitante.Mascara_PortaIPv4 = false;
            this.cte_Solicitante.Name = "cte_Solicitante";
            this.cte_Solicitante.NaoVazio = false;
            this.cte_Solicitante.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Solicitante.Properties.ReadOnly = true;
            this.cte_Solicitante.SemAcentuacao = false;
            this.cte_Solicitante.SemPontuacao = false;
            this.cte_Solicitante.Size = new System.Drawing.Size(494, 20);
            this.cte_Solicitante.SomenteNumeros = false;
            this.cte_Solicitante.TabIndex = 5;
            // 
            // clc_Solicitante
            // 
            this.clc_Solicitante.Location = new System.Drawing.Point(228, 9);
            this.clc_Solicitante.Name = "clc_Solicitante";
            this.clc_Solicitante.Size = new System.Drawing.Size(49, 13);
            this.clc_Solicitante.TabIndex = 4;
            this.clc_Solicitante.Text = "Solicitante";
            // 
            // cte_Identificador
            // 
            this.cte_Identificador.Descricao = "o identificador do chamado";
            this.cte_Identificador.Location = new System.Drawing.Point(12, 23);
            this.cte_Identificador.Mascara_IPv4 = false;
            this.cte_Identificador.Mascara_PortaIPv4 = false;
            this.cte_Identificador.Name = "cte_Identificador";
            this.cte_Identificador.NaoVazio = false;
            this.cte_Identificador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Identificador.Properties.MaxLength = 20;
            this.cte_Identificador.Properties.ReadOnly = true;
            this.cte_Identificador.SemAcentuacao = false;
            this.cte_Identificador.SemPontuacao = false;
            this.cte_Identificador.Size = new System.Drawing.Size(100, 20);
            this.cte_Identificador.SomenteNumeros = true;
            this.cte_Identificador.TabIndex = 1;
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Location = new System.Drawing.Point(12, 9);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(45, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Chamado";
            // 
            // cde_DT_Chamado
            // 
            this.cde_DT_Chamado.DataMaxima = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.cde_DT_Chamado.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_Chamado.Descricao = "a data do chamado";
            this.cde_DT_Chamado.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_Chamado.Location = new System.Drawing.Point(115, 23);
            this.cde_DT_Chamado.Name = "cde_DT_Chamado";
            this.cde_DT_Chamado.NaoVazio = false;
            this.cde_DT_Chamado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_Chamado.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_Chamado.Properties.DisplayFormat.FormatString = "g";
            this.cde_DT_Chamado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DT_Chamado.Properties.EditFormat.FormatString = "g";
            this.cde_DT_Chamado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DT_Chamado.Properties.Mask.EditMask = "g";
            this.cde_DT_Chamado.Properties.ReadOnly = true;
            this.cde_DT_Chamado.Size = new System.Drawing.Size(110, 20);
            this.cde_DT_Chamado.TabIndex = 3;
            // 
            // clc_DT_Chamado
            // 
            this.clc_DT_Chamado.Location = new System.Drawing.Point(115, 9);
            this.clc_DT_Chamado.Name = "clc_DT_Chamado";
            this.clc_DT_Chamado.Size = new System.Drawing.Size(84, 13);
            this.clc_DT_Chamado.TabIndex = 2;
            this.clc_DT_Chamado.Text = "Data do chamado";
            // 
            // clc_Categoria
            // 
            this.clc_Categoria.Location = new System.Drawing.Point(228, 47);
            this.clc_Categoria.Name = "clc_Categoria";
            this.clc_Categoria.Size = new System.Drawing.Size(47, 13);
            this.clc_Categoria.TabIndex = 8;
            this.clc_Categoria.Text = "Categoria";
            // 
            // FAtendimento_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 417);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FAtendimento_Lancamento";
            this.Text = "Atendimento de chamado";
            this.Load += new System.EventHandler(this.FAtendimentoChamado_Lancamento_Load);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_NovaCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_DetalhesAtendimento)).EndInit();
            this.cgc_DetalhesAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DetalhesAtendimento)).EndInit();
            this.cpc_DetalhesAtendimento.ResumeLayout(false);
            this.cpc_DetalhesAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbce_ProximoStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Prioridade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Observacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Prevista.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Prevista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Departamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Solicitante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Chamado.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Chamado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CDateEdit cde_DT_Chamado;
        private Componentes.CLabelControl clc_DT_Chamado;
        private Componentes.CLabelControl clc_Categoria;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CDateEdit cde_DT_Prevista;
        private Componentes.CLabelControl clc_DT_Prevista;
        private Componentes.CComboBoxEdit ccbe_Prioridade;
        private Componentes.CLabelControl clc_Prioridade;
        private Componentes.CTextEdit cte_Solicitante;
        private Componentes.CLabelControl clc_Solicitante;
        private Componentes.CTextEdit cte_Categoria;
        private Componentes.CTextEdit cte_Departamento;
        private Componentes.CLabelControl clc_Departamento;
        private Componentes.CMemoEdit cme_Descricao;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CMemoEdit cme_Observacao;
        private Componentes.CLabelControl clc_Observacao;
        private Componentes.CGroupControl cgc_DetalhesAtendimento;
        private Componentes.CPanelControl cpc_DetalhesAtendimento;
        private Componentes.CComboBoxEdit cbce_ProximoStatus;
        private Componentes.CLabelControl clc_ProximoStatus;
        private Componentes.CLabelControl cLabelControl1;
        private Componentes.CComboBoxEdit ccbe_NovaCategoria;
    }
}
