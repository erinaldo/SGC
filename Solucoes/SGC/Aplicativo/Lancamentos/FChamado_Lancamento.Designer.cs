namespace Aplicativo.Lancamentos
{
    partial class FChamado_Lancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChamado_Lancamento));
            this.cpc_DadosGerais = new Componentes.CPanelControl(this.components);
            this.cte_Resumo = new Componentes.CTextEdit(this.components);
            this.cLabelControl1 = new Componentes.CLabelControl(this.components);
            this.cde_DT_Requerida = new Componentes.CDateEdit(this.components);
            this.cgc_Anexos = new Componentes.CGroupControl(this.components);
            this.lbc_Anexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_Anexos = new System.Windows.Forms.BindingSource(this.components);
            this.cpc_Anexos = new Componentes.CPanelControl(this.components);
            this.csb_AdicionarAnexo = new Componentes.Menu.Adicionar_x16(this.components);
            this.csb_DeletarAnexo = new Componentes.Menu.Deletar_x16(this.components);
            this.clc_DT_Requerido = new Componentes.CLabelControl(this.components);
            this.cme_Descricao = new Componentes.CMemoEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.ccbe_Departamento = new Componentes.CComboBoxEdit(this.components);
            this.clc_Departamento = new Componentes.CLabelControl(this.components);
            this.ccbe_Categoria = new Componentes.CComboBoxEdit(this.components);
            this.clc_Categoria = new Componentes.CLabelControl(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.ccbe_Atendente = new Componentes.CComboBoxEdit(this.components);
            this.clc_Atendente = new Componentes.CLabelControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Resumo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Requerida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Requerida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).BeginInit();
            this.cgc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).BeginInit();
            this.cpc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Departamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Atendente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Atendente);
            this.cpc_DadosGerais.Controls.Add(this.clc_Atendente);
            this.cpc_DadosGerais.Controls.Add(this.cte_Resumo);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl1);
            this.cpc_DadosGerais.Controls.Add(this.cde_DT_Requerida);
            this.cpc_DadosGerais.Controls.Add(this.cgc_Anexos);
            this.cpc_DadosGerais.Controls.Add(this.clc_DT_Requerido);
            this.cpc_DadosGerais.Controls.Add(this.cme_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Departamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_Departamento);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Categoria);
            this.cpc_DadosGerais.Controls.Add(this.clc_Categoria);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(734, 377);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // cte_Resumo
            // 
            this.cte_Resumo.Descricao = "o resumo";
            this.cte_Resumo.Location = new System.Drawing.Point(12, 102);
            this.cte_Resumo.Mascara_IPv4 = false;
            this.cte_Resumo.Mascara_PortaIPv4 = false;
            this.cte_Resumo.Name = "cte_Resumo";
            this.cte_Resumo.NaoVazio = true;
            this.cte_Resumo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Resumo.Properties.MaxLength = 100;
            this.cte_Resumo.SemAcentuacao = false;
            this.cte_Resumo.SemPontuacao = false;
            this.cte_Resumo.Size = new System.Drawing.Size(710, 20);
            this.cte_Resumo.SomenteNumeros = false;
            this.cte_Resumo.TabIndex = 7;
            // 
            // cLabelControl1
            // 
            this.cLabelControl1.Location = new System.Drawing.Point(12, 88);
            this.cLabelControl1.Name = "cLabelControl1";
            this.cLabelControl1.Size = new System.Drawing.Size(38, 13);
            this.cLabelControl1.TabIndex = 6;
            this.cLabelControl1.Text = "Resumo";
            // 
            // cde_DT_Requerida
            // 
            this.cde_DT_Requerida.DataMaxima = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.cde_DT_Requerida.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_Requerida.Descricao = "a data requerida";
            this.cde_DT_Requerida.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DT_Requerida.Enabled = false;
            this.cde_DT_Requerida.Location = new System.Drawing.Point(602, 26);
            this.cde_DT_Requerida.Name = "cde_DT_Requerida";
            this.cde_DT_Requerida.NaoVazio = false;
            this.cde_DT_Requerida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_Requerida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DT_Requerida.Properties.DisplayFormat.FormatString = "g";
            this.cde_DT_Requerida.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DT_Requerida.Properties.EditFormat.FormatString = "g";
            this.cde_DT_Requerida.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DT_Requerida.Properties.Mask.EditMask = "g";
            this.cde_DT_Requerida.Size = new System.Drawing.Size(120, 20);
            this.cde_DT_Requerida.TabIndex = 5;
            // 
            // cgc_Anexos
            // 
            this.cgc_Anexos.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cgc_Anexos.Appearance.Options.UseBackColor = true;
            this.cgc_Anexos.Appearance.Options.UseTextOptions = true;
            this.cgc_Anexos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_Anexos.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_Anexos.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_Anexos.Controls.Add(this.lbc_Anexos);
            this.cgc_Anexos.Controls.Add(this.cpc_Anexos);
            this.cgc_Anexos.Location = new System.Drawing.Point(12, 240);
            this.cgc_Anexos.Name = "cgc_Anexos";
            this.cgc_Anexos.Size = new System.Drawing.Size(710, 125);
            this.cgc_Anexos.TabIndex = 10;
            this.cgc_Anexos.Text = "Anexos";
            // 
            // lbc_Anexos
            // 
            this.lbc_Anexos.DataSource = this.bs_Anexos;
            this.lbc_Anexos.DisplayMember = "NM_ANEXO";
            this.lbc_Anexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_Anexos.Location = new System.Drawing.Point(2, 53);
            this.lbc_Anexos.Name = "lbc_Anexos";
            this.lbc_Anexos.Size = new System.Drawing.Size(706, 70);
            this.lbc_Anexos.TabIndex = 1;
            this.lbc_Anexos.ValueMember = "ID_ANEXO";
            this.lbc_Anexos.DoubleClick += new System.EventHandler(this.lbc_Anexos_DoubleClick);
            // 
            // bs_Anexos
            // 
            this.bs_Anexos.DataSource = typeof(Entidades.E_ANEXO);
            // 
            // cpc_Anexos
            // 
            this.cpc_Anexos.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cpc_Anexos.Appearance.Options.UseBackColor = true;
            this.cpc_Anexos.Appearance.Options.UseTextOptions = true;
            this.cpc_Anexos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cpc_Anexos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Anexos.Controls.Add(this.csb_AdicionarAnexo);
            this.cpc_Anexos.Controls.Add(this.csb_DeletarAnexo);
            this.cpc_Anexos.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpc_Anexos.Location = new System.Drawing.Point(2, 21);
            this.cpc_Anexos.Name = "cpc_Anexos";
            this.cpc_Anexos.Size = new System.Drawing.Size(706, 32);
            this.cpc_Anexos.TabIndex = 0;
            // 
            // csb_AdicionarAnexo
            // 
            this.csb_AdicionarAnexo.AllowFocus = false;
            this.csb_AdicionarAnexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.csb_AdicionarAnexo.Appearance.Options.UseTextOptions = true;
            this.csb_AdicionarAnexo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_AdicionarAnexo.Image = ((System.Drawing.Image)(resources.GetObject("csb_AdicionarAnexo.Image")));
            this.csb_AdicionarAnexo.Location = new System.Drawing.Point(4, 4);
            this.csb_AdicionarAnexo.Name = "csb_AdicionarAnexo";
            this.csb_AdicionarAnexo.Size = new System.Drawing.Size(93, 24);
            this.csb_AdicionarAnexo.TabIndex = 0;
            this.csb_AdicionarAnexo.Text = "(F5) Adicionar";
            this.csb_AdicionarAnexo.Click += new System.EventHandler(this.csb_AdicionarAnexo_Click);
            // 
            // csb_DeletarAnexo
            // 
            this.csb_DeletarAnexo.AllowFocus = false;
            this.csb_DeletarAnexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.csb_DeletarAnexo.Appearance.Options.UseTextOptions = true;
            this.csb_DeletarAnexo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_DeletarAnexo.Image = ((System.Drawing.Image)(resources.GetObject("csb_DeletarAnexo.Image")));
            this.csb_DeletarAnexo.Location = new System.Drawing.Point(100, 4);
            this.csb_DeletarAnexo.Name = "csb_DeletarAnexo";
            this.csb_DeletarAnexo.Size = new System.Drawing.Size(84, 24);
            this.csb_DeletarAnexo.TabIndex = 1;
            this.csb_DeletarAnexo.Text = "(F6) Deletar";
            this.csb_DeletarAnexo.Click += new System.EventHandler(this.csb_DeletarAnexo_Click);
            // 
            // clc_DT_Requerido
            // 
            this.clc_DT_Requerido.Location = new System.Drawing.Point(602, 12);
            this.clc_DT_Requerido.Name = "clc_DT_Requerido";
            this.clc_DT_Requerido.Size = new System.Drawing.Size(72, 13);
            this.clc_DT_Requerido.TabIndex = 4;
            this.clc_DT_Requerido.Text = "Data requerida";
            // 
            // cme_Descricao
            // 
            this.cme_Descricao.Descricao = "a descrição";
            this.cme_Descricao.Location = new System.Drawing.Point(12, 140);
            this.cme_Descricao.Name = "cme_Descricao";
            this.cme_Descricao.NaoVazio = true;
            this.cme_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Descricao.SemAcentuacao = false;
            this.cme_Descricao.SemPontuacao = false;
            this.cme_Descricao.Size = new System.Drawing.Size(710, 94);
            this.cme_Descricao.SomenteNumeros = false;
            this.cme_Descricao.TabIndex = 9;
            this.cme_Descricao.UseOptimizedRendering = true;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(12, 126);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 8;
            this.clc_Descricao.Text = "Descrição";
            // 
            // ccbe_Departamento
            // 
            this.ccbe_Departamento.Descricao = "o departamento";
            this.ccbe_Departamento.Location = new System.Drawing.Point(12, 26);
            this.ccbe_Departamento.Name = "ccbe_Departamento";
            this.ccbe_Departamento.NaoVazio = true;
            this.ccbe_Departamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Departamento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Departamento.SemAcentuacao = false;
            this.ccbe_Departamento.SemPontuacao = false;
            this.ccbe_Departamento.Size = new System.Drawing.Size(295, 20);
            this.ccbe_Departamento.SomenteNumeros = false;
            this.ccbe_Departamento.TabIndex = 1;
            this.ccbe_Departamento.SelectedIndexChanged += new System.EventHandler(this.ccbe_Departamento_SelectedIndexChanged);
            // 
            // clc_Departamento
            // 
            this.clc_Departamento.Location = new System.Drawing.Point(12, 12);
            this.clc_Departamento.Name = "clc_Departamento";
            this.clc_Departamento.Size = new System.Drawing.Size(69, 13);
            this.clc_Departamento.TabIndex = 0;
            this.clc_Departamento.Text = "Departamento";
            // 
            // ccbe_Categoria
            // 
            this.ccbe_Categoria.Descricao = "a categoria";
            this.ccbe_Categoria.Enabled = false;
            this.ccbe_Categoria.Location = new System.Drawing.Point(310, 26);
            this.ccbe_Categoria.Name = "ccbe_Categoria";
            this.ccbe_Categoria.NaoVazio = true;
            this.ccbe_Categoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Categoria.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Categoria.SemAcentuacao = false;
            this.ccbe_Categoria.SemPontuacao = false;
            this.ccbe_Categoria.Size = new System.Drawing.Size(289, 20);
            this.ccbe_Categoria.SomenteNumeros = false;
            this.ccbe_Categoria.TabIndex = 3;
            this.ccbe_Categoria.SelectedIndexChanged += new System.EventHandler(this.ccbe_Categoria_SelectedIndexChanged);
            // 
            // clc_Categoria
            // 
            this.clc_Categoria.Location = new System.Drawing.Point(310, 12);
            this.clc_Categoria.Name = "clc_Categoria";
            this.clc_Categoria.Size = new System.Drawing.Size(47, 13);
            this.clc_Categoria.TabIndex = 2;
            this.clc_Categoria.Text = "Categoria";
            // 
            // ofd
            // 
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecione o anexo desejado!";
            // 
            // ccbe_Atendente
            // 
            this.ccbe_Atendente.Descricao = "";
            this.ccbe_Atendente.Enabled = false;
            this.ccbe_Atendente.Location = new System.Drawing.Point(12, 64);
            this.ccbe_Atendente.Name = "ccbe_Atendente";
            this.ccbe_Atendente.NaoVazio = false;
            this.ccbe_Atendente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Atendente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Atendente.SemAcentuacao = false;
            this.ccbe_Atendente.SemPontuacao = false;
            this.ccbe_Atendente.Size = new System.Drawing.Size(710, 20);
            this.ccbe_Atendente.SomenteNumeros = false;
            this.ccbe_Atendente.TabIndex = 14;
            // 
            // clc_Atendente
            // 
            this.clc_Atendente.Location = new System.Drawing.Point(12, 50);
            this.clc_Atendente.Name = "clc_Atendente";
            this.clc_Atendente.Size = new System.Drawing.Size(51, 13);
            this.clc_Atendente.TabIndex = 13;
            this.clc_Atendente.Text = "Atendente";
            // 
            // FChamado_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FChamado_Lancamento";
            this.Text = "Lançamento de chamado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FChamado_Cadastro_FormClosing);
            this.Load += new System.EventHandler(this.FChamado_Cadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FChamado_Cadastro_KeyDown);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Resumo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Requerida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DT_Requerida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).EndInit();
            this.cgc_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).EndInit();
            this.cpc_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Departamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Atendente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CComboBoxEdit ccbe_Departamento;
        private Componentes.CLabelControl clc_Departamento;
        private Componentes.CComboBoxEdit ccbe_Categoria;
        private Componentes.CLabelControl clc_Categoria;
        private Componentes.CMemoEdit cme_Descricao;
        private Componentes.Menu.Adicionar_x16 csb_AdicionarAnexo;
        private Componentes.CGroupControl cgc_Anexos;
        private Componentes.CPanelControl cpc_Anexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_Anexos;
        private Componentes.Menu.Deletar_x16 csb_DeletarAnexo;
        private System.Windows.Forms.BindingSource bs_Anexos;
        private Componentes.CDateEdit cde_DT_Requerida;
        private Componentes.CLabelControl clc_DT_Requerido;
        private System.Windows.Forms.OpenFileDialog ofd;
        private Componentes.CTextEdit cte_Resumo;
        private Componentes.CLabelControl cLabelControl1;
        private Componentes.CComboBoxEdit ccbe_Atendente;
        private Componentes.CLabelControl clc_Atendente;
    }
}
