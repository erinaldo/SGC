namespace Aplicativo.Lancamentos
{
    partial class FComunicado_Lancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FComunicado_Lancamento));
            this.cpc_DadosGerais = new Componentes.CPanelControl(this.components);
            this.cgc_Anexos = new Componentes.CGroupControl(this.components);
            this.lbc_Anexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_Anexos = new System.Windows.Forms.BindingSource(this.components);
            this.cpc_Anexos = new Componentes.CPanelControl(this.components);
            this.csb_AdicionarAnexo = new Componentes.Menu.Adicionar_x16(this.components);
            this.csb_DeletarAnexo = new Componentes.Menu.Deletar_x16(this.components);
            this.cGroupControl1 = new Componentes.CGroupControl(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cGroupControl2 = new Componentes.CGroupControl(this.components);
            this.clbc_UsuariosDisponiveis = new Componentes.CListBoxControl(this.components);
            this.cGroupControl3 = new Componentes.CGroupControl(this.components);
            this.clbc_UsuariosCadastrados = new Componentes.CListBoxControl(this.components);
            this.cgc_Items = new Componentes.CGroupControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cgc_ItemsDisponiveis = new Componentes.CGroupControl(this.components);
            this.clbc_GruposUsuariosDisponiveis = new Componentes.CListBoxControl(this.components);
            this.cgc_ItemsCadastrados = new Componentes.CGroupControl(this.components);
            this.clbc_GruposUsuariosCadastrados = new Componentes.CListBoxControl(this.components);
            this.clc_Descricao = new Componentes.CLabelControl(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cme_Descricao = new Componentes.CMemoEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Anexos)).BeginInit();
            this.cgc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Anexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Anexos)).BeginInit();
            this.cpc_Anexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupControl1)).BeginInit();
            this.cGroupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupControl2)).BeginInit();
            this.cGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbc_UsuariosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupControl3)).BeginInit();
            this.cGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbc_UsuariosCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Items)).BeginInit();
            this.cgc_Items.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_ItemsDisponiveis)).BeginInit();
            this.cgc_ItemsDisponiveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbc_GruposUsuariosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_ItemsCadastrados)).BeginInit();
            this.cgc_ItemsCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbc_GruposUsuariosCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cme_Descricao);
            this.cpc_DadosGerais.Controls.Add(this.cgc_Anexos);
            this.cpc_DadosGerais.Controls.Add(this.cGroupControl1);
            this.cpc_DadosGerais.Controls.Add(this.cgc_Items);
            this.cpc_DadosGerais.Controls.Add(this.clc_Descricao);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(730, 472);
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
            this.cgc_Anexos.Location = new System.Drawing.Point(12, 334);
            this.cgc_Anexos.Name = "cgc_Anexos";
            this.cgc_Anexos.Size = new System.Drawing.Size(706, 125);
            this.cgc_Anexos.TabIndex = 18;
            this.cgc_Anexos.Text = "Anexos";
            // 
            // lbc_Anexos
            // 
            this.lbc_Anexos.DataSource = this.bs_Anexos;
            this.lbc_Anexos.DisplayMember = "NM_ANEXO";
            this.lbc_Anexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_Anexos.Location = new System.Drawing.Point(2, 53);
            this.lbc_Anexos.Name = "lbc_Anexos";
            this.lbc_Anexos.Size = new System.Drawing.Size(702, 70);
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
            this.cpc_Anexos.Size = new System.Drawing.Size(702, 32);
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
            // cGroupControl1
            // 
            this.cGroupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cGroupControl1.Appearance.Options.UseBackColor = true;
            this.cGroupControl1.Appearance.Options.UseTextOptions = true;
            this.cGroupControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cGroupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.cGroupControl1.AppearanceCaption.Options.UseFont = true;
            this.cGroupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.cGroupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.cGroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cGroupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cGroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.cGroupControl1.Controls.Add(this.tableLayoutPanel2);
            this.cGroupControl1.Location = new System.Drawing.Point(12, 211);
            this.cGroupControl1.Name = "cGroupControl1";
            this.cGroupControl1.Size = new System.Drawing.Size(706, 117);
            this.cGroupControl1.TabIndex = 3;
            this.cGroupControl1.Text = "Clique duas vezes para adicionar o item desejado na lista ao lado!";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cGroupControl2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cGroupControl3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cGroupControl2
            // 
            this.cGroupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cGroupControl2.Appearance.Options.UseBackColor = true;
            this.cGroupControl2.Appearance.Options.UseTextOptions = true;
            this.cGroupControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cGroupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.cGroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cGroupControl2.Controls.Add(this.clbc_UsuariosDisponiveis);
            this.cGroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGroupControl2.Location = new System.Drawing.Point(3, 3);
            this.cGroupControl2.Name = "cGroupControl2";
            this.cGroupControl2.Size = new System.Drawing.Size(345, 88);
            this.cGroupControl2.TabIndex = 0;
            this.cGroupControl2.Text = "Usuários disponíveis";
            // 
            // clbc_UsuariosDisponiveis
            // 
            this.clbc_UsuariosDisponiveis.Appearance.Options.UseTextOptions = true;
            this.clbc_UsuariosDisponiveis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clbc_UsuariosDisponiveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbc_UsuariosDisponiveis.Location = new System.Drawing.Point(2, 21);
            this.clbc_UsuariosDisponiveis.Name = "clbc_UsuariosDisponiveis";
            this.clbc_UsuariosDisponiveis.Size = new System.Drawing.Size(341, 65);
            this.clbc_UsuariosDisponiveis.TabIndex = 0;
            this.clbc_UsuariosDisponiveis.DoubleClick += new System.EventHandler(this.clbc_UsuariosDisponiveis_DoubleClick);
            // 
            // cGroupControl3
            // 
            this.cGroupControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cGroupControl3.Appearance.Options.UseBackColor = true;
            this.cGroupControl3.Appearance.Options.UseTextOptions = true;
            this.cGroupControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cGroupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.cGroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cGroupControl3.Controls.Add(this.clbc_UsuariosCadastrados);
            this.cGroupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGroupControl3.Location = new System.Drawing.Point(354, 3);
            this.cGroupControl3.Name = "cGroupControl3";
            this.cGroupControl3.Size = new System.Drawing.Size(345, 88);
            this.cGroupControl3.TabIndex = 1;
            this.cGroupControl3.Text = "Usuários cadastrados";
            // 
            // clbc_UsuariosCadastrados
            // 
            this.clbc_UsuariosCadastrados.Appearance.Options.UseTextOptions = true;
            this.clbc_UsuariosCadastrados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clbc_UsuariosCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbc_UsuariosCadastrados.Location = new System.Drawing.Point(2, 21);
            this.clbc_UsuariosCadastrados.Name = "clbc_UsuariosCadastrados";
            this.clbc_UsuariosCadastrados.Size = new System.Drawing.Size(341, 65);
            this.clbc_UsuariosCadastrados.TabIndex = 0;
            this.clbc_UsuariosCadastrados.DoubleClick += new System.EventHandler(this.clbc_UsuariosCadastrados_DoubleClick);
            // 
            // cgc_Items
            // 
            this.cgc_Items.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cgc_Items.Appearance.Options.UseBackColor = true;
            this.cgc_Items.Appearance.Options.UseTextOptions = true;
            this.cgc_Items.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_Items.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgc_Items.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.cgc_Items.AppearanceCaption.Options.UseFont = true;
            this.cgc_Items.AppearanceCaption.Options.UseForeColor = true;
            this.cgc_Items.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_Items.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cgc_Items.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cgc_Items.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.cgc_Items.Controls.Add(this.tableLayoutPanel1);
            this.cgc_Items.Location = new System.Drawing.Point(12, 88);
            this.cgc_Items.Name = "cgc_Items";
            this.cgc_Items.Size = new System.Drawing.Size(706, 117);
            this.cgc_Items.TabIndex = 2;
            this.cgc_Items.Text = "Clique duas vezes para adicionar o item desejado na lista ao lado!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cgc_ItemsDisponiveis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cgc_ItemsCadastrados, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cgc_ItemsDisponiveis
            // 
            this.cgc_ItemsDisponiveis.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cgc_ItemsDisponiveis.Appearance.Options.UseBackColor = true;
            this.cgc_ItemsDisponiveis.Appearance.Options.UseTextOptions = true;
            this.cgc_ItemsDisponiveis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_ItemsDisponiveis.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_ItemsDisponiveis.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_ItemsDisponiveis.Controls.Add(this.clbc_GruposUsuariosDisponiveis);
            this.cgc_ItemsDisponiveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgc_ItemsDisponiveis.Location = new System.Drawing.Point(3, 3);
            this.cgc_ItemsDisponiveis.Name = "cgc_ItemsDisponiveis";
            this.cgc_ItemsDisponiveis.Size = new System.Drawing.Size(345, 88);
            this.cgc_ItemsDisponiveis.TabIndex = 0;
            this.cgc_ItemsDisponiveis.Text = "Grupos de usuários disponíveis";
            // 
            // clbc_GruposUsuariosDisponiveis
            // 
            this.clbc_GruposUsuariosDisponiveis.Appearance.Options.UseTextOptions = true;
            this.clbc_GruposUsuariosDisponiveis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clbc_GruposUsuariosDisponiveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbc_GruposUsuariosDisponiveis.Location = new System.Drawing.Point(2, 21);
            this.clbc_GruposUsuariosDisponiveis.Name = "clbc_GruposUsuariosDisponiveis";
            this.clbc_GruposUsuariosDisponiveis.Size = new System.Drawing.Size(341, 65);
            this.clbc_GruposUsuariosDisponiveis.TabIndex = 0;
            this.clbc_GruposUsuariosDisponiveis.DoubleClick += new System.EventHandler(this.clbc_GruposUsuariosDisponiveis_DoubleClick);
            // 
            // cgc_ItemsCadastrados
            // 
            this.cgc_ItemsCadastrados.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cgc_ItemsCadastrados.Appearance.Options.UseBackColor = true;
            this.cgc_ItemsCadastrados.Appearance.Options.UseTextOptions = true;
            this.cgc_ItemsCadastrados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_ItemsCadastrados.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_ItemsCadastrados.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_ItemsCadastrados.Controls.Add(this.clbc_GruposUsuariosCadastrados);
            this.cgc_ItemsCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgc_ItemsCadastrados.Location = new System.Drawing.Point(354, 3);
            this.cgc_ItemsCadastrados.Name = "cgc_ItemsCadastrados";
            this.cgc_ItemsCadastrados.Size = new System.Drawing.Size(345, 88);
            this.cgc_ItemsCadastrados.TabIndex = 1;
            this.cgc_ItemsCadastrados.Text = "Grupos de usuários cadastrados";
            // 
            // clbc_GruposUsuariosCadastrados
            // 
            this.clbc_GruposUsuariosCadastrados.Appearance.Options.UseTextOptions = true;
            this.clbc_GruposUsuariosCadastrados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clbc_GruposUsuariosCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbc_GruposUsuariosCadastrados.Location = new System.Drawing.Point(2, 21);
            this.clbc_GruposUsuariosCadastrados.Name = "clbc_GruposUsuariosCadastrados";
            this.clbc_GruposUsuariosCadastrados.Size = new System.Drawing.Size(341, 65);
            this.clbc_GruposUsuariosCadastrados.TabIndex = 0;
            this.clbc_GruposUsuariosCadastrados.DoubleClick += new System.EventHandler(this.clbc_GruposUsuariosCadastrados_DoubleClick);
            // 
            // clc_Descricao
            // 
            this.clc_Descricao.Location = new System.Drawing.Point(12, 9);
            this.clc_Descricao.Name = "clc_Descricao";
            this.clc_Descricao.Size = new System.Drawing.Size(46, 13);
            this.clc_Descricao.TabIndex = 0;
            this.clc_Descricao.Text = "Descrição";
            // 
            // ofd
            // 
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecione o anexo desejado!";
            // 
            // cme_Descricao
            // 
            this.cme_Descricao.Descricao = "a descrição";
            this.cme_Descricao.Location = new System.Drawing.Point(12, 23);
            this.cme_Descricao.Name = "cme_Descricao";
            this.cme_Descricao.NaoVazio = true;
            this.cme_Descricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_Descricao.Properties.MaxLength = 256;
            this.cme_Descricao.SemAcentuacao = false;
            this.cme_Descricao.SemPontuacao = false;
            this.cme_Descricao.Size = new System.Drawing.Size(706, 57);
            this.cme_Descricao.SomenteNumeros = false;
            this.cme_Descricao.TabIndex = 1;
            this.cme_Descricao.UseOptimizedRendering = true;
            // 
            // FComunicado_Lancamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.cpc_DadosGerais);
            this.Name = "FComunicado_Lancamento";
            this.Text = "Lançamento - Comunicado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FComunicado_Lancamento_FormClosing);
            this.Load += new System.EventHandler(this.FComunicado_Lancamento_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cGroupControl1)).EndInit();
            this.cGroupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGroupControl2)).EndInit();
            this.cGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbc_UsuariosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupControl3)).EndInit();
            this.cGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbc_UsuariosCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Items)).EndInit();
            this.cgc_Items.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cgc_ItemsDisponiveis)).EndInit();
            this.cgc_ItemsDisponiveis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbc_GruposUsuariosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_ItemsCadastrados)).EndInit();
            this.cgc_ItemsCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbc_GruposUsuariosCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_Descricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CLabelControl clc_Descricao;
        private Componentes.CGroupControl cGroupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.CGroupControl cGroupControl2;
        private Componentes.CListBoxControl clbc_UsuariosDisponiveis;
        private Componentes.CGroupControl cGroupControl3;
        private Componentes.CListBoxControl clbc_UsuariosCadastrados;
        private Componentes.CGroupControl cgc_Items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Componentes.CGroupControl cgc_ItemsDisponiveis;
        private Componentes.CListBoxControl clbc_GruposUsuariosDisponiveis;
        private Componentes.CGroupControl cgc_ItemsCadastrados;
        private Componentes.CListBoxControl clbc_GruposUsuariosCadastrados;
        private Componentes.CGroupControl cgc_Anexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_Anexos;
        private System.Windows.Forms.BindingSource bs_Anexos;
        private Componentes.CPanelControl cpc_Anexos;
        private Componentes.Menu.Adicionar_x16 csb_AdicionarAnexo;
        private Componentes.Menu.Deletar_x16 csb_DeletarAnexo;
        private System.Windows.Forms.OpenFileDialog ofd;
        private Componentes.CMemoEdit cme_Descricao;
    }
}