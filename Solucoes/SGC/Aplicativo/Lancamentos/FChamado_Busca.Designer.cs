namespace Aplicativo.Lancamentos
{
    partial class FChamado_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChamado_Busca));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colST_CHAMADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRAVIDADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cp_Menu = new Componentes.Menu.Painel_x32(this.components);
            this.csb_Buscar = new Componentes.Menu.Buscar_x32(this.components);
            this.csb_Sair = new Componentes.Menu.Cancelar_x32(this.components);
            this.csb_AtualizarFiltros = new Componentes.CSimpleButton(this.components);
            this.csb_Relatorio = new Componentes.Menu.Relatorio_x32(this.components);
            this.csb_Finalizar = new Componentes.CSimpleButton(this.components);
            this.csb_Evoluir = new Componentes.CSimpleButton(this.components);
            this.csb_Atender = new Componentes.CSimpleButton(this.components);
            this.csb_Adicionar = new Componentes.Menu.Adicionar_x32(this.components);
            this.bm_Menu = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbi_Buscar_200 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Buscar_1000 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Buscar_Todos = new DevExpress.XtraBars.BarButtonItem();
            this.cpc_Filtros = new Componentes.CPanelControl(this.components);
            this.cse_Identificador = new Componentes.CSpinEdit(this.components);
            this.cce_ChamadosAbertos = new Componentes.CCheckEdit(this.components);
            this.ccbe_Gravidade = new Componentes.CCheckedComboBoxEdit(this.components);
            this.clc_Gravidade = new Componentes.CLabelControl(this.components);
            this.cccbe_Departamento = new Componentes.CCheckedComboBoxEdit(this.components);
            this.bs_Departamento = new System.Windows.Forms.BindingSource(this.components);
            this.cccbe_Categoria = new Componentes.CCheckedComboBoxEdit(this.components);
            this.bs_Categoria = new System.Windows.Forms.BindingSource(this.components);
            this.cccbe_Prioridade = new Componentes.CCheckedComboBoxEdit(this.components);
            this.bs_Prioridade = new System.Windows.Forms.BindingSource(this.components);
            this.cccbe_Status = new Componentes.CCheckedComboBoxEdit(this.components);
            this.bs_Status = new System.Windows.Forms.BindingSource(this.components);
            this.cccbe_Solicitante = new Componentes.CCheckedComboBoxEdit(this.components);
            this.bs_Solicitante = new System.Windows.Forms.BindingSource(this.components);
            this.cccbe_Atendente = new Componentes.CCheckedComboBoxEdit(this.components);
            this.bs_Atendente = new System.Windows.Forms.BindingSource(this.components);
            this.clc_Departamento = new Componentes.CLabelControl(this.components);
            this.clc_Categoria = new Componentes.CLabelControl(this.components);
            this.cgc_Datas = new Componentes.CGroupControl(this.components);
            this.cpc_Datas = new Componentes.CPanelControl(this.components);
            this.cce_Finalizado = new Componentes.CCheckEdit(this.components);
            this.cce_Previsto = new Componentes.CCheckEdit(this.components);
            this.cce_Lancamento = new Componentes.CCheckEdit(this.components);
            this.cde_DataInicial = new Componentes.CDateEdit(this.components);
            this.cce_Atendimento = new Componentes.CCheckEdit(this.components);
            this.clc_DataInicial = new Componentes.CLabelControl(this.components);
            this.clc_DataFinal = new Componentes.CLabelControl(this.components);
            this.cde_DataFinal = new Componentes.CDateEdit(this.components);
            this.clc_Prioridade = new Componentes.CLabelControl(this.components);
            this.clc_Status = new Componentes.CLabelControl(this.components);
            this.clc_Solicitante = new Componentes.CLabelControl(this.components);
            this.clc_Atendente = new Componentes.CLabelControl(this.components);
            this.clc_Identificador = new Componentes.CLabelControl(this.components);
            this.pm_Menu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtc_Abas = new DevExpress.XtraTab.XtraTabControl();
            this.xtp_Chamado = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Chamado = new DevExpress.XtraGrid.GridControl();
            this.gv_Chamado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_CHAMADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCATEGORIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTAMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTAMENTO_SOLICITANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGIN_SOLICITANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGIN_ATENDENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CHAMADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_OBSERVACAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_SOLUCAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTIMATIVA_TEMPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_PRIORIDADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_PRIORIDADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_CHAMADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_PREVISTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_FINALIZADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_ATENDIMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_REQUERIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_ULTIMAEVOLUCAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_EVOLUCAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_RESUMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colST_SOLICITANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVOLUCAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtp_ChamadoDetalhes = new DevExpress.XtraTab.XtraTabPage();
            this.cpc_DadosGerais = new Componentes.CPanelControl(this.components);
            this.cte_DetalhesCategoria = new Componentes.CTextEdit(this.components);
            this.cte_DetalhesApartamento = new Componentes.CTextEdit(this.components);
            this.cde_DetalhesDataRequerida = new Componentes.CDateEdit(this.components);
            this.cgc_DetalhesAnexos = new Componentes.CGroupControl(this.components);
            this.lbc_DetalhesAnexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_DetalhesAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.clc_Detalhes_DataRequerida = new Componentes.CLabelControl(this.components);
            this.cme_DetalhesDescricao = new Componentes.CMemoEdit(this.components);
            this.clc_DetalhesDescricao = new Componentes.CLabelControl(this.components);
            this.clc_DetalhesDepartamento = new Componentes.CLabelControl(this.components);
            this.clc_DetalhesCategoria = new Componentes.CLabelControl(this.components);
            this.xtp_ChamadoEvolucoes = new DevExpress.XtraTab.XtraTabPage();
            this.gc_DetalhesEvolucoes = new DevExpress.XtraEditors.GroupControl();
            this.cme_EvolucaoObservacao = new Componentes.CMemoEdit(this.components);
            this.clc_EvolucaoObservacao = new Componentes.CLabelControl(this.components);
            this.cte_EvolucaoStatus = new Componentes.CTextEdit(this.components);
            this.clc_EvolucaoStatus = new Componentes.CLabelControl(this.components);
            this.cde_EvolucaoData = new Componentes.CDateEdit(this.components);
            this.clc_EvolucaoData = new Componentes.CLabelControl(this.components);
            this.cgc_EvolucaoAnexos = new Componentes.CGroupControl(this.components);
            this.lbc_EvolucaoAnexos = new DevExpress.XtraEditors.ListBoxControl();
            this.bs_EvolucoesAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.gc_Evolucoes = new DevExpress.XtraGrid.GridControl();
            this.gv_Evolucoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_EVENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDT_EVENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_EVENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVOLUCAO_LOGINATENDENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cp_Menu)).BeginInit();
            this.cp_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Filtros)).BeginInit();
            this.cpc_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cse_Identificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_ChamadosAbertos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Gravidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Departamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Departamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Prioridade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Prioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Solicitante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Solicitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Atendente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Atendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Datas)).BeginInit();
            this.cgc_Datas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Datas)).BeginInit();
            this.cpc_Datas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Finalizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Previsto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Lancamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Atendimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).BeginInit();
            this.xtc_Abas.SuspendLayout();
            this.xtp_Chamado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Chamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Chamado)).BeginInit();
            this.xtp_ChamadoDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).BeginInit();
            this.cpc_DadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DetalhesCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DetalhesApartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DetalhesDataRequerida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DetalhesDataRequerida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_DetalhesAnexos)).BeginInit();
            this.cgc_DetalhesAnexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_DetalhesAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_DetalhesAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_DetalhesDescricao.Properties)).BeginInit();
            this.xtp_ChamadoEvolucoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DetalhesEvolucoes)).BeginInit();
            this.gc_DetalhesEvolucoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cme_EvolucaoObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_EvolucaoStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_EvolucaoData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_EvolucaoData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_EvolucaoAnexos)).BeginInit();
            this.cgc_EvolucaoAnexos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_EvolucaoAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_EvolucoesAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Evolucoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Evolucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // colST_CHAMADO
            // 
            this.colST_CHAMADO.Caption = "Status";
            this.colST_CHAMADO.FieldName = "ST_CHAMADO";
            this.colST_CHAMADO.Name = "colST_CHAMADO";
            this.colST_CHAMADO.OptionsColumn.AllowEdit = false;
            this.colST_CHAMADO.OptionsColumn.AllowFocus = false;
            this.colST_CHAMADO.OptionsColumn.FixedWidth = true;
            this.colST_CHAMADO.Visible = true;
            this.colST_CHAMADO.VisibleIndex = 6;
            this.colST_CHAMADO.Width = 85;
            // 
            // colGRAVIDADE
            // 
            this.colGRAVIDADE.AppearanceCell.Options.UseTextOptions = true;
            this.colGRAVIDADE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGRAVIDADE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGRAVIDADE.AppearanceHeader.Options.UseTextOptions = true;
            this.colGRAVIDADE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGRAVIDADE.Caption = "Gravidade";
            this.colGRAVIDADE.FieldName = "GRAVIDADE";
            this.colGRAVIDADE.Name = "colGRAVIDADE";
            this.colGRAVIDADE.OptionsColumn.AllowEdit = false;
            this.colGRAVIDADE.OptionsColumn.AllowFocus = false;
            this.colGRAVIDADE.Visible = true;
            this.colGRAVIDADE.VisibleIndex = 14;
            // 
            // cp_Menu
            // 
            this.cp_Menu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cp_Menu.Appearance.Options.UseBackColor = true;
            this.cp_Menu.Appearance.Options.UseTextOptions = true;
            this.cp_Menu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cp_Menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cp_Menu.Controls.Add(this.csb_Buscar);
            this.cp_Menu.Controls.Add(this.csb_Sair);
            this.cp_Menu.Controls.Add(this.csb_AtualizarFiltros);
            this.cp_Menu.Controls.Add(this.csb_Relatorio);
            this.cp_Menu.Controls.Add(this.csb_Finalizar);
            this.cp_Menu.Controls.Add(this.csb_Evoluir);
            this.cp_Menu.Controls.Add(this.csb_Atender);
            this.cp_Menu.Controls.Add(this.csb_Adicionar);
            this.cp_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cp_Menu.Location = new System.Drawing.Point(0, 0);
            this.cp_Menu.Name = "cp_Menu";
            this.cp_Menu.Size = new System.Drawing.Size(719, 50);
            this.cp_Menu.TabIndex = 0;
            // 
            // csb_Buscar
            // 
            this.csb_Buscar.AllowFocus = false;
            this.csb_Buscar.Appearance.Options.UseTextOptions = true;
            this.csb_Buscar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Buscar.Image")));
            this.csb_Buscar.Location = new System.Drawing.Point(97, 5);
            this.csb_Buscar.Name = "csb_Buscar";
            this.csb_Buscar.Size = new System.Drawing.Size(79, 40);
            this.csb_Buscar.TabIndex = 8;
            this.csb_Buscar.Text = "(F5)\nBuscar";
            this.csb_Buscar.Click += new System.EventHandler(this.csb_Buscar_Click);
            // 
            // csb_Sair
            // 
            this.csb_Sair.AllowFocus = false;
            this.csb_Sair.Appearance.Options.UseTextOptions = true;
            this.csb_Sair.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Sair.Image = ((System.Drawing.Image)(resources.GetObject("csb_Sair.Image")));
            this.csb_Sair.Location = new System.Drawing.Point(644, 5);
            this.csb_Sair.Name = "csb_Sair";
            this.csb_Sair.Size = new System.Drawing.Size(70, 40);
            this.csb_Sair.TabIndex = 7;
            this.csb_Sair.Text = "(ESC)\nSair";
            this.csb_Sair.Click += new System.EventHandler(this.csb_Sair_Click);
            // 
            // csb_AtualizarFiltros
            // 
            this.csb_AtualizarFiltros.Appearance.Options.UseTextOptions = true;
            this.csb_AtualizarFiltros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_AtualizarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("csb_AtualizarFiltros.Image")));
            this.csb_AtualizarFiltros.Location = new System.Drawing.Point(525, 5);
            this.csb_AtualizarFiltros.Name = "csb_AtualizarFiltros";
            this.csb_AtualizarFiltros.Size = new System.Drawing.Size(115, 40);
            this.csb_AtualizarFiltros.TabIndex = 6;
            this.csb_AtualizarFiltros.Text = "(F12)\nAtualizar filtros";
            this.csb_AtualizarFiltros.Click += new System.EventHandler(this.csb_AtualizarFiltros_Click);
            // 
            // csb_Relatorio
            // 
            this.csb_Relatorio.AllowFocus = false;
            this.csb_Relatorio.Appearance.Options.UseTextOptions = true;
            this.csb_Relatorio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Relatorio.Image = ((System.Drawing.Image)(resources.GetObject("csb_Relatorio.Image")));
            this.csb_Relatorio.Location = new System.Drawing.Point(180, 5);
            this.csb_Relatorio.Name = "csb_Relatorio";
            this.csb_Relatorio.Size = new System.Drawing.Size(88, 40);
            this.csb_Relatorio.TabIndex = 2;
            this.csb_Relatorio.Text = "(F7)\nRelatório";
            this.csb_Relatorio.Click += new System.EventHandler(this.csb_Relatorio_Click);
            // 
            // csb_Finalizar
            // 
            this.csb_Finalizar.Appearance.Options.UseTextOptions = true;
            this.csb_Finalizar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Finalizar.Image")));
            this.csb_Finalizar.Location = new System.Drawing.Point(438, 5);
            this.csb_Finalizar.Name = "csb_Finalizar";
            this.csb_Finalizar.Size = new System.Drawing.Size(83, 40);
            this.csb_Finalizar.TabIndex = 5;
            this.csb_Finalizar.Text = "(F11)\nFinalizar";
            this.csb_Finalizar.Click += new System.EventHandler(this.csb_Finalizar_Click);
            // 
            // csb_Evoluir
            // 
            this.csb_Evoluir.Appearance.Options.UseTextOptions = true;
            this.csb_Evoluir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Evoluir.Image = ((System.Drawing.Image)(resources.GetObject("csb_Evoluir.Image")));
            this.csb_Evoluir.Location = new System.Drawing.Point(358, 5);
            this.csb_Evoluir.Name = "csb_Evoluir";
            this.csb_Evoluir.Size = new System.Drawing.Size(76, 40);
            this.csb_Evoluir.TabIndex = 4;
            this.csb_Evoluir.Text = "(F10)\nEvoluir";
            this.csb_Evoluir.Click += new System.EventHandler(this.csb_Evoluir_Click);
            // 
            // csb_Atender
            // 
            this.csb_Atender.Appearance.Options.UseTextOptions = true;
            this.csb_Atender.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Atender.Image = ((System.Drawing.Image)(resources.GetObject("csb_Atender.Image")));
            this.csb_Atender.Location = new System.Drawing.Point(272, 5);
            this.csb_Atender.Name = "csb_Atender";
            this.csb_Atender.Size = new System.Drawing.Size(82, 40);
            this.csb_Atender.TabIndex = 3;
            this.csb_Atender.Text = "(F9)\nAtender";
            this.csb_Atender.Click += new System.EventHandler(this.csb_Atender_Click);
            // 
            // csb_Adicionar
            // 
            this.csb_Adicionar.AllowFocus = false;
            this.csb_Adicionar.Appearance.Options.UseTextOptions = true;
            this.csb_Adicionar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.csb_Adicionar.Image = ((System.Drawing.Image)(resources.GetObject("csb_Adicionar.Image")));
            this.csb_Adicionar.Location = new System.Drawing.Point(5, 5);
            this.csb_Adicionar.Name = "csb_Adicionar";
            this.csb_Adicionar.Size = new System.Drawing.Size(88, 40);
            this.csb_Adicionar.TabIndex = 0;
            this.csb_Adicionar.Text = "(F2)\nAdicionar";
            this.csb_Adicionar.Click += new System.EventHandler(this.csb_Adicionar_Click);
            // 
            // bm_Menu
            // 
            this.bm_Menu.DockControls.Add(this.barDockControlTop);
            this.bm_Menu.DockControls.Add(this.barDockControlBottom);
            this.bm_Menu.DockControls.Add(this.barDockControlLeft);
            this.bm_Menu.DockControls.Add(this.barDockControlRight);
            this.bm_Menu.Form = this;
            this.bm_Menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_Buscar_200,
            this.bbi_Buscar_1000,
            this.bbi_Buscar_Todos});
            this.bm_Menu.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(719, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 567);
            this.barDockControlBottom.Size = new System.Drawing.Size(719, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 567);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(719, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 567);
            // 
            // bbi_Buscar_200
            // 
            this.bbi_Buscar_200.Caption = "Buscar até 200 registros";
            this.bbi_Buscar_200.Id = 0;
            this.bbi_Buscar_200.Name = "bbi_Buscar_200";
            // 
            // bbi_Buscar_1000
            // 
            this.bbi_Buscar_1000.Caption = "Buscar até 1000 registros";
            this.bbi_Buscar_1000.Id = 1;
            this.bbi_Buscar_1000.Name = "bbi_Buscar_1000";
            // 
            // bbi_Buscar_Todos
            // 
            this.bbi_Buscar_Todos.Caption = "Buscar todos os registros";
            this.bbi_Buscar_Todos.Id = 2;
            this.bbi_Buscar_Todos.Name = "bbi_Buscar_Todos";
            // 
            // cpc_Filtros
            // 
            this.cpc_Filtros.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_Filtros.Appearance.Options.UseBackColor = true;
            this.cpc_Filtros.Appearance.Options.UseTextOptions = true;
            this.cpc_Filtros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cpc_Filtros.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Filtros.Controls.Add(this.cse_Identificador);
            this.cpc_Filtros.Controls.Add(this.cce_ChamadosAbertos);
            this.cpc_Filtros.Controls.Add(this.ccbe_Gravidade);
            this.cpc_Filtros.Controls.Add(this.clc_Gravidade);
            this.cpc_Filtros.Controls.Add(this.cccbe_Departamento);
            this.cpc_Filtros.Controls.Add(this.cccbe_Categoria);
            this.cpc_Filtros.Controls.Add(this.cccbe_Prioridade);
            this.cpc_Filtros.Controls.Add(this.cccbe_Status);
            this.cpc_Filtros.Controls.Add(this.cccbe_Solicitante);
            this.cpc_Filtros.Controls.Add(this.cccbe_Atendente);
            this.cpc_Filtros.Controls.Add(this.clc_Departamento);
            this.cpc_Filtros.Controls.Add(this.clc_Categoria);
            this.cpc_Filtros.Controls.Add(this.cgc_Datas);
            this.cpc_Filtros.Controls.Add(this.clc_Prioridade);
            this.cpc_Filtros.Controls.Add(this.clc_Status);
            this.cpc_Filtros.Controls.Add(this.clc_Solicitante);
            this.cpc_Filtros.Controls.Add(this.clc_Atendente);
            this.cpc_Filtros.Controls.Add(this.clc_Identificador);
            this.cpc_Filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpc_Filtros.Location = new System.Drawing.Point(0, 50);
            this.cpc_Filtros.Name = "cpc_Filtros";
            this.cpc_Filtros.Size = new System.Drawing.Size(719, 150);
            this.cpc_Filtros.TabIndex = 0;
            // 
            // cse_Identificador
            // 
            this.cse_Identificador.Decimais = 0;
            this.cse_Identificador.Descricao = null;
            this.cse_Identificador.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cse_Identificador.Location = new System.Drawing.Point(12, 23);
            this.cse_Identificador.MenuManager = this.bm_Menu;
            this.cse_Identificador.Name = "cse_Identificador";
            this.cse_Identificador.NaoVazio = false;
            this.cse_Identificador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.cse_Identificador.Properties.DisplayFormat.FormatString = "d";
            this.cse_Identificador.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cse_Identificador.Properties.EditFormat.FormatString = "d";
            this.cse_Identificador.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cse_Identificador.Properties.Mask.EditMask = "d";
            this.cse_Identificador.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.cse_Identificador.Size = new System.Drawing.Size(100, 20);
            this.cse_Identificador.TabIndex = 1;
            // 
            // cce_ChamadosAbertos
            // 
            this.cce_ChamadosAbertos.EditValue = true;
            this.cce_ChamadosAbertos.Location = new System.Drawing.Point(12, 121);
            this.cce_ChamadosAbertos.MenuManager = this.bm_Menu;
            this.cce_ChamadosAbertos.Name = "cce_ChamadosAbertos";
            this.cce_ChamadosAbertos.Properties.Caption = "Somente chamados em status aberto";
            this.cce_ChamadosAbertos.Size = new System.Drawing.Size(365, 19);
            this.cce_ChamadosAbertos.TabIndex = 17;
            // 
            // ccbe_Gravidade
            // 
            this.ccbe_Gravidade.EditValue = "1, 2, 3";
            this.ccbe_Gravidade.Location = new System.Drawing.Point(517, 97);
            this.ccbe_Gravidade.Name = "ccbe_Gravidade";
            this.ccbe_Gravidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe_Gravidade.Properties.DisplayMember = "DS_CATEGORIA";
            this.ccbe_Gravidade.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "Alta", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "Média", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("3", "Baixa", System.Windows.Forms.CheckState.Checked)});
            this.ccbe_Gravidade.Properties.ValueMember = "ID_CATEGORIA";
            this.ccbe_Gravidade.Size = new System.Drawing.Size(197, 20);
            this.ccbe_Gravidade.TabIndex = 16;
            // 
            // clc_Gravidade
            // 
            this.clc_Gravidade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Gravidade.Location = new System.Drawing.Point(517, 83);
            this.clc_Gravidade.Name = "clc_Gravidade";
            this.clc_Gravidade.Size = new System.Drawing.Size(49, 13);
            this.clc_Gravidade.TabIndex = 15;
            this.clc_Gravidade.Text = "Gravidade";
            // 
            // cccbe_Departamento
            // 
            this.cccbe_Departamento.Location = new System.Drawing.Point(517, 60);
            this.cccbe_Departamento.Name = "cccbe_Departamento";
            this.cccbe_Departamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cccbe_Departamento.Properties.DataSource = this.bs_Departamento;
            this.cccbe_Departamento.Properties.DisplayMember = "DS_DEPARTAMENTO";
            this.cccbe_Departamento.Properties.ValueMember = "ID_DEPARTAMENTO";
            this.cccbe_Departamento.Size = new System.Drawing.Size(197, 20);
            this.cccbe_Departamento.TabIndex = 11;
            // 
            // bs_Departamento
            // 
            this.bs_Departamento.DataSource = typeof(Entidades.E_DEPARTAMENTO);
            // 
            // cccbe_Categoria
            // 
            this.cccbe_Categoria.Location = new System.Drawing.Point(517, 23);
            this.cccbe_Categoria.Name = "cccbe_Categoria";
            this.cccbe_Categoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cccbe_Categoria.Properties.DataSource = this.bs_Categoria;
            this.cccbe_Categoria.Properties.DisplayMember = "DS_CATEGORIA";
            this.cccbe_Categoria.Properties.ValueMember = "ID_CATEGORIA";
            this.cccbe_Categoria.Size = new System.Drawing.Size(197, 20);
            this.cccbe_Categoria.TabIndex = 7;
            // 
            // bs_Categoria
            // 
            this.bs_Categoria.DataSource = typeof(Entidades.E_CATEGORIA);
            // 
            // cccbe_Prioridade
            // 
            this.cccbe_Prioridade.Location = new System.Drawing.Point(383, 97);
            this.cccbe_Prioridade.Name = "cccbe_Prioridade";
            this.cccbe_Prioridade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cccbe_Prioridade.Properties.DataSource = this.bs_Prioridade;
            this.cccbe_Prioridade.Properties.DisplayMember = "DS_PRIORIDADE";
            this.cccbe_Prioridade.Properties.ValueMember = "ID_PRIORIDADE";
            this.cccbe_Prioridade.Size = new System.Drawing.Size(131, 20);
            this.cccbe_Prioridade.TabIndex = 14;
            // 
            // bs_Prioridade
            // 
            this.bs_Prioridade.DataSource = typeof(Entidades.E_PRIORIDADE);
            // 
            // cccbe_Status
            // 
            this.cccbe_Status.Location = new System.Drawing.Point(383, 60);
            this.cccbe_Status.Name = "cccbe_Status";
            this.cccbe_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cccbe_Status.Properties.DataSource = this.bs_Status;
            this.cccbe_Status.Properties.DisplayMember = "DS_STATUS";
            this.cccbe_Status.Properties.ValueMember = "SIGLA_STATUS";
            this.cccbe_Status.Size = new System.Drawing.Size(131, 20);
            this.cccbe_Status.TabIndex = 9;
            // 
            // bs_Status
            // 
            this.bs_Status.DataSource = typeof(Entidades.E_STATUS);
            // 
            // cccbe_Solicitante
            // 
            this.cccbe_Solicitante.Location = new System.Drawing.Point(318, 23);
            this.cccbe_Solicitante.Name = "cccbe_Solicitante";
            this.cccbe_Solicitante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cccbe_Solicitante.Properties.DataSource = this.bs_Solicitante;
            this.cccbe_Solicitante.Properties.DisplayMember = "NM_USUARIO";
            this.cccbe_Solicitante.Properties.ValueMember = "LOGIN";
            this.cccbe_Solicitante.Size = new System.Drawing.Size(196, 20);
            this.cccbe_Solicitante.TabIndex = 5;
            // 
            // bs_Solicitante
            // 
            this.bs_Solicitante.DataSource = typeof(Entidades.E_USUARIO);
            // 
            // cccbe_Atendente
            // 
            this.cccbe_Atendente.Location = new System.Drawing.Point(115, 23);
            this.cccbe_Atendente.Name = "cccbe_Atendente";
            this.cccbe_Atendente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cccbe_Atendente.Properties.DataSource = this.bs_Atendente;
            this.cccbe_Atendente.Properties.DisplayMember = "NM_USUARIO";
            this.cccbe_Atendente.Properties.ValueMember = "LOGIN";
            this.cccbe_Atendente.Size = new System.Drawing.Size(200, 20);
            this.cccbe_Atendente.TabIndex = 3;
            // 
            // bs_Atendente
            // 
            this.bs_Atendente.DataSource = typeof(Entidades.E_USUARIO);
            // 
            // clc_Departamento
            // 
            this.clc_Departamento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Departamento.Location = new System.Drawing.Point(517, 46);
            this.clc_Departamento.Name = "clc_Departamento";
            this.clc_Departamento.Size = new System.Drawing.Size(69, 13);
            this.clc_Departamento.TabIndex = 10;
            this.clc_Departamento.Text = "Departamento";
            // 
            // clc_Categoria
            // 
            this.clc_Categoria.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Categoria.Location = new System.Drawing.Point(517, 9);
            this.clc_Categoria.Name = "clc_Categoria";
            this.clc_Categoria.Size = new System.Drawing.Size(47, 13);
            this.clc_Categoria.TabIndex = 6;
            this.clc_Categoria.Text = "Categoria";
            // 
            // cgc_Datas
            // 
            this.cgc_Datas.Appearance.Options.UseTextOptions = true;
            this.cgc_Datas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_Datas.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_Datas.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_Datas.Controls.Add(this.cpc_Datas);
            this.cgc_Datas.Location = new System.Drawing.Point(12, 46);
            this.cgc_Datas.Name = "cgc_Datas";
            this.cgc_Datas.Size = new System.Drawing.Size(365, 71);
            this.cgc_Datas.TabIndex = 0;
            this.cgc_Datas.Text = "Datas";
            // 
            // cpc_Datas
            // 
            this.cpc_Datas.Appearance.Options.UseTextOptions = true;
            this.cpc_Datas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cpc_Datas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_Datas.Controls.Add(this.cce_Finalizado);
            this.cpc_Datas.Controls.Add(this.cce_Previsto);
            this.cpc_Datas.Controls.Add(this.cce_Lancamento);
            this.cpc_Datas.Controls.Add(this.cde_DataInicial);
            this.cpc_Datas.Controls.Add(this.cce_Atendimento);
            this.cpc_Datas.Controls.Add(this.clc_DataInicial);
            this.cpc_Datas.Controls.Add(this.clc_DataFinal);
            this.cpc_Datas.Controls.Add(this.cde_DataFinal);
            this.cpc_Datas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_Datas.Location = new System.Drawing.Point(2, 21);
            this.cpc_Datas.Name = "cpc_Datas";
            this.cpc_Datas.Size = new System.Drawing.Size(361, 48);
            this.cpc_Datas.TabIndex = 0;
            // 
            // cce_Finalizado
            // 
            this.cce_Finalizado.Location = new System.Drawing.Point(272, 24);
            this.cce_Finalizado.Name = "cce_Finalizado";
            this.cce_Finalizado.Properties.AutoWidth = true;
            this.cce_Finalizado.Properties.Caption = "Finalizado";
            this.cce_Finalizado.Size = new System.Drawing.Size(69, 19);
            this.cce_Finalizado.TabIndex = 7;
            this.cce_Finalizado.CheckedChanged += new System.EventHandler(this.Datas_CheckedChanged);
            // 
            // cce_Previsto
            // 
            this.cce_Previsto.Location = new System.Drawing.Point(186, 24);
            this.cce_Previsto.Name = "cce_Previsto";
            this.cce_Previsto.Properties.AutoWidth = true;
            this.cce_Previsto.Properties.Caption = "Previsto";
            this.cce_Previsto.Size = new System.Drawing.Size(61, 19);
            this.cce_Previsto.TabIndex = 5;
            this.cce_Previsto.CheckedChanged += new System.EventHandler(this.Datas_CheckedChanged);
            // 
            // cce_Lancamento
            // 
            this.cce_Lancamento.Location = new System.Drawing.Point(186, 6);
            this.cce_Lancamento.Name = "cce_Lancamento";
            this.cce_Lancamento.Properties.AutoWidth = true;
            this.cce_Lancamento.Properties.Caption = "Lançamento";
            this.cce_Lancamento.Size = new System.Drawing.Size(80, 19);
            this.cce_Lancamento.TabIndex = 4;
            this.cce_Lancamento.CheckedChanged += new System.EventHandler(this.Datas_CheckedChanged);
            // 
            // cde_DataInicial
            // 
            this.cde_DataInicial.DataMaxima = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.cde_DataInicial.DataMinima = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataInicial.Descricao = null;
            this.cde_DataInicial.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataInicial.Location = new System.Drawing.Point(8, 21);
            this.cde_DataInicial.Name = "cde_DataInicial";
            this.cde_DataInicial.NaoVazio = false;
            this.cde_DataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataInicial.Size = new System.Drawing.Size(80, 20);
            this.cde_DataInicial.TabIndex = 1;
            // 
            // cce_Atendimento
            // 
            this.cce_Atendimento.Location = new System.Drawing.Point(272, 6);
            this.cce_Atendimento.Name = "cce_Atendimento";
            this.cce_Atendimento.Properties.AutoWidth = true;
            this.cce_Atendimento.Properties.Caption = "Atendimento";
            this.cce_Atendimento.Size = new System.Drawing.Size(83, 19);
            this.cce_Atendimento.TabIndex = 6;
            this.cce_Atendimento.CheckedChanged += new System.EventHandler(this.Datas_CheckedChanged);
            // 
            // clc_DataInicial
            // 
            this.clc_DataInicial.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_DataInicial.Location = new System.Drawing.Point(8, 7);
            this.clc_DataInicial.Name = "clc_DataInicial";
            this.clc_DataInicial.Size = new System.Drawing.Size(27, 13);
            this.clc_DataInicial.TabIndex = 0;
            this.clc_DataInicial.Text = "Inicial";
            // 
            // clc_DataFinal
            // 
            this.clc_DataFinal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_DataFinal.Location = new System.Drawing.Point(97, 7);
            this.clc_DataFinal.Name = "clc_DataFinal";
            this.clc_DataFinal.Size = new System.Drawing.Size(22, 13);
            this.clc_DataFinal.TabIndex = 2;
            this.clc_DataFinal.Text = "Final";
            // 
            // cde_DataFinal
            // 
            this.cde_DataFinal.DataMaxima = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.cde_DataFinal.DataMinima = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataFinal.Descricao = null;
            this.cde_DataFinal.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cde_DataFinal.Location = new System.Drawing.Point(97, 21);
            this.cde_DataFinal.Name = "cde_DataFinal";
            this.cde_DataFinal.NaoVazio = false;
            this.cde_DataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DataFinal.Size = new System.Drawing.Size(80, 20);
            this.cde_DataFinal.TabIndex = 3;
            // 
            // clc_Prioridade
            // 
            this.clc_Prioridade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Prioridade.Location = new System.Drawing.Point(383, 83);
            this.clc_Prioridade.Name = "clc_Prioridade";
            this.clc_Prioridade.Size = new System.Drawing.Size(48, 13);
            this.clc_Prioridade.TabIndex = 13;
            this.clc_Prioridade.Text = "Prioridade";
            // 
            // clc_Status
            // 
            this.clc_Status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Status.Location = new System.Drawing.Point(383, 46);
            this.clc_Status.Name = "clc_Status";
            this.clc_Status.Size = new System.Drawing.Size(31, 13);
            this.clc_Status.TabIndex = 8;
            this.clc_Status.Text = "Status";
            // 
            // clc_Solicitante
            // 
            this.clc_Solicitante.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Solicitante.Location = new System.Drawing.Point(318, 9);
            this.clc_Solicitante.Name = "clc_Solicitante";
            this.clc_Solicitante.Size = new System.Drawing.Size(49, 13);
            this.clc_Solicitante.TabIndex = 4;
            this.clc_Solicitante.Text = "Solicitante";
            // 
            // clc_Atendente
            // 
            this.clc_Atendente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Atendente.Location = new System.Drawing.Point(115, 9);
            this.clc_Atendente.Name = "clc_Atendente";
            this.clc_Atendente.Size = new System.Drawing.Size(51, 13);
            this.clc_Atendente.TabIndex = 2;
            this.clc_Atendente.Text = "Atendente";
            // 
            // clc_Identificador
            // 
            this.clc_Identificador.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clc_Identificador.Location = new System.Drawing.Point(12, 9);
            this.clc_Identificador.Name = "clc_Identificador";
            this.clc_Identificador.Size = new System.Drawing.Size(61, 13);
            this.clc_Identificador.TabIndex = 0;
            this.clc_Identificador.Text = "Identificador";
            // 
            // pm_Menu
            // 
            this.pm_Menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_200),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_1000),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Buscar_Todos, true)});
            this.pm_Menu.Manager = this.bm_Menu;
            this.pm_Menu.Name = "pm_Menu";
            // 
            // xtc_Abas
            // 
            this.xtc_Abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtc_Abas.Location = new System.Drawing.Point(0, 200);
            this.xtc_Abas.Name = "xtc_Abas";
            this.xtc_Abas.SelectedTabPage = this.xtp_Chamado;
            this.xtc_Abas.Size = new System.Drawing.Size(719, 367);
            this.xtc_Abas.TabIndex = 2;
            this.xtc_Abas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtp_Chamado,
            this.xtp_ChamadoDetalhes,
            this.xtp_ChamadoEvolucoes});
            // 
            // xtp_Chamado
            // 
            this.xtp_Chamado.Controls.Add(this.gc_Chamado);
            this.xtp_Chamado.Name = "xtp_Chamado";
            this.xtp_Chamado.Size = new System.Drawing.Size(713, 339);
            this.xtp_Chamado.Text = "Chamados";
            // 
            // gc_Chamado
            // 
            this.gc_Chamado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Chamado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Chamado.Location = new System.Drawing.Point(0, 0);
            this.gc_Chamado.MainView = this.gv_Chamado;
            this.gc_Chamado.Name = "gc_Chamado";
            this.gc_Chamado.Size = new System.Drawing.Size(713, 339);
            this.gc_Chamado.TabIndex = 0;
            this.gc_Chamado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Chamado});
            // 
            // gv_Chamado
            // 
            this.gv_Chamado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_CHAMADO,
            this.colCATEGORIA,
            this.colDEPARTAMENTO,
            this.colDEPARTAMENTO_SOLICITANTE,
            this.colLOGIN_SOLICITANTE,
            this.colLOGIN_ATENDENTE,
            this.colDS_CHAMADO,
            this.colDS_OBSERVACAO,
            this.colDS_SOLUCAO,
            this.colESTIMATIVA_TEMPO,
            this.colID_PRIORIDADE,
            this.colDS_PRIORIDADE,
            this.colST_CHAMADO,
            this.colDT_CHAMADO,
            this.colDT_PREVISTA,
            this.colDT_FINALIZADO,
            this.colDT_ATENDIMENTO,
            this.colDT_REQUERIDA,
            this.colDT_ULTIMAEVOLUCAO,
            this.colST_EVOLUCAO,
            this.colDS_RESUMO,
            this.colGRAVIDADE,
            this.colST_SOLICITANTE,
            this.colEVOLUCAO});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightGreen;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colST_CHAMADO;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "FECHADO";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Appearance.Options.UseTextOptions = true;
            styleFormatCondition2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            styleFormatCondition2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition2.Column = this.colGRAVIDADE;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "ALTA";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Appearance.Options.UseTextOptions = true;
            styleFormatCondition3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            styleFormatCondition3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition3.Column = this.colGRAVIDADE;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "MÉDIA";
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Blue;
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Appearance.Options.UseTextOptions = true;
            styleFormatCondition4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            styleFormatCondition4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            styleFormatCondition4.Column = this.colGRAVIDADE;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = "BAIXA";
            this.gv_Chamado.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4});
            this.gv_Chamado.GridControl = this.gc_Chamado;
            this.gv_Chamado.GroupCount = 2;
            this.gv_Chamado.Name = "gv_Chamado";
            this.gv_Chamado.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Chamado.OptionsFind.AlwaysVisible = true;
            this.gv_Chamado.OptionsView.ColumnAutoWidth = false;
            this.gv_Chamado.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDS_PRIORIDADE, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDT_CHAMADO, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_CHAMADO, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_Chamado.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Chamado_RowClick);
            // 
            // colID_CHAMADO
            // 
            this.colID_CHAMADO.Caption = "Identificador";
            this.colID_CHAMADO.FieldName = "ID_CHAMADO";
            this.colID_CHAMADO.Name = "colID_CHAMADO";
            this.colID_CHAMADO.OptionsColumn.AllowEdit = false;
            this.colID_CHAMADO.OptionsColumn.AllowFocus = false;
            this.colID_CHAMADO.Visible = true;
            this.colID_CHAMADO.VisibleIndex = 0;
            this.colID_CHAMADO.Width = 84;
            // 
            // colCATEGORIA
            // 
            this.colCATEGORIA.Caption = "Categoria";
            this.colCATEGORIA.FieldName = "CATEGORIA";
            this.colCATEGORIA.Name = "colCATEGORIA";
            this.colCATEGORIA.OptionsColumn.AllowEdit = false;
            this.colCATEGORIA.OptionsColumn.AllowFocus = false;
            this.colCATEGORIA.Visible = true;
            this.colCATEGORIA.VisibleIndex = 1;
            // 
            // colDEPARTAMENTO
            // 
            this.colDEPARTAMENTO.Caption = "Departamento";
            this.colDEPARTAMENTO.FieldName = "DEPARTAMENTO";
            this.colDEPARTAMENTO.Name = "colDEPARTAMENTO";
            this.colDEPARTAMENTO.OptionsColumn.AllowEdit = false;
            this.colDEPARTAMENTO.OptionsColumn.AllowFocus = false;
            this.colDEPARTAMENTO.Visible = true;
            this.colDEPARTAMENTO.VisibleIndex = 2;
            this.colDEPARTAMENTO.Width = 81;
            // 
            // colDEPARTAMENTO_SOLICITANTE
            // 
            this.colDEPARTAMENTO_SOLICITANTE.Caption = "Departamento (solicitante)";
            this.colDEPARTAMENTO_SOLICITANTE.FieldName = "DEPARTAMENTO_SOLICITANTE";
            this.colDEPARTAMENTO_SOLICITANTE.Name = "colDEPARTAMENTO_SOLICITANTE";
            this.colDEPARTAMENTO_SOLICITANTE.OptionsColumn.AllowEdit = false;
            this.colDEPARTAMENTO_SOLICITANTE.OptionsColumn.AllowFocus = false;
            this.colDEPARTAMENTO_SOLICITANTE.Visible = true;
            this.colDEPARTAMENTO_SOLICITANTE.VisibleIndex = 3;
            this.colDEPARTAMENTO_SOLICITANTE.Width = 138;
            // 
            // colLOGIN_SOLICITANTE
            // 
            this.colLOGIN_SOLICITANTE.Caption = "Solicitante";
            this.colLOGIN_SOLICITANTE.FieldName = "LOGIN_SOLICITANTE";
            this.colLOGIN_SOLICITANTE.Name = "colLOGIN_SOLICITANTE";
            this.colLOGIN_SOLICITANTE.OptionsColumn.AllowEdit = false;
            this.colLOGIN_SOLICITANTE.OptionsColumn.AllowFocus = false;
            this.colLOGIN_SOLICITANTE.Visible = true;
            this.colLOGIN_SOLICITANTE.VisibleIndex = 4;
            // 
            // colLOGIN_ATENDENTE
            // 
            this.colLOGIN_ATENDENTE.Caption = "Atendente";
            this.colLOGIN_ATENDENTE.FieldName = "LOGIN_ATENDENTE";
            this.colLOGIN_ATENDENTE.Name = "colLOGIN_ATENDENTE";
            this.colLOGIN_ATENDENTE.OptionsColumn.AllowEdit = false;
            this.colLOGIN_ATENDENTE.OptionsColumn.AllowFocus = false;
            this.colLOGIN_ATENDENTE.Visible = true;
            this.colLOGIN_ATENDENTE.VisibleIndex = 5;
            // 
            // colDS_CHAMADO
            // 
            this.colDS_CHAMADO.Caption = "Descrição";
            this.colDS_CHAMADO.FieldName = "DS_CHAMADO";
            this.colDS_CHAMADO.Name = "colDS_CHAMADO";
            this.colDS_CHAMADO.OptionsColumn.AllowEdit = false;
            this.colDS_CHAMADO.OptionsColumn.AllowFocus = false;
            // 
            // colDS_OBSERVACAO
            // 
            this.colDS_OBSERVACAO.Caption = "Observação";
            this.colDS_OBSERVACAO.FieldName = "DS_OBSERVACAO";
            this.colDS_OBSERVACAO.Name = "colDS_OBSERVACAO";
            this.colDS_OBSERVACAO.OptionsColumn.AllowEdit = false;
            this.colDS_OBSERVACAO.OptionsColumn.AllowFocus = false;
            // 
            // colDS_SOLUCAO
            // 
            this.colDS_SOLUCAO.Caption = "Solução";
            this.colDS_SOLUCAO.FieldName = "DS_SOLUCAO";
            this.colDS_SOLUCAO.Name = "colDS_SOLUCAO";
            this.colDS_SOLUCAO.OptionsColumn.AllowEdit = false;
            this.colDS_SOLUCAO.OptionsColumn.AllowFocus = false;
            // 
            // colESTIMATIVA_TEMPO
            // 
            this.colESTIMATIVA_TEMPO.Caption = "Estimativa (tempo)";
            this.colESTIMATIVA_TEMPO.FieldName = "ESTIMATIVA_TEMPO";
            this.colESTIMATIVA_TEMPO.Name = "colESTIMATIVA_TEMPO";
            this.colESTIMATIVA_TEMPO.OptionsColumn.AllowEdit = false;
            this.colESTIMATIVA_TEMPO.OptionsColumn.AllowFocus = false;
            this.colESTIMATIVA_TEMPO.Width = 102;
            // 
            // colID_PRIORIDADE
            // 
            this.colID_PRIORIDADE.Caption = "Prioridade";
            this.colID_PRIORIDADE.FieldName = "PRIORIDADE.ID_PRIORIDADE";
            this.colID_PRIORIDADE.Name = "colID_PRIORIDADE";
            this.colID_PRIORIDADE.OptionsColumn.AllowEdit = false;
            this.colID_PRIORIDADE.OptionsColumn.AllowFocus = false;
            // 
            // colDS_PRIORIDADE
            // 
            this.colDS_PRIORIDADE.Caption = "Prioridade";
            this.colDS_PRIORIDADE.FieldName = "PRIORIDADE.DS_PRIORIDADE";
            this.colDS_PRIORIDADE.Name = "colDS_PRIORIDADE";
            this.colDS_PRIORIDADE.OptionsColumn.AllowEdit = false;
            this.colDS_PRIORIDADE.OptionsColumn.AllowFocus = false;
            this.colDS_PRIORIDADE.Visible = true;
            this.colDS_PRIORIDADE.VisibleIndex = 9;
            // 
            // colDT_CHAMADO
            // 
            this.colDT_CHAMADO.Caption = "Data (aberto)";
            this.colDT_CHAMADO.DisplayFormat.FormatString = "g";
            this.colDT_CHAMADO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_CHAMADO.FieldName = "DT_CHAMADO";
            this.colDT_CHAMADO.GroupFormat.FormatString = "d";
            this.colDT_CHAMADO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_CHAMADO.Name = "colDT_CHAMADO";
            this.colDT_CHAMADO.OptionsColumn.AllowEdit = false;
            this.colDT_CHAMADO.OptionsColumn.AllowFocus = false;
            this.colDT_CHAMADO.Visible = true;
            this.colDT_CHAMADO.VisibleIndex = 10;
            this.colDT_CHAMADO.Width = 91;
            // 
            // colDT_PREVISTA
            // 
            this.colDT_PREVISTA.Caption = "Data (prevista)";
            this.colDT_PREVISTA.DisplayFormat.FormatString = "g";
            this.colDT_PREVISTA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_PREVISTA.FieldName = "DT_PREVISTA";
            this.colDT_PREVISTA.GroupFormat.FormatString = "d";
            this.colDT_PREVISTA.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_PREVISTA.Name = "colDT_PREVISTA";
            this.colDT_PREVISTA.OptionsColumn.AllowEdit = false;
            this.colDT_PREVISTA.OptionsColumn.AllowFocus = false;
            this.colDT_PREVISTA.Visible = true;
            this.colDT_PREVISTA.VisibleIndex = 8;
            this.colDT_PREVISTA.Width = 85;
            // 
            // colDT_FINALIZADO
            // 
            this.colDT_FINALIZADO.Caption = "Data (finalizado)";
            this.colDT_FINALIZADO.DisplayFormat.FormatString = "g";
            this.colDT_FINALIZADO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_FINALIZADO.FieldName = "DT_FINALIZADO";
            this.colDT_FINALIZADO.GroupFormat.FormatString = "d";
            this.colDT_FINALIZADO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_FINALIZADO.Name = "colDT_FINALIZADO";
            this.colDT_FINALIZADO.OptionsColumn.AllowEdit = false;
            this.colDT_FINALIZADO.OptionsColumn.AllowFocus = false;
            this.colDT_FINALIZADO.Visible = true;
            this.colDT_FINALIZADO.VisibleIndex = 9;
            this.colDT_FINALIZADO.Width = 91;
            // 
            // colDT_ATENDIMENTO
            // 
            this.colDT_ATENDIMENTO.Caption = "Data (atendimento)";
            this.colDT_ATENDIMENTO.DisplayFormat.FormatString = "g";
            this.colDT_ATENDIMENTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_ATENDIMENTO.FieldName = "DT_ATENDIMENTO";
            this.colDT_ATENDIMENTO.GroupFormat.FormatString = "d";
            this.colDT_ATENDIMENTO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_ATENDIMENTO.Name = "colDT_ATENDIMENTO";
            this.colDT_ATENDIMENTO.OptionsColumn.AllowEdit = false;
            this.colDT_ATENDIMENTO.OptionsColumn.AllowFocus = false;
            this.colDT_ATENDIMENTO.Visible = true;
            this.colDT_ATENDIMENTO.VisibleIndex = 10;
            this.colDT_ATENDIMENTO.Width = 106;
            // 
            // colDT_REQUERIDA
            // 
            this.colDT_REQUERIDA.Caption = "Data (requerida)";
            this.colDT_REQUERIDA.DisplayFormat.FormatString = "g";
            this.colDT_REQUERIDA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_REQUERIDA.FieldName = "DT_REQUERIDA";
            this.colDT_REQUERIDA.GroupFormat.FormatString = "d";
            this.colDT_REQUERIDA.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_REQUERIDA.Name = "colDT_REQUERIDA";
            this.colDT_REQUERIDA.OptionsColumn.AllowEdit = false;
            this.colDT_REQUERIDA.OptionsColumn.AllowFocus = false;
            this.colDT_REQUERIDA.Visible = true;
            this.colDT_REQUERIDA.VisibleIndex = 7;
            this.colDT_REQUERIDA.Width = 92;
            // 
            // colDT_ULTIMAEVOLUCAO
            // 
            this.colDT_ULTIMAEVOLUCAO.Caption = "Data (ultima evolução)";
            this.colDT_ULTIMAEVOLUCAO.DisplayFormat.FormatString = "g";
            this.colDT_ULTIMAEVOLUCAO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_ULTIMAEVOLUCAO.FieldName = "DT_ULTIMAEVOLUCAO";
            this.colDT_ULTIMAEVOLUCAO.GroupFormat.FormatString = "d";
            this.colDT_ULTIMAEVOLUCAO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_ULTIMAEVOLUCAO.Name = "colDT_ULTIMAEVOLUCAO";
            this.colDT_ULTIMAEVOLUCAO.OptionsColumn.AllowEdit = false;
            this.colDT_ULTIMAEVOLUCAO.OptionsColumn.AllowFocus = false;
            this.colDT_ULTIMAEVOLUCAO.Visible = true;
            this.colDT_ULTIMAEVOLUCAO.VisibleIndex = 11;
            this.colDT_ULTIMAEVOLUCAO.Width = 120;
            // 
            // colST_EVOLUCAO
            // 
            this.colST_EVOLUCAO.Caption = "Evolução";
            this.colST_EVOLUCAO.FieldName = "ST_EVOLUCAO";
            this.colST_EVOLUCAO.Name = "colST_EVOLUCAO";
            this.colST_EVOLUCAO.OptionsColumn.AllowEdit = false;
            this.colST_EVOLUCAO.OptionsColumn.AllowFocus = false;
            this.colST_EVOLUCAO.Visible = true;
            this.colST_EVOLUCAO.VisibleIndex = 13;
            // 
            // colDS_RESUMO
            // 
            this.colDS_RESUMO.Caption = "Resumo";
            this.colDS_RESUMO.FieldName = "DS_RESUMO";
            this.colDS_RESUMO.Name = "colDS_RESUMO";
            this.colDS_RESUMO.OptionsColumn.AllowEdit = false;
            this.colDS_RESUMO.OptionsColumn.AllowFocus = false;
            this.colDS_RESUMO.Visible = true;
            this.colDS_RESUMO.VisibleIndex = 12;
            // 
            // colST_SOLICITANTE
            // 
            this.colST_SOLICITANTE.Caption = "Status solicitante";
            this.colST_SOLICITANTE.FieldName = "ST_SOLICITANTE";
            this.colST_SOLICITANTE.Name = "colST_SOLICITANTE";
            this.colST_SOLICITANTE.OptionsColumn.AllowEdit = false;
            this.colST_SOLICITANTE.OptionsColumn.AllowFocus = false;
            this.colST_SOLICITANTE.Visible = true;
            this.colST_SOLICITANTE.VisibleIndex = 16;
            this.colST_SOLICITANTE.Width = 92;
            // 
            // colEVOLUCAO
            // 
            this.colEVOLUCAO.Caption = "Evolução";
            this.colEVOLUCAO.FieldName = "EVOLUCAO";
            this.colEVOLUCAO.Name = "colEVOLUCAO";
            this.colEVOLUCAO.OptionsColumn.AllowEdit = false;
            this.colEVOLUCAO.OptionsColumn.AllowFocus = false;
            this.colEVOLUCAO.Visible = true;
            this.colEVOLUCAO.VisibleIndex = 15;
            // 
            // xtp_ChamadoDetalhes
            // 
            this.xtp_ChamadoDetalhes.Controls.Add(this.cpc_DadosGerais);
            this.xtp_ChamadoDetalhes.Name = "xtp_ChamadoDetalhes";
            this.xtp_ChamadoDetalhes.PageVisible = false;
            this.xtp_ChamadoDetalhes.Size = new System.Drawing.Size(713, 339);
            this.xtp_ChamadoDetalhes.Text = "Detalhes";
            // 
            // cpc_DadosGerais
            // 
            this.cpc_DadosGerais.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cpc_DadosGerais.Appearance.Options.UseBackColor = true;
            this.cpc_DadosGerais.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cpc_DadosGerais.Controls.Add(this.cte_DetalhesCategoria);
            this.cpc_DadosGerais.Controls.Add(this.cte_DetalhesApartamento);
            this.cpc_DadosGerais.Controls.Add(this.cde_DetalhesDataRequerida);
            this.cpc_DadosGerais.Controls.Add(this.cgc_DetalhesAnexos);
            this.cpc_DadosGerais.Controls.Add(this.clc_Detalhes_DataRequerida);
            this.cpc_DadosGerais.Controls.Add(this.cme_DetalhesDescricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_DetalhesDescricao);
            this.cpc_DadosGerais.Controls.Add(this.clc_DetalhesDepartamento);
            this.cpc_DadosGerais.Controls.Add(this.clc_DetalhesCategoria);
            this.cpc_DadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_DadosGerais.Location = new System.Drawing.Point(0, 0);
            this.cpc_DadosGerais.Name = "cpc_DadosGerais";
            this.cpc_DadosGerais.Size = new System.Drawing.Size(713, 339);
            this.cpc_DadosGerais.TabIndex = 1;
            // 
            // cte_DetalhesCategoria
            // 
            this.cte_DetalhesCategoria.Descricao = null;
            this.cte_DetalhesCategoria.Location = new System.Drawing.Point(317, 23);
            this.cte_DetalhesCategoria.Mascara_IPv4 = false;
            this.cte_DetalhesCategoria.Mascara_PortaIPv4 = false;
            this.cte_DetalhesCategoria.MenuManager = this.bm_Menu;
            this.cte_DetalhesCategoria.Name = "cte_DetalhesCategoria";
            this.cte_DetalhesCategoria.NaoVazio = false;
            this.cte_DetalhesCategoria.Properties.ReadOnly = true;
            this.cte_DetalhesCategoria.SemAcentuacao = false;
            this.cte_DetalhesCategoria.SemPontuacao = false;
            this.cte_DetalhesCategoria.Size = new System.Drawing.Size(268, 20);
            this.cte_DetalhesCategoria.SomenteNumeros = false;
            this.cte_DetalhesCategoria.TabIndex = 10;
            // 
            // cte_DetalhesApartamento
            // 
            this.cte_DetalhesApartamento.Descricao = null;
            this.cte_DetalhesApartamento.Location = new System.Drawing.Point(12, 23);
            this.cte_DetalhesApartamento.Mascara_IPv4 = false;
            this.cte_DetalhesApartamento.Mascara_PortaIPv4 = false;
            this.cte_DetalhesApartamento.MenuManager = this.bm_Menu;
            this.cte_DetalhesApartamento.Name = "cte_DetalhesApartamento";
            this.cte_DetalhesApartamento.NaoVazio = false;
            this.cte_DetalhesApartamento.Properties.ReadOnly = true;
            this.cte_DetalhesApartamento.SemAcentuacao = false;
            this.cte_DetalhesApartamento.SemPontuacao = false;
            this.cte_DetalhesApartamento.Size = new System.Drawing.Size(302, 20);
            this.cte_DetalhesApartamento.SomenteNumeros = false;
            this.cte_DetalhesApartamento.TabIndex = 9;
            // 
            // cde_DetalhesDataRequerida
            // 
            this.cde_DetalhesDataRequerida.DataMaxima = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.cde_DetalhesDataRequerida.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DetalhesDataRequerida.Descricao = "a data requerida";
            this.cde_DetalhesDataRequerida.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_DetalhesDataRequerida.Location = new System.Drawing.Point(588, 23);
            this.cde_DetalhesDataRequerida.Name = "cde_DetalhesDataRequerida";
            this.cde_DetalhesDataRequerida.NaoVazio = false;
            this.cde_DetalhesDataRequerida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DetalhesDataRequerida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_DetalhesDataRequerida.Properties.DisplayFormat.FormatString = "g";
            this.cde_DetalhesDataRequerida.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DetalhesDataRequerida.Properties.EditFormat.FormatString = "g";
            this.cde_DetalhesDataRequerida.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_DetalhesDataRequerida.Properties.Mask.EditMask = "g";
            this.cde_DetalhesDataRequerida.Properties.ReadOnly = true;
            this.cde_DetalhesDataRequerida.Size = new System.Drawing.Size(114, 20);
            this.cde_DetalhesDataRequerida.TabIndex = 5;
            // 
            // cgc_DetalhesAnexos
            // 
            this.cgc_DetalhesAnexos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cgc_DetalhesAnexos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cgc_DetalhesAnexos.Appearance.Options.UseBackColor = true;
            this.cgc_DetalhesAnexos.Appearance.Options.UseTextOptions = true;
            this.cgc_DetalhesAnexos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_DetalhesAnexos.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_DetalhesAnexos.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_DetalhesAnexos.Controls.Add(this.lbc_DetalhesAnexos);
            this.cgc_DetalhesAnexos.Location = new System.Drawing.Point(11, 216);
            this.cgc_DetalhesAnexos.Name = "cgc_DetalhesAnexos";
            this.cgc_DetalhesAnexos.Size = new System.Drawing.Size(691, 110);
            this.cgc_DetalhesAnexos.TabIndex = 8;
            this.cgc_DetalhesAnexos.Text = "Anexos";
            // 
            // lbc_DetalhesAnexos
            // 
            this.lbc_DetalhesAnexos.DataSource = this.bs_DetalhesAnexos;
            this.lbc_DetalhesAnexos.DisplayMember = "NM_ANEXO";
            this.lbc_DetalhesAnexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_DetalhesAnexos.Location = new System.Drawing.Point(2, 21);
            this.lbc_DetalhesAnexos.Name = "lbc_DetalhesAnexos";
            this.lbc_DetalhesAnexos.Size = new System.Drawing.Size(687, 87);
            this.lbc_DetalhesAnexos.TabIndex = 1;
            this.lbc_DetalhesAnexos.ValueMember = "ID_ANEXO";
            this.lbc_DetalhesAnexos.DoubleClick += new System.EventHandler(this.lbc_DetalhesAnexos_DoubleClick);
            // 
            // bs_DetalhesAnexos
            // 
            this.bs_DetalhesAnexos.DataSource = typeof(Entidades.E_ANEXO);
            // 
            // clc_Detalhes_DataRequerida
            // 
            this.clc_Detalhes_DataRequerida.Location = new System.Drawing.Point(588, 9);
            this.clc_Detalhes_DataRequerida.Name = "clc_Detalhes_DataRequerida";
            this.clc_Detalhes_DataRequerida.Size = new System.Drawing.Size(72, 13);
            this.clc_Detalhes_DataRequerida.TabIndex = 4;
            this.clc_Detalhes_DataRequerida.Text = "Data requerida";
            // 
            // cme_DetalhesDescricao
            // 
            this.cme_DetalhesDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cme_DetalhesDescricao.Descricao = "a descrição";
            this.cme_DetalhesDescricao.Location = new System.Drawing.Point(12, 61);
            this.cme_DetalhesDescricao.Name = "cme_DetalhesDescricao";
            this.cme_DetalhesDescricao.NaoVazio = true;
            this.cme_DetalhesDescricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_DetalhesDescricao.Properties.ReadOnly = true;
            this.cme_DetalhesDescricao.SemAcentuacao = false;
            this.cme_DetalhesDescricao.SemPontuacao = false;
            this.cme_DetalhesDescricao.Size = new System.Drawing.Size(690, 149);
            this.cme_DetalhesDescricao.SomenteNumeros = false;
            this.cme_DetalhesDescricao.TabIndex = 7;
            this.cme_DetalhesDescricao.UseOptimizedRendering = true;
            // 
            // clc_DetalhesDescricao
            // 
            this.clc_DetalhesDescricao.Location = new System.Drawing.Point(12, 47);
            this.clc_DetalhesDescricao.Name = "clc_DetalhesDescricao";
            this.clc_DetalhesDescricao.Size = new System.Drawing.Size(46, 13);
            this.clc_DetalhesDescricao.TabIndex = 6;
            this.clc_DetalhesDescricao.Text = "Descrição";
            // 
            // clc_DetalhesDepartamento
            // 
            this.clc_DetalhesDepartamento.Location = new System.Drawing.Point(12, 9);
            this.clc_DetalhesDepartamento.Name = "clc_DetalhesDepartamento";
            this.clc_DetalhesDepartamento.Size = new System.Drawing.Size(69, 13);
            this.clc_DetalhesDepartamento.TabIndex = 0;
            this.clc_DetalhesDepartamento.Text = "Departamento";
            // 
            // clc_DetalhesCategoria
            // 
            this.clc_DetalhesCategoria.Location = new System.Drawing.Point(317, 9);
            this.clc_DetalhesCategoria.Name = "clc_DetalhesCategoria";
            this.clc_DetalhesCategoria.Size = new System.Drawing.Size(47, 13);
            this.clc_DetalhesCategoria.TabIndex = 2;
            this.clc_DetalhesCategoria.Text = "Categoria";
            // 
            // xtp_ChamadoEvolucoes
            // 
            this.xtp_ChamadoEvolucoes.Controls.Add(this.gc_DetalhesEvolucoes);
            this.xtp_ChamadoEvolucoes.Controls.Add(this.gc_Evolucoes);
            this.xtp_ChamadoEvolucoes.Name = "xtp_ChamadoEvolucoes";
            this.xtp_ChamadoEvolucoes.PageVisible = false;
            this.xtp_ChamadoEvolucoes.Size = new System.Drawing.Size(713, 339);
            this.xtp_ChamadoEvolucoes.Text = "Evoluções";
            // 
            // gc_DetalhesEvolucoes
            // 
            this.gc_DetalhesEvolucoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_DetalhesEvolucoes.Controls.Add(this.cme_EvolucaoObservacao);
            this.gc_DetalhesEvolucoes.Controls.Add(this.clc_EvolucaoObservacao);
            this.gc_DetalhesEvolucoes.Controls.Add(this.cte_EvolucaoStatus);
            this.gc_DetalhesEvolucoes.Controls.Add(this.clc_EvolucaoStatus);
            this.gc_DetalhesEvolucoes.Controls.Add(this.cde_EvolucaoData);
            this.gc_DetalhesEvolucoes.Controls.Add(this.clc_EvolucaoData);
            this.gc_DetalhesEvolucoes.Controls.Add(this.cgc_EvolucaoAnexos);
            this.gc_DetalhesEvolucoes.Location = new System.Drawing.Point(10, 105);
            this.gc_DetalhesEvolucoes.Name = "gc_DetalhesEvolucoes";
            this.gc_DetalhesEvolucoes.Size = new System.Drawing.Size(693, 222);
            this.gc_DetalhesEvolucoes.TabIndex = 1;
            this.gc_DetalhesEvolucoes.Text = "Detalhes da evolução selecionada acima";
            // 
            // cme_EvolucaoObservacao
            // 
            this.cme_EvolucaoObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cme_EvolucaoObservacao.Descricao = "a descrição";
            this.cme_EvolucaoObservacao.Location = new System.Drawing.Point(9, 77);
            this.cme_EvolucaoObservacao.Name = "cme_EvolucaoObservacao";
            this.cme_EvolucaoObservacao.NaoVazio = true;
            this.cme_EvolucaoObservacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cme_EvolucaoObservacao.Properties.ReadOnly = true;
            this.cme_EvolucaoObservacao.SemAcentuacao = false;
            this.cme_EvolucaoObservacao.SemPontuacao = false;
            this.cme_EvolucaoObservacao.Size = new System.Drawing.Size(674, 51);
            this.cme_EvolucaoObservacao.SomenteNumeros = false;
            this.cme_EvolucaoObservacao.TabIndex = 15;
            this.cme_EvolucaoObservacao.UseOptimizedRendering = true;
            // 
            // clc_EvolucaoObservacao
            // 
            this.clc_EvolucaoObservacao.Location = new System.Drawing.Point(9, 63);
            this.clc_EvolucaoObservacao.Name = "clc_EvolucaoObservacao";
            this.clc_EvolucaoObservacao.Size = new System.Drawing.Size(58, 13);
            this.clc_EvolucaoObservacao.TabIndex = 14;
            this.clc_EvolucaoObservacao.Text = "Observação";
            // 
            // cte_EvolucaoStatus
            // 
            this.cte_EvolucaoStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cte_EvolucaoStatus.Descricao = null;
            this.cte_EvolucaoStatus.Location = new System.Drawing.Point(122, 39);
            this.cte_EvolucaoStatus.Mascara_IPv4 = false;
            this.cte_EvolucaoStatus.Mascara_PortaIPv4 = false;
            this.cte_EvolucaoStatus.MenuManager = this.bm_Menu;
            this.cte_EvolucaoStatus.Name = "cte_EvolucaoStatus";
            this.cte_EvolucaoStatus.NaoVazio = false;
            this.cte_EvolucaoStatus.Properties.ReadOnly = true;
            this.cte_EvolucaoStatus.SemAcentuacao = false;
            this.cte_EvolucaoStatus.SemPontuacao = false;
            this.cte_EvolucaoStatus.Size = new System.Drawing.Size(561, 20);
            this.cte_EvolucaoStatus.SomenteNumeros = false;
            this.cte_EvolucaoStatus.TabIndex = 13;
            // 
            // clc_EvolucaoStatus
            // 
            this.clc_EvolucaoStatus.Location = new System.Drawing.Point(122, 25);
            this.clc_EvolucaoStatus.Name = "clc_EvolucaoStatus";
            this.clc_EvolucaoStatus.Size = new System.Drawing.Size(31, 13);
            this.clc_EvolucaoStatus.TabIndex = 12;
            this.clc_EvolucaoStatus.Text = "Status";
            // 
            // cde_EvolucaoData
            // 
            this.cde_EvolucaoData.DataMaxima = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.cde_EvolucaoData.DataMinima = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_EvolucaoData.Descricao = "a data requerida";
            this.cde_EvolucaoData.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cde_EvolucaoData.Location = new System.Drawing.Point(9, 39);
            this.cde_EvolucaoData.Name = "cde_EvolucaoData";
            this.cde_EvolucaoData.NaoVazio = false;
            this.cde_EvolucaoData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_EvolucaoData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cde_EvolucaoData.Properties.DisplayFormat.FormatString = "g";
            this.cde_EvolucaoData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_EvolucaoData.Properties.EditFormat.FormatString = "g";
            this.cde_EvolucaoData.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cde_EvolucaoData.Properties.Mask.EditMask = "g";
            this.cde_EvolucaoData.Properties.ReadOnly = true;
            this.cde_EvolucaoData.Size = new System.Drawing.Size(110, 20);
            this.cde_EvolucaoData.TabIndex = 11;
            // 
            // clc_EvolucaoData
            // 
            this.clc_EvolucaoData.Location = new System.Drawing.Point(9, 25);
            this.clc_EvolucaoData.Name = "clc_EvolucaoData";
            this.clc_EvolucaoData.Size = new System.Drawing.Size(23, 13);
            this.clc_EvolucaoData.TabIndex = 10;
            this.clc_EvolucaoData.Text = "Data";
            // 
            // cgc_EvolucaoAnexos
            // 
            this.cgc_EvolucaoAnexos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cgc_EvolucaoAnexos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cgc_EvolucaoAnexos.Appearance.Options.UseBackColor = true;
            this.cgc_EvolucaoAnexos.Appearance.Options.UseTextOptions = true;
            this.cgc_EvolucaoAnexos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_EvolucaoAnexos.AppearanceCaption.Options.UseTextOptions = true;
            this.cgc_EvolucaoAnexos.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cgc_EvolucaoAnexos.Controls.Add(this.lbc_EvolucaoAnexos);
            this.cgc_EvolucaoAnexos.Location = new System.Drawing.Point(9, 134);
            this.cgc_EvolucaoAnexos.Name = "cgc_EvolucaoAnexos";
            this.cgc_EvolucaoAnexos.Size = new System.Drawing.Size(674, 80);
            this.cgc_EvolucaoAnexos.TabIndex = 9;
            this.cgc_EvolucaoAnexos.Text = "Anexos";
            // 
            // lbc_EvolucaoAnexos
            // 
            this.lbc_EvolucaoAnexos.DataSource = this.bs_EvolucoesAnexos;
            this.lbc_EvolucaoAnexos.DisplayMember = "NM_ANEXO";
            this.lbc_EvolucaoAnexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_EvolucaoAnexos.Location = new System.Drawing.Point(2, 21);
            this.lbc_EvolucaoAnexos.Name = "lbc_EvolucaoAnexos";
            this.lbc_EvolucaoAnexos.Size = new System.Drawing.Size(670, 57);
            this.lbc_EvolucaoAnexos.TabIndex = 1;
            this.lbc_EvolucaoAnexos.ValueMember = "ID_ANEXO";
            this.lbc_EvolucaoAnexos.DoubleClick += new System.EventHandler(this.lbc_DoubleClick);
            // 
            // bs_EvolucoesAnexos
            // 
            this.bs_EvolucoesAnexos.DataSource = typeof(Entidades.E_ANEXO);
            // 
            // gc_Evolucoes
            // 
            this.gc_Evolucoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_Evolucoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_Evolucoes.Location = new System.Drawing.Point(0, 0);
            this.gc_Evolucoes.MainView = this.gv_Evolucoes;
            this.gc_Evolucoes.MenuManager = this.bm_Menu;
            this.gc_Evolucoes.Name = "gc_Evolucoes";
            this.gc_Evolucoes.Size = new System.Drawing.Size(713, 95);
            this.gc_Evolucoes.TabIndex = 0;
            this.gc_Evolucoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Evolucoes});
            // 
            // gv_Evolucoes
            // 
            this.gv_Evolucoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_EVENTO,
            this.colDT_EVENTO,
            this.colSTATUS,
            this.colDS_EVENTO,
            this.colEVOLUCAO_LOGINATENDENTE});
            this.gv_Evolucoes.GridControl = this.gc_Evolucoes;
            this.gv_Evolucoes.Name = "gv_Evolucoes";
            this.gv_Evolucoes.OptionsDetail.EnableMasterViewMode = false;
            this.gv_Evolucoes.OptionsView.ColumnAutoWidth = false;
            this.gv_Evolucoes.OptionsView.ShowGroupPanel = false;
            this.gv_Evolucoes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_EVENTO, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gv_Evolucoes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Evolucoes_RowClick);
            // 
            // colID_EVENTO
            // 
            this.colID_EVENTO.Caption = "Identificador";
            this.colID_EVENTO.FieldName = "ID_EVENTO";
            this.colID_EVENTO.Name = "colID_EVENTO";
            this.colID_EVENTO.OptionsColumn.AllowEdit = false;
            this.colID_EVENTO.OptionsColumn.AllowFocus = false;
            this.colID_EVENTO.Visible = true;
            this.colID_EVENTO.VisibleIndex = 0;
            this.colID_EVENTO.Width = 86;
            // 
            // colDT_EVENTO
            // 
            this.colDT_EVENTO.Caption = "Data";
            this.colDT_EVENTO.DisplayFormat.FormatString = "g";
            this.colDT_EVENTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_EVENTO.FieldName = "DT_EVENTO";
            this.colDT_EVENTO.GroupFormat.FormatString = "g";
            this.colDT_EVENTO.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDT_EVENTO.Name = "colDT_EVENTO";
            this.colDT_EVENTO.OptionsColumn.AllowEdit = false;
            this.colDT_EVENTO.OptionsColumn.AllowFocus = false;
            this.colDT_EVENTO.Visible = true;
            this.colDT_EVENTO.VisibleIndex = 1;
            // 
            // colSTATUS
            // 
            this.colSTATUS.Caption = "Status";
            this.colSTATUS.FieldName = "STATUS";
            this.colSTATUS.Name = "colSTATUS";
            this.colSTATUS.OptionsColumn.AllowEdit = false;
            this.colSTATUS.OptionsColumn.AllowFocus = false;
            this.colSTATUS.Visible = true;
            this.colSTATUS.VisibleIndex = 2;
            // 
            // colDS_EVENTO
            // 
            this.colDS_EVENTO.Caption = "Observação";
            this.colDS_EVENTO.FieldName = "DS_EVENTO";
            this.colDS_EVENTO.Name = "colDS_EVENTO";
            this.colDS_EVENTO.OptionsColumn.AllowEdit = false;
            this.colDS_EVENTO.OptionsColumn.AllowFocus = false;
            this.colDS_EVENTO.Visible = true;
            this.colDS_EVENTO.VisibleIndex = 3;
            // 
            // colEVOLUCAO_LOGINATENDENTE
            // 
            this.colEVOLUCAO_LOGINATENDENTE.Caption = "Atendente";
            this.colEVOLUCAO_LOGINATENDENTE.FieldName = "LOGIN_ATENDENTE";
            this.colEVOLUCAO_LOGINATENDENTE.Name = "colEVOLUCAO_LOGINATENDENTE";
            this.colEVOLUCAO_LOGINATENDENTE.OptionsColumn.AllowEdit = false;
            this.colEVOLUCAO_LOGINATENDENTE.OptionsColumn.AllowFocus = false;
            this.colEVOLUCAO_LOGINATENDENTE.Visible = true;
            this.colEVOLUCAO_LOGINATENDENTE.VisibleIndex = 4;
            // 
            // FChamado_Busca
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(719, 567);
            this.Controls.Add(this.xtc_Abas);
            this.Controls.Add(this.cpc_Filtros);
            this.Controls.Add(this.cp_Menu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FChamado_Busca";
            this.Text = "Lançamento - Chamado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FChamado_Busca_FormClosing);
            this.Load += new System.EventHandler(this.FChamado_Busca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FChamado_Busca_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cp_Menu)).EndInit();
            this.cp_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bm_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Filtros)).EndInit();
            this.cpc_Filtros.ResumeLayout(false);
            this.cpc_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cse_Identificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_ChamadosAbertos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe_Gravidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Departamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Departamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Prioridade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Prioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Solicitante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Solicitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cccbe_Atendente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Atendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_Datas)).EndInit();
            this.cgc_Datas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_Datas)).EndInit();
            this.cpc_Datas.ResumeLayout(false);
            this.cpc_Datas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Finalizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Previsto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Lancamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cce_Atendimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtc_Abas)).EndInit();
            this.xtc_Abas.ResumeLayout(false);
            this.xtp_Chamado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Chamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Chamado)).EndInit();
            this.xtp_ChamadoDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpc_DadosGerais)).EndInit();
            this.cpc_DadosGerais.ResumeLayout(false);
            this.cpc_DadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DetalhesCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_DetalhesApartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DetalhesDataRequerida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_DetalhesDataRequerida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_DetalhesAnexos)).EndInit();
            this.cgc_DetalhesAnexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_DetalhesAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_DetalhesAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cme_DetalhesDescricao.Properties)).EndInit();
            this.xtp_ChamadoEvolucoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DetalhesEvolucoes)).EndInit();
            this.gc_DetalhesEvolucoes.ResumeLayout(false);
            this.gc_DetalhesEvolucoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cme_EvolucaoObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cte_EvolucaoStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_EvolucaoData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cde_EvolucaoData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgc_EvolucaoAnexos)).EndInit();
            this.cgc_EvolucaoAnexos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_EvolucaoAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_EvolucoesAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Evolucoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Evolucoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Menu.Painel_x32 cp_Menu;
        private Componentes.Menu.Adicionar_x32 csb_Adicionar;
        private Componentes.CSimpleButton csb_Atender;
        private Componentes.CSimpleButton csb_Finalizar;
        private Componentes.CSimpleButton csb_Evoluir;
        private Componentes.CPanelControl cpc_Filtros;
        private Componentes.CLabelControl clc_Status;
        private Componentes.CLabelControl clc_Solicitante;
        private Componentes.CLabelControl clc_Atendente;
        private Componentes.CLabelControl clc_Identificador;
        private Componentes.CLabelControl clc_Prioridade;
        private Componentes.CGroupControl cgc_Datas;
        private Componentes.CLabelControl clc_Departamento;
        private Componentes.CLabelControl clc_Categoria;
        private Componentes.CPanelControl cpc_Datas;
        private Componentes.CCheckEdit cce_Finalizado;
        private Componentes.CCheckEdit cce_Previsto;
        private Componentes.CCheckEdit cce_Lancamento;
        private Componentes.CDateEdit cde_DataInicial;
        private Componentes.CCheckEdit cce_Atendimento;
        private Componentes.CLabelControl clc_DataInicial;
        private Componentes.CLabelControl clc_DataFinal;
        private Componentes.CDateEdit cde_DataFinal;
        private Componentes.Menu.Relatorio_x32 csb_Relatorio;
        private Componentes.CCheckedComboBoxEdit cccbe_Atendente;
        private Componentes.CCheckedComboBoxEdit cccbe_Departamento;
        private Componentes.CCheckedComboBoxEdit cccbe_Categoria;
        private Componentes.CCheckedComboBoxEdit cccbe_Prioridade;
        private Componentes.CCheckedComboBoxEdit cccbe_Status;
        private Componentes.CCheckedComboBoxEdit cccbe_Solicitante;
        private Componentes.CSimpleButton csb_AtualizarFiltros;
        private DevExpress.XtraBars.BarManager bm_Menu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_200;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_1000;
        private DevExpress.XtraBars.BarButtonItem bbi_Buscar_Todos;
        private DevExpress.XtraBars.PopupMenu pm_Menu;
        private Componentes.Menu.Cancelar_x32 csb_Sair;
        private System.Windows.Forms.BindingSource bs_Categoria;
        private System.Windows.Forms.BindingSource bs_Atendente;
        private System.Windows.Forms.BindingSource bs_Status;
        private System.Windows.Forms.BindingSource bs_Solicitante;
        private System.Windows.Forms.BindingSource bs_Prioridade;
        private System.Windows.Forms.BindingSource bs_Departamento;
        private DevExpress.XtraTab.XtraTabControl xtc_Abas;
        private DevExpress.XtraTab.XtraTabPage xtp_Chamado;
        private DevExpress.XtraGrid.GridControl gc_Chamado;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Chamado;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CHAMADO;
        private DevExpress.XtraGrid.Columns.GridColumn colCATEGORIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTAMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGIN_SOLICITANTE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGIN_ATENDENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CHAMADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_OBSERVACAO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_SOLUCAO;
        private DevExpress.XtraGrid.Columns.GridColumn colESTIMATIVA_TEMPO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PRIORIDADE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_PRIORIDADE;
        private DevExpress.XtraGrid.Columns.GridColumn colST_CHAMADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_CHAMADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_PREVISTA;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_FINALIZADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_ATENDIMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colST_EVOLUCAO;
        private DevExpress.XtraTab.XtraTabPage xtp_ChamadoDetalhes;
        private DevExpress.XtraTab.XtraTabPage xtp_ChamadoEvolucoes;
        private Componentes.CPanelControl cpc_DadosGerais;
        private Componentes.CTextEdit cte_DetalhesCategoria;
        private Componentes.CTextEdit cte_DetalhesApartamento;
        private Componentes.CDateEdit cde_DetalhesDataRequerida;
        private Componentes.CGroupControl cgc_DetalhesAnexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_DetalhesAnexos;
        private Componentes.CLabelControl clc_Detalhes_DataRequerida;
        private Componentes.CMemoEdit cme_DetalhesDescricao;
        private Componentes.CLabelControl clc_DetalhesDescricao;
        private Componentes.CLabelControl clc_DetalhesDepartamento;
        private Componentes.CLabelControl clc_DetalhesCategoria;
        private System.Windows.Forms.BindingSource bs_DetalhesAnexos;
        private DevExpress.XtraEditors.GroupControl gc_DetalhesEvolucoes;
        private Componentes.CGroupControl cgc_EvolucaoAnexos;
        private DevExpress.XtraEditors.ListBoxControl lbc_EvolucaoAnexos;
        private DevExpress.XtraGrid.GridControl gc_Evolucoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Evolucoes;
        private System.Windows.Forms.BindingSource bs_EvolucoesAnexos;
        private Componentes.CMemoEdit cme_EvolucaoObservacao;
        private Componentes.CLabelControl clc_EvolucaoObservacao;
        private Componentes.CTextEdit cte_EvolucaoStatus;
        private Componentes.CLabelControl clc_EvolucaoStatus;
        private Componentes.CDateEdit cde_EvolucaoData;
        private Componentes.CLabelControl clc_EvolucaoData;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EVENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_EVENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_EVENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_REQUERIDA;
        private DevExpress.XtraGrid.Columns.GridColumn colDT_ULTIMAEVOLUCAO;
        private Componentes.CCheckedComboBoxEdit ccbe_Gravidade;
        private Componentes.CLabelControl clc_Gravidade;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_RESUMO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTAMENTO_SOLICITANTE;
        private DevExpress.XtraGrid.Columns.GridColumn colGRAVIDADE;
        private Componentes.Menu.Buscar_x32 csb_Buscar;
        private Componentes.CCheckEdit cce_ChamadosAbertos;
        private DevExpress.XtraGrid.Columns.GridColumn colEVOLUCAO_LOGINATENDENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colST_SOLICITANTE;
        private DevExpress.XtraGrid.Columns.GridColumn colEVOLUCAO;
        private Componentes.CSpinEdit cse_Identificador;

    }
}
