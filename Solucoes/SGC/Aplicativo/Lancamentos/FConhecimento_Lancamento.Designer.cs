namespace Aplicativo.Lancamentos
{
    partial class FConhecimento_Lancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConhecimento_Lancamento));
            this.cpc_DadosGerais = new Componentes.CPanelControl(this.components);
            this.cgc_Anexos = new Componentes.CGroupControl(this.components);
            this.lbc_Anexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_Anexos = new System.Windows.Forms.BindingSource(this.components);
            this.cpc_Anexos = new Componentes.CPanelControl(this.components);
            this.csb_AdicionarAnexo = new Componentes.Menu.Adicionar_x16(this.components);
            this.csb_DeletarAnexo = new Componentes.Menu.Deletar_x16(this.components);
            this.cme_Descricao = new Componentes.CMemoEdit(this.components);
            this.cce_Ativo = new Componentes.CCheckEdit(this.components);
            this.cbe_Categoria = new Componentes.CButtonEdit(this.components);
            this.clc_Categoria = new Componentes.CLabelControl(this.components);
            this.cte_DS_Categoria = new Componentes.CTextEdit(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.clc_Titulo = new Componentes.CLabelControl(this.components);
            this.cte_Identificador = new Componentes.CTextEdit(this.components);
            this.cte_Titulo = new Componentes.CTextEdit(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).BeginInit();
            this.cgc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).BeginInit();
            this.cpc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Ativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Titulo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cgc_Anexos);
            this.cpc_DadosGerais.Controls.Add(this.cme_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cce_Ativo);
            this.cpc_DadosGerais.Controls.Add(this.cbe_Categoria);
            this.cpc_DadosGerais.Controls.Add(this.clc_Categoria);
            this.cpc_DadosGerais.Controls.Add(this.cte_DS_Categoria);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_Titulo);
            this.cpc_DadosGerais.Controls.Add(this.cte_Identificador);
            this.cpc_DadosGerais.Controls.Add(this.cte_Titulo);
            this.cpc_DadosGerais.Controls.Add(this.clc_Identificador);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(634, 334);
            this.cpc_DadosGerais.TabIndex = 0;
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
            this.cgc_Anexos.Location = new System.Drawing.Point(12, 195);
            this.cgc_Anexos.Name = "cgc_Anexos";
            this.cgc_Anexos.Size = new System.Drawing.Size(610, 125);
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
            this.lbc_Anexos.Size = new System.Drawing.Size(606, 70);
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
            this.cpc_Anexos.Size = new System.Drawing.Size(606, 32);
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
            this.cme_Descricao.Descricao = "a descrição";
            this.cme_Descricao.Location = new System.Drawing.Point(12, 96);
            this.cme_Descricao.Name = "cme_Descricao";
            this.cme_Descricao.NaoVazio = true;
            this.cme_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Descricao.Properties.MaxLength = 1024;
            this.cme_Descricao.SemAcentuacao = false;
            this.cme_Descricao.SemPontuacao = false;
            this.cme_Descricao.Size = new System.Drawing.Size(610, 96);
            this.cme_Descricao.SomenteNumeros = false;
            this.cme_Descricao.TabIndex = 9;
            this.cme_Descricao.UseOptimizedRendering = true;
            // 
            // cce_Ativo
            // 
            this.cce_Ativo.EditValue = true;
            this.cce_Ativo.Location = new System.Drawing.Point(575, 22);
            this.cce_Ativo.Name = "cce_Ativo";
            this.cce_Ativo.Properties.AutoWidth = true;
            this.cce_Ativo.Properties.Caption = "Ativo";
            this.cce_Ativo.Size = new System.Drawing.Size(47, 19);
            this.cce_Ativo.TabIndex = 4;
            // 
            // cbe_Categoria
            // 
            this.cbe_Categoria.Descricao = "a categoria";
            this.cbe_Categoria.EditValue = "";
            this.cbe_Categoria.Location = new System.Drawing.Point(12, 59);
            this.cbe_Categoria.Name = "cbe_Categoria";
            this.cbe_Categoria.NaoVazio = true;
            this.cbe_Categoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbe_Categoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbe_Categoria.Properties.MaxLength = 9;
            this.cbe_Categoria.SemAcentuacao = false;
            this.cbe_Categoria.SemPontuacao = false;
            this.cbe_Categoria.Size = new System.Drawing.Size(100, 20);
            this.cbe_Categoria.SomenteNumeros = true;
            this.cbe_Categoria.TabIndex = 6;
            this.cbe_Categoria.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbe_Categoria_ButtonClick);
            this.cbe_Categoria.Leave += new System.EventHandler(this.cbe_Categoria_Leave);
            // 
            // clc_Categoria
            // 
            this.clc_Categoria.Location = new System.Drawing.Point(12, 45);
            this.clc_Categoria.Name = "clc_Categoria";
            this.clc_Categoria.Size = new System.Drawing.Size(47, 13);
            this.clc_Categoria.TabIndex = 5;
            this.clc_Categoria.Text = "Categoria";
            // 
            // cte_DS_Categoria
            // 
            this.cte_DS_Categoria.Descricao = null;
            this.cte_DS_Categoria.Location = new System.Drawing.Point(115, 59);
            this.cte_DS_Categoria.Mascara_IPv4 = false;
            this.cte_DS_Categoria.Mascara_PortaIPv4 = false;
            this.cte_DS_Categoria.Name = "cte_DS_Categoria";
            this.cte_DS_Categoria.NaoVazio = false;
            this.cte_DS_Categoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_DS_Categoria.Properties.ReadOnly = true;
            this.cte_DS_Categoria.SemAcentuacao = false;
            this.cte_DS_Categoria.SemPontuacao = false;
            this.cte_DS_Categoria.Size = new System.Drawing.Size(507, 20);
            this.cte_DS_Categoria.SomenteNumeros = false;
            this.cte_DS_Categoria.TabIndex = 7;
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(12, 82);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 8;
            this.clc_Descricao.Text = "Descrição";
            // 
            // clc_Titulo
            // 
            this.clc_Titulo.Location = new System.Drawing.Point(115, 8);
            this.clc_Titulo.Name = "clc_Titulo";
            this.clc_Titulo.Size = new System.Drawing.Size(26, 13);
            this.clc_Titulo.TabIndex = 2;
            this.clc_Titulo.Text = "Titulo";
            // 
            // cte_Identificador
            // 
            this.cte_Identificador.Descricao = "o identificador";
            this.cte_Identificador.Location = new System.Drawing.Point(12, 22);
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
            // cte_Titulo
            // 
            this.cte_Titulo.Descricao = "o título";
            this.cte_Titulo.Location = new System.Drawing.Point(115, 22);
            this.cte_Titulo.Mascara_IPv4 = false;
            this.cte_Titulo.Mascara_PortaIPv4 = false;
            this.cte_Titulo.Name = "cte_Titulo";
            this.cte_Titulo.NaoVazio = true;
            this.cte_Titulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cte_Titulo.Properties.MaxLength = 256;
            this.cte_Titulo.SemAcentuacao = false;
            this.cte_Titulo.SemPontuacao = false;
            this.cte_Titulo.Size = new System.Drawing.Size(455, 20);
            this.cte_Titulo.SomenteNumeros = false;
            this.cte_Titulo.TabIndex = 3;
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Location = new System.Drawing.Point(12, 8);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(61, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Identificador";
            // 
            // ofd
            // 
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecione o anexo desejado!";
            // 
            // FConhecimento_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 368);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FConhecimento_Lancamento";
            this.Text = "Lançamento - Conhecimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FConhecimento_Lancamento_FormClosing);
            this.Load += new System.EventHandler(this.FConhecimento_Lancamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FConhecimento_Lancamento_KeyDown);
            this.Controls.SetChildIndex(this.cpc_DadosGerais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).EndInit();
            this.cgc_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).EndInit();
            this.cpc_Anexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Ativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DS_Categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_Titulo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CLabelControl clc_Titulo;
        private Componentes.CTextEdit cte_Identificador;
        private Componentes.CTextEdit cte_Titulo;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CButtonEdit cbe_Categoria;
        private Componentes.CLabelControl clc_Categoria;
        private Componentes.CTextEdit cte_DS_Categoria;
        private Componentes.CMemoEdit cme_Descricao;
        private Componentes.CCheckEdit cce_Ativo;
        private Componentes.CGroupControl cgc_Anexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_Anexos;
        private System.Windows.Forms.BindingSource bs_Anexos;
        private Componentes.CPanelControl cpc_Anexos;
        private Componentes.Menu.Adicionar_x16 csb_AdicionarAnexo;
        private Componentes.Menu.Deletar_x16 csb_DeletarAnexo;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}