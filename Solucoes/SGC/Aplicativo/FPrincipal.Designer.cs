namespace Aplicativo
{
    partial class FPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            this.bm_Barras = new DevExpress.XtraBars.BarManager(this.components);
            this.b_Menu = new DevExpress.XtraBars.Bar();
            this.bsi_Cadastros = new DevExpress.XtraBars.BarSubItem();
            this.bbi_Usuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_ClienteFornecedor = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_GrupoUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Cargo = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Departamento = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_GrupoProduto = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Marca = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Modelo = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Item = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Equipamento = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_EquipamentoUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Senha = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Categoria = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Status = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Sugestao = new DevExpress.XtraBars.BarButtonItem();
            this.bsi_Relatorios = new DevExpress.XtraBars.BarSubItem();
            this.bbi_Dashboard = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R001 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R002 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R003 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R004 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R005 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R006 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R007 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_R008 = new DevExpress.XtraBars.BarButtonItem();
            this.bsi_Configuracoes = new DevExpress.XtraBars.BarSubItem();
            this.bbi_AlterarSenha = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_EnvioEmail = new DevExpress.XtraBars.BarButtonItem();
            this.b_Tools = new DevExpress.XtraBars.Bar();
            this.bbi_Chamado = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_AlocacaoRecurso = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Conhecimento = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Comunicado = new DevExpress.XtraBars.BarButtonItem();
            this.b_Status = new DevExpress.XtraBars.Bar();
            this.bsi_Suporte = new DevExpress.XtraBars.BarStaticItem();
            this.badc_Barras = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dm_Janelas = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemSparklineEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit();
            this.xtmm_Abas = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.t_aw = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bm_Barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badc_Barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm_Janelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtmm_Abas)).BeginInit();
            this.SuspendLayout();
            // 
            // bm_Barras
            // 
            this.bm_Barras.AllowCustomization = false;
            this.bm_Barras.AllowHtmlText = true;
            this.bm_Barras.AllowMoveBarOnToolbar = false;
            this.bm_Barras.AllowQuickCustomization = false;
            this.bm_Barras.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.b_Menu,
            this.b_Tools,
            this.b_Status});
            this.bm_Barras.Controller = this.badc_Barras;
            this.bm_Barras.DockControls.Add(this.barDockControlTop);
            this.bm_Barras.DockControls.Add(this.barDockControlBottom);
            this.bm_Barras.DockControls.Add(this.barDockControlLeft);
            this.bm_Barras.DockControls.Add(this.barDockControlRight);
            this.bm_Barras.DockManager = this.dm_Janelas;
            this.bm_Barras.Form = this;
            this.bm_Barras.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsi_Cadastros,
            this.bbi_Cargo,
            this.bbi_Categoria,
            this.bbi_ClienteFornecedor,
            this.bbi_Departamento,
            this.bbi_Marca,
            this.bbi_Modelo,
            this.bbi_Status,
            this.bbi_Sugestao,
            this.bbi_GrupoProduto,
            this.bbi_GrupoUsuario,
            this.bbi_Usuario,
            this.bbi_Item,
            this.bbi_Chamado,
            this.bbi_AlocacaoRecurso,
            this.bbi_Conhecimento,
            this.bsi_Suporte,
            this.bsi_Configuracoes,
            this.bbi_AlterarSenha,
            this.bbi_Equipamento,
            this.bbi_EquipamentoUsuario,
            this.bbi_Senha,
            this.bbi_Comunicado,
            this.bsi_Relatorios,
            this.bbi_R001,
            this.bbi_R002,
            this.bbi_R003,
            this.bbi_R004,
            this.bbi_EnvioEmail,
            this.bbi_Dashboard,
            this.bbi_R005,
            this.bbi_R006,
            this.bbi_R007,
            this.bbi_R008});
            this.bm_Barras.MainMenu = this.b_Menu;
            this.bm_Barras.MaxItemId = 47;
            this.bm_Barras.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemSparklineEdit1});
            this.bm_Barras.StatusBar = this.b_Status;
            this.bm_Barras.UseAltKeyForMenu = false;
            this.bm_Barras.UseF10KeyForMenu = false;
            // 
            // b_Menu
            // 
            this.b_Menu.BarName = "Menu";
            this.b_Menu.DockCol = 0;
            this.b_Menu.DockRow = 0;
            this.b_Menu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.b_Menu.HideWhenMerging = DevExpress.Utils.DefaultBoolean.False;
            this.b_Menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsi_Cadastros),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsi_Relatorios),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsi_Configuracoes)});
            this.b_Menu.OptionsBar.AllowQuickCustomization = false;
            this.b_Menu.OptionsBar.DisableClose = true;
            this.b_Menu.OptionsBar.DisableCustomization = true;
            this.b_Menu.OptionsBar.DrawDragBorder = false;
            this.b_Menu.OptionsBar.RotateWhenVertical = false;
            this.b_Menu.OptionsBar.UseWholeRow = true;
            this.b_Menu.Text = "Menu";
            // 
            // bsi_Cadastros
            // 
            this.bsi_Cadastros.Caption = "Cadastros";
            this.bsi_Cadastros.Id = 0;
            this.bsi_Cadastros.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Usuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_ClienteFornecedor, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_GrupoUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Cargo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Departamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_GrupoProduto, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Marca),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Modelo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Item),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Equipamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_EquipamentoUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Senha, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Categoria, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Status),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Sugestao)});
            this.bsi_Cadastros.Name = "bsi_Cadastros";
            this.bsi_Cadastros.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbi_Usuario
            // 
            this.bbi_Usuario.Caption = "Usuário";
            this.bbi_Usuario.Id = 13;
            this.bbi_Usuario.Name = "bbi_Usuario";
            this.bbi_Usuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Usuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Usuario_ItemClick);
            // 
            // bbi_ClienteFornecedor
            // 
            this.bbi_ClienteFornecedor.Caption = "Cliente / Fornecedor";
            this.bbi_ClienteFornecedor.Id = 4;
            this.bbi_ClienteFornecedor.Name = "bbi_ClienteFornecedor";
            this.bbi_ClienteFornecedor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_ClienteFornecedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_ClienteFornecedor_ItemClick);
            // 
            // bbi_GrupoUsuario
            // 
            this.bbi_GrupoUsuario.Caption = "Grupo de usuário";
            this.bbi_GrupoUsuario.Id = 12;
            this.bbi_GrupoUsuario.Name = "bbi_GrupoUsuario";
            this.bbi_GrupoUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_GrupoUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_GrupoUsuario_ItemClick);
            // 
            // bbi_Cargo
            // 
            this.bbi_Cargo.Caption = "Cargo";
            this.bbi_Cargo.Id = 2;
            this.bbi_Cargo.Name = "bbi_Cargo";
            this.bbi_Cargo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Cargo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Cargo_ItemClick);
            // 
            // bbi_Departamento
            // 
            this.bbi_Departamento.Caption = "Departamento";
            this.bbi_Departamento.Id = 5;
            this.bbi_Departamento.Name = "bbi_Departamento";
            this.bbi_Departamento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Departamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Departamento_ItemClick);
            // 
            // bbi_GrupoProduto
            // 
            this.bbi_GrupoProduto.Caption = "Grupo de produto";
            this.bbi_GrupoProduto.Id = 11;
            this.bbi_GrupoProduto.Name = "bbi_GrupoProduto";
            this.bbi_GrupoProduto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_GrupoProduto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_GrupoProduto_ItemClick);
            // 
            // bbi_Marca
            // 
            this.bbi_Marca.Caption = "Marca";
            this.bbi_Marca.Id = 6;
            this.bbi_Marca.Name = "bbi_Marca";
            this.bbi_Marca.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Marca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Marca_ItemClick);
            // 
            // bbi_Modelo
            // 
            this.bbi_Modelo.Caption = "Modelo";
            this.bbi_Modelo.Id = 7;
            this.bbi_Modelo.Name = "bbi_Modelo";
            this.bbi_Modelo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Modelo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Modelo_ItemClick);
            // 
            // bbi_Item
            // 
            this.bbi_Item.Caption = "Item";
            this.bbi_Item.Id = 14;
            this.bbi_Item.Name = "bbi_Item";
            this.bbi_Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Item_ItemClick);
            // 
            // bbi_Equipamento
            // 
            this.bbi_Equipamento.Caption = "Equipamento";
            this.bbi_Equipamento.Id = 29;
            this.bbi_Equipamento.Name = "bbi_Equipamento";
            this.bbi_Equipamento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Equipamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Equipamento_ItemClick);
            // 
            // bbi_EquipamentoUsuario
            // 
            this.bbi_EquipamentoUsuario.Caption = "Equipamento x usuário";
            this.bbi_EquipamentoUsuario.Id = 30;
            this.bbi_EquipamentoUsuario.Name = "bbi_EquipamentoUsuario";
            this.bbi_EquipamentoUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_EquipamentoUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_EquipamentoUsuario_ItemClick);
            // 
            // bbi_Senha
            // 
            this.bbi_Senha.Caption = "Senhas";
            this.bbi_Senha.Id = 31;
            this.bbi_Senha.Name = "bbi_Senha";
            this.bbi_Senha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Senha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Senha_ItemClick);
            // 
            // bbi_Categoria
            // 
            this.bbi_Categoria.Caption = "Categoria";
            this.bbi_Categoria.Id = 3;
            this.bbi_Categoria.Name = "bbi_Categoria";
            this.bbi_Categoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Categoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Categoria_ItemClick);
            // 
            // bbi_Status
            // 
            this.bbi_Status.Caption = "Status";
            this.bbi_Status.Id = 8;
            this.bbi_Status.Name = "bbi_Status";
            this.bbi_Status.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Status.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Status_ItemClick);
            // 
            // bbi_Sugestao
            // 
            this.bbi_Sugestao.Caption = "Sugestão";
            this.bbi_Sugestao.Id = 9;
            this.bbi_Sugestao.Name = "bbi_Sugestao";
            this.bbi_Sugestao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bsi_Relatorios
            // 
            this.bsi_Relatorios.Caption = "Relatórios";
            this.bsi_Relatorios.Id = 36;
            this.bsi_Relatorios.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Dashboard),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R001, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R002),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R003),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R004),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R005),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R006),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R007),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_R008)});
            this.bsi_Relatorios.Name = "bsi_Relatorios";
            this.bsi_Relatorios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbi_Dashboard
            // 
            this.bbi_Dashboard.Caption = "Acompanhamento Chamados";
            this.bbi_Dashboard.Id = 42;
            this.bbi_Dashboard.Name = "bbi_Dashboard";
            this.bbi_Dashboard.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Dashboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Dashboard_ItemClick);
            // 
            // bbi_R001
            // 
            this.bbi_R001.Caption = "R001 - Chamados por departamento";
            this.bbi_R001.Id = 37;
            this.bbi_R001.Name = "bbi_R001";
            this.bbi_R001.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R001.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R001_ItemClick);
            // 
            // bbi_R002
            // 
            this.bbi_R002.Caption = "R002 - Chamados por solicitante";
            this.bbi_R002.Id = 38;
            this.bbi_R002.Name = "bbi_R002";
            this.bbi_R002.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R002.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R002_ItemClick);
            // 
            // bbi_R003
            // 
            this.bbi_R003.Caption = "R003 - Chamados por departamento por categoria";
            this.bbi_R003.Id = 39;
            this.bbi_R003.Name = "bbi_R003";
            this.bbi_R003.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R003.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R003_ItemClick);
            // 
            // bbi_R004
            // 
            this.bbi_R004.Caption = "R004 - Chamados por categoria";
            this.bbi_R004.Id = 40;
            this.bbi_R004.Name = "bbi_R004";
            this.bbi_R004.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R004.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R004_ItemClick);
            // 
            // bbi_R005
            // 
            this.bbi_R005.Caption = "R005 - Nota por Atendente";
            this.bbi_R005.Id = 43;
            this.bbi_R005.Name = "bbi_R005";
            this.bbi_R005.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R005.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R005_ItemClick);
            // 
            // bbi_R006
            // 
            this.bbi_R006.Caption = "R006 - Tempo Atendimento por Categoria";
            this.bbi_R006.Id = 44;
            this.bbi_R006.Name = "bbi_R006";
            this.bbi_R006.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R006.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R006_ItemClick);
            // 
            // bbi_R007
            // 
            this.bbi_R007.Caption = "R007 - Chamados em Aberto por Prioridade";
            this.bbi_R007.Id = 45;
            this.bbi_R007.Name = "bbi_R007";
            this.bbi_R007.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R007_ItemClick);
            // 
            // bbi_R008
            // 
            this.bbi_R008.Caption = "R008 - Equipamento por Usuário";
            this.bbi_R008.Id = 46;
            this.bbi_R008.Name = "bbi_R008";
            this.bbi_R008.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_R008.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_R008_ItemClick);
            // 
            // bsi_Configuracoes
            // 
            this.bsi_Configuracoes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsi_Configuracoes.Caption = "Configurações";
            this.bsi_Configuracoes.Id = 22;
            this.bsi_Configuracoes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_AlterarSenha),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_EnvioEmail, true)});
            this.bsi_Configuracoes.Name = "bsi_Configuracoes";
            // 
            // bbi_AlterarSenha
            // 
            this.bbi_AlterarSenha.Caption = "Alterar senha";
            this.bbi_AlterarSenha.Id = 23;
            this.bbi_AlterarSenha.Name = "bbi_AlterarSenha";
            this.bbi_AlterarSenha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_AlterarSenha_ItemClick);
            // 
            // bbi_EnvioEmail
            // 
            this.bbi_EnvioEmail.Caption = "Envio de email";
            this.bbi_EnvioEmail.Id = 41;
            this.bbi_EnvioEmail.Name = "bbi_EnvioEmail";
            this.bbi_EnvioEmail.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_EnvioEmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_EnvioEmail_ItemClick);
            // 
            // b_Tools
            // 
            this.b_Tools.BarName = "Tools";
            this.b_Tools.DockCol = 0;
            this.b_Tools.DockRow = 1;
            this.b_Tools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.b_Tools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Chamado),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_AlocacaoRecurso, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Conhecimento, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Comunicado, true)});
            this.b_Tools.OptionsBar.AllowQuickCustomization = false;
            this.b_Tools.OptionsBar.DisableClose = true;
            this.b_Tools.OptionsBar.DisableCustomization = true;
            this.b_Tools.OptionsBar.DrawDragBorder = false;
            this.b_Tools.OptionsBar.RotateWhenVertical = false;
            this.b_Tools.OptionsBar.UseWholeRow = true;
            this.b_Tools.Text = "Tools";
            // 
            // bbi_Chamado
            // 
            this.bbi_Chamado.Caption = "Chamado";
            this.bbi_Chamado.Glyph = ((System.Drawing.Image)(resources.GetObject("bbi_Chamado.Glyph")));
            this.bbi_Chamado.Id = 16;
            this.bbi_Chamado.Name = "bbi_Chamado";
            this.bbi_Chamado.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_Chamado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Chamado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Chamado_ItemClick);
            // 
            // bbi_AlocacaoRecurso
            // 
            this.bbi_AlocacaoRecurso.Caption = "Alocação\nde recurso";
            this.bbi_AlocacaoRecurso.Glyph = ((System.Drawing.Image)(resources.GetObject("bbi_AlocacaoRecurso.Glyph")));
            this.bbi_AlocacaoRecurso.Id = 18;
            this.bbi_AlocacaoRecurso.Name = "bbi_AlocacaoRecurso";
            this.bbi_AlocacaoRecurso.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_AlocacaoRecurso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_AlocacaoRecurso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_AlocacaoRecurso_ItemClick);
            // 
            // bbi_Conhecimento
            // 
            this.bbi_Conhecimento.Caption = "Conhecimento";
            this.bbi_Conhecimento.Glyph = ((System.Drawing.Image)(resources.GetObject("bbi_Conhecimento.Glyph")));
            this.bbi_Conhecimento.Id = 19;
            this.bbi_Conhecimento.Name = "bbi_Conhecimento";
            this.bbi_Conhecimento.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_Conhecimento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Conhecimento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Conhecimento_ItemClick);
            // 
            // bbi_Comunicado
            // 
            this.bbi_Comunicado.Caption = "Comunicado";
            this.bbi_Comunicado.Glyph = ((System.Drawing.Image)(resources.GetObject("bbi_Comunicado.Glyph")));
            this.bbi_Comunicado.Id = 35;
            this.bbi_Comunicado.Name = "bbi_Comunicado";
            this.bbi_Comunicado.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbi_Comunicado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbi_Comunicado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Comunicado_ItemClick);
            // 
            // b_Status
            // 
            this.b_Status.BarName = "Status";
            this.b_Status.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.b_Status.DockCol = 0;
            this.b_Status.DockRow = 0;
            this.b_Status.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.b_Status.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsi_Suporte)});
            this.b_Status.OptionsBar.AllowQuickCustomization = false;
            this.b_Status.OptionsBar.DisableClose = true;
            this.b_Status.OptionsBar.DisableCustomization = true;
            this.b_Status.OptionsBar.DrawDragBorder = false;
            this.b_Status.OptionsBar.RotateWhenVertical = false;
            this.b_Status.OptionsBar.UseWholeRow = true;
            this.b_Status.Text = "Status";
            // 
            // bsi_Suporte
            // 
            this.bsi_Suporte.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.bsi_Suporte.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.bsi_Suporte.Caption = "<b>Suporte:</b> +55 (67) 9910-3174\r\n";
            this.bsi_Suporte.Id = 21;
            this.bsi_Suporte.Name = "bsi_Suporte";
            this.bsi_Suporte.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // badc_Barras
            // 
            this.badc_Barras.PropertiesBar.AllowLinkLighting = false;
            this.badc_Barras.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.badc_Barras.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(734, 67);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Size = new System.Drawing.Size(734, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 67);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 321);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(734, 67);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 321);
            // 
            // dm_Janelas
            // 
            this.dm_Janelas.Controller = this.badc_Barras;
            this.dm_Janelas.DockMode = DevExpress.XtraBars.Docking.Helpers.DockMode.Standard;
            this.dm_Janelas.Form = this;
            this.dm_Janelas.MenuManager = this.bm_Barras;
            this.dm_Janelas.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemSparklineEdit1
            // 
            this.repositoryItemSparklineEdit1.Name = "repositoryItemSparklineEdit1";
            this.repositoryItemSparklineEdit1.View = lineSparklineView1;
            // 
            // xtmm_Abas
            // 
            this.xtmm_Abas.AllowDragDrop = DevExpress.Utils.DefaultBoolean.False;
            this.xtmm_Abas.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtmm_Abas.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.Never;
            this.xtmm_Abas.Controller = this.badc_Barras;
            this.xtmm_Abas.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.xtmm_Abas.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
            this.xtmm_Abas.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtmm_Abas.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.xtmm_Abas.MdiParent = this;
            this.xtmm_Abas.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.xtmm_Abas.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.False;
            // 
            // t_aw
            // 
            this.t_aw.Enabled = true;
            this.t_aw.Interval = 300000;
            this.t_aw.Tick += new System.EventHandler(this.t_aw_Tick);
            // 
            // FPrincipal
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "FPrincipal";
            this.ShowInTaskbar = true;
            this.Text = "SGC - Sistema de Gestão em Chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bm_Barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badc_Barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm_Janelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtmm_Abas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager bm_Barras;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar b_Menu;
        private DevExpress.XtraBars.Bar b_Tools;
        private DevExpress.XtraBars.Bar b_Status;
        private DevExpress.XtraBars.BarSubItem bsi_Cadastros;
        private DevExpress.XtraBars.BarButtonItem bbi_Cargo;
        private DevExpress.XtraBars.BarButtonItem bbi_Categoria;
        private DevExpress.XtraBars.BarButtonItem bbi_ClienteFornecedor;
        private DevExpress.XtraBars.BarButtonItem bbi_Departamento;
        private DevExpress.XtraBars.BarButtonItem bbi_Marca;
        private DevExpress.XtraBars.BarButtonItem bbi_Modelo;
        private DevExpress.XtraBars.BarButtonItem bbi_Status;
        private DevExpress.XtraBars.BarButtonItem bbi_Sugestao;
        private DevExpress.XtraBars.BarButtonItem bbi_GrupoProduto;
        private DevExpress.XtraBars.BarButtonItem bbi_GrupoUsuario;
        private DevExpress.XtraBars.BarButtonItem bbi_Usuario;
        private DevExpress.XtraBars.BarButtonItem bbi_Item;
        private DevExpress.XtraBars.BarButtonItem bbi_Chamado;
        private DevExpress.XtraBars.BarButtonItem bbi_AlocacaoRecurso;
        private DevExpress.XtraBars.BarButtonItem bbi_Conhecimento;
        private DevExpress.XtraBars.BarStaticItem bsi_Suporte;
        private DevExpress.XtraBars.BarSubItem bsi_Configuracoes;
        private DevExpress.XtraBars.BarButtonItem bbi_AlterarSenha;
        private DevExpress.XtraBars.Docking.DockManager dm_Janelas;
        private DevExpress.XtraBars.BarAndDockingController badc_Barras;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtmm_Abas;
        private DevExpress.XtraBars.BarButtonItem bbi_Equipamento;
        private DevExpress.XtraBars.BarButtonItem bbi_EquipamentoUsuario;
        private DevExpress.XtraBars.BarButtonItem bbi_Senha;
        private DevExpress.XtraBars.BarButtonItem bbi_Comunicado;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit repositoryItemSparklineEdit1;
        private DevExpress.XtraBars.BarSubItem bsi_Relatorios;
        private DevExpress.XtraBars.BarButtonItem bbi_R001;
        private DevExpress.XtraBars.BarButtonItem bbi_R002;
        private DevExpress.XtraBars.BarButtonItem bbi_R003;
        private DevExpress.XtraBars.BarButtonItem bbi_R004;
        private DevExpress.XtraBars.BarButtonItem bbi_EnvioEmail;
        private DevExpress.XtraBars.BarButtonItem bbi_Dashboard;
        private DevExpress.XtraBars.BarButtonItem bbi_R005;
        private DevExpress.XtraBars.BarButtonItem bbi_R006;
        private DevExpress.XtraBars.BarButtonItem bbi_R007;
        private DevExpress.XtraBars.BarButtonItem bbi_R008;
        private System.Windows.Forms.Timer t_aw;
    }
}
