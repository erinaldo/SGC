namespace Aplicativo.Lancamentos
{
    partial class FEvolucao_Lancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEvolucao_Lancamento));
            this.cpc_DadosGerais = new Componentes.CPanelControl(this.components);
            this.clc_Atendente = new Componentes.CLabelControl(this.components);
            this.ccbe_Atendente = new Componentes.CComboBoxEdit(this.components);
            this.ccbe_Tipo = new Componentes.CComboBoxEdit(this.components);
            this.cLabelControl1 = new Componentes.CLabelControl(this.components);
            this.cgc_Anexos = new Componentes.CGroupControl(this.components);
            this.lbc_Anexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_Anexos = new System.Windows.Forms.BindingSource(this.components);
            this.cpc_Anexos = new Componentes.CPanelControl(this.components);
            this.csb_AdicionarAnexo = new Componentes.Menu.Adicionar_x16(this.components);
            this.csb_DeletarAnexo = new Componentes.Menu.Deletar_x16(this.components);
            this.cme_Descricao = new Componentes.CMemoEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.ccbe_Status = new Componentes.CComboBoxEdit(this.components);
            this.clc_Status = new Componentes.CLabelControl(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Atendente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).BeginInit();
            this.cgc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).BeginInit();
            this.cpc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Status.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.clc_Atendente);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Atendente);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Tipo);
            this.cpc_DadosGerais.Controls.Add(this.cLabelControl1);
            this.cpc_DadosGerais.Controls.Add(this.cgc_Anexos);
            this.cpc_DadosGerais.Controls.Add(this.cme_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.ccbe_Status);
            this.cpc_DadosGerais.Controls.Add(this.clc_Status);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(734, 377);
            this.cpc_DadosGerais.TabIndex = 0;
            // 
            // clc_Atendente
            // 
            this.clc_Atendente.Location = new System.Drawing.Point(12, 47);
            this.clc_Atendente.Name = "clc_Atendente";
            this.clc_Atendente.Size = new System.Drawing.Size(51, 13);
            this.clc_Atendente.TabIndex = 4;
            this.clc_Atendente.Text = "Atendente";
            // 
            // ccbe_Atendente
            // 
            this.ccbe_Atendente.Descricao = null;
            this.ccbe_Atendente.Location = new System.Drawing.Point(12, 61);
            this.ccbe_Atendente.Name = "ccbe_Atendente";
            this.ccbe_Atendente.NaoVazio = false;
            this.ccbe_Atendente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Atendente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Atendente.SemAcentuacao = false;
            this.ccbe_Atendente.SemPontuacao = false;
            this.ccbe_Atendente.Size = new System.Drawing.Size(710, 20);
            this.ccbe_Atendente.SomenteNumeros = false;
            this.ccbe_Atendente.TabIndex = 5;
            // 
            // ccbe_Tipo
            // 
            this.ccbe_Tipo.Descricao = "o tipo";
            this.ccbe_Tipo.Enabled = false;
            this.ccbe_Tipo.Location = new System.Drawing.Point(633, 23);
            this.ccbe_Tipo.Name = "ccbe_Tipo";
            this.ccbe_Tipo.NaoVazio = true;
            this.ccbe_Tipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Tipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Tipo.SemAcentuacao = false;
            this.ccbe_Tipo.SemPontuacao = false;
            this.ccbe_Tipo.Size = new System.Drawing.Size(89, 20);
            this.ccbe_Tipo.SomenteNumeros = false;
            this.ccbe_Tipo.TabIndex = 3;
            // 
            // cLabelControl1
            // 
            this.cLabelControl1.Location = new System.Drawing.Point(633, 9);
            this.cLabelControl1.Name = "cLabelControl1";
            this.cLabelControl1.Size = new System.Drawing.Size(20, 13);
            this.cLabelControl1.TabIndex = 2;
            this.cLabelControl1.Text = "Tipo";
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
            this.cgc_Anexos.Location = new System.Drawing.Point(12, 227);
            this.cgc_Anexos.Name = "cgc_Anexos";
            this.cgc_Anexos.Size = new System.Drawing.Size(710, 139);
            this.cgc_Anexos.TabIndex = 8;
            this.cgc_Anexos.Text = "Anexos";
            // 
            // lbc_Anexos
            // 
            this.lbc_Anexos.DataSource = this.bs_Anexos;
            this.lbc_Anexos.DisplayMember = "NM_ANEXO";
            this.lbc_Anexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_Anexos.Location = new System.Drawing.Point(2, 53);
            this.lbc_Anexos.Name = "lbc_Anexos";
            this.lbc_Anexos.Size = new System.Drawing.Size(706, 84);
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
            this.cpc_Anexos.Appearance.BackColor = System.Drawing.Color.Transparent;
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
            // cme_Descricao
            // 
            this.cme_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cme_Descricao.Descricao = "a descrição";
            this.cme_Descricao.Location = new System.Drawing.Point(12, 99);
            this.cme_Descricao.Name = "cme_Descricao";
            this.cme_Descricao.NaoVazio = false;
            this.cme_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Descricao.SemAcentuacao = false;
            this.cme_Descricao.SemPontuacao = false;
            this.cme_Descricao.Size = new System.Drawing.Size(710, 122);
            this.cme_Descricao.SomenteNumeros = false;
            this.cme_Descricao.TabIndex = 7;
            this.cme_Descricao.UseOptimizedRendering = true;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(12, 85);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 6;
            this.clc_Descricao.Text = "Descrição";
            // 
            // ccbe_Status
            // 
            this.ccbe_Status.Descricao = "o status";
            this.ccbe_Status.Location = new System.Drawing.Point(12, 23);
            this.ccbe_Status.Name = "ccbe_Status";
            this.ccbe_Status.NaoVazio = false;
            this.ccbe_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ccbe_Status.SemAcentuacao = false;
            this.ccbe_Status.SemPontuacao = false;
            this.ccbe_Status.Size = new System.Drawing.Size(618, 20);
            this.ccbe_Status.SomenteNumeros = false;
            this.ccbe_Status.TabIndex = 1;
            this.ccbe_Status.SelectedIndexChanged += new System.EventHandler(this.ccbe_Status_SelectedIndexChanged);
            // 
            // clc_Status
            // 
            this.clc_Status.Location = new System.Drawing.Point(12, 9);
            this.clc_Status.Name = "clc_Status";
            this.clc_Status.Size = new System.Drawing.Size(31, 13);
            this.clc_Status.TabIndex = 0;
            this.clc_Status.Text = "Status";
            // 
            // ofd
            // 
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecione o anexo desejado!";
            // 
            // FEvolucao_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FEvolucao_Lancamento";
            this.Text = "Lançamento - Evolução";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FEvolucao_Lancamento_FormClosing);
            this.Load += new System.EventHandler(this.FEvolucao_Lancamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FEvolucao_Lancamento_KeyDown);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Atendente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).EndInit();
            this.cgc_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).EndInit();
            this.cpc_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Status.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CMemoEdit cme_Descricao;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CComboBoxEdit ccbe_Status;
        private Componentes.CLabelControl clc_Status;
        private Componentes.CGroupControl cgc_Anexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_Anexos;
        private System.Windows.Forms.BindingSource bs_Anexos;
        private Componentes.CPanelControl cpc_Anexos;
        private Componentes.Menu.Adicionar_x16 csb_AdicionarAnexo;
        private Componentes.Menu.Deletar_x16 csb_DeletarAnexo;
        private System.Windows.Forms.OpenFileDialog ofd;
        private Componentes.CComboBoxEdit ccbe_Tipo;
        private Componentes.CLabelControl cLabelControl1;
        private Componentes.CLabelControl clc_Atendente;
        private Componentes.CComboBoxEdit ccbe_Atendente;

    }
}
