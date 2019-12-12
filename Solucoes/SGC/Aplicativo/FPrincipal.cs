using Aplicativo.Cadastros;
using Aplicativo.Configuracoes;
using Aplicativo.Lancamentos;
using Aplicativo.Relatorios;
using Consultas;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Aplicativo
{
    public partial class FPrincipal : Formas.Padrao.FPadrao
    {
        #region Métodos

        public FPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void FPrincipal_Load(object sender = null, EventArgs e = null)
        {
            try
            {
                var transacao = 0;

                C_MENU.Gerar(ref transacao);

                if (Parametros.IsAdministrator())
                {
                    bsi_Cadastros.Visibility = BarItemVisibility.Always;
                    bsi_Relatorios.Visibility = BarItemVisibility.Always;
                    b_Tools.Visible = true;

                    bbi_Usuario.Visibility = BarItemVisibility.Always;
                    bbi_Equipamento.Visibility = BarItemVisibility.Always;
                    bbi_EquipamentoUsuario.Visibility = BarItemVisibility.Always;
                    bbi_ClienteFornecedor.Visibility = BarItemVisibility.Always;
                    bbi_GrupoUsuario.Visibility = BarItemVisibility.Always;
                    bbi_Cargo.Visibility = BarItemVisibility.Always;
                    bbi_Departamento.Visibility = BarItemVisibility.Always;
                    bbi_GrupoProduto.Visibility = BarItemVisibility.Always;
                    bbi_Item.Visibility = BarItemVisibility.Always;
                    bbi_Categoria.Visibility = BarItemVisibility.Always;
                    bbi_Marca.Visibility = BarItemVisibility.Always;
                    bbi_Modelo.Visibility = BarItemVisibility.Always;
                    bbi_Status.Visibility = BarItemVisibility.Always;
                    bbi_Sugestao.Visibility = BarItemVisibility.Always;
                    bbi_Chamado.Visibility = BarItemVisibility.Always;
                    bbi_AlocacaoRecurso.Visibility = BarItemVisibility.Always;
                    bbi_Conhecimento.Visibility = BarItemVisibility.Always;
                    bbi_Comunicado.Visibility = BarItemVisibility.Always;
                    bsi_Relatorios.Visibility = BarItemVisibility.Always;

                    bbi_EnvioEmail.Visibility = BarItemVisibility.Always;

                    bbi_Dashboard.Visibility = BarItemVisibility.Always;
                    bbi_R001.Visibility = BarItemVisibility.Always;
                    bbi_R002.Visibility = BarItemVisibility.Always;
                    bbi_R003.Visibility = BarItemVisibility.Always;
                    bbi_R004.Visibility = BarItemVisibility.Always;
                    bbi_R005.Visibility = BarItemVisibility.Always;
                    bbi_R006.Visibility = BarItemVisibility.Always;
                }
                else
                    (from a in Conexao.Banco.TB_DIV_USUARIOs where a.LOGIN == Parametros.Usuario select new E_USUARIO(a, false)).Take(1).First().ACESSOS.ForEach(a =>
                    {
                        if (a.ID_MENU.StartsWith("C"))
                            bsi_Cadastros.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU.StartsWith("R") || a.ID_MENU.StartsWith("D"))
                            bsi_Relatorios.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU.StartsWith("L"))
                            b_Tools.Visible = true;

                        if (a.ID_MENU == "C1")
                            bbi_Usuario.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C2")
                            bbi_GrupoUsuario.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C3")
                            bbi_Cargo.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C4")
                            bbi_Departamento.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C5")
                            bbi_GrupoProduto.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C6")
                            bbi_Item.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C7")
                            bbi_Categoria.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C9")
                            bbi_Marca.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C10")
                            bbi_Modelo.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C11")
                            bbi_Status.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C12")
                            bbi_Sugestao.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C13")
                            bbi_ClienteFornecedor.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C14")
                            bbi_Equipamento.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "C15")
                            bbi_EquipamentoUsuario.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "L1")
                            bbi_Chamado.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "L3")
                            bbi_AlocacaoRecurso.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "L4")
                            bbi_Conhecimento.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "L6")
                            bbi_Comunicado.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R1")
                            bbi_R001.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R2")
                            bbi_R002.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R3")
                            bbi_R003.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R4")
                            bbi_R004.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R5")
                            bbi_R005.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R6")
                            bbi_R006.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "R7")
                            bbi_R006.Visibility = BarItemVisibility.Always;
                        else if (a.ID_MENU == "D1")
                            bbi_Dashboard.Visibility = BarItemVisibility.Always;
                    });
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }


        private void bbi_Usuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FUsuario_Busca());
        }

        private void bbi_Cargo_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FCargo_Busca());
        }

        private void bbi_Modelo_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FModelo_Busca());
        }

        private void bbi_GrupoProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FGrupoProduto_Busca());
        }

        private void bbi_GrupoUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FGrupoUsuario_Busca());
        }

        private void bbi_Status_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FStatus_Busca());
        }

        private void bbi_ClienteFornecedor_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FClifor_Busca());
        }

        private void bbi_Departamento_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FDepartamento_Busca());
        }

        private void bbi_Marca_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FMarca_Busca());
        }

        private void bbi_Chamado_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FChamado_Busca());
        }

        private void bbi_Item_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FItem_Busca());
        }

        private void bbi_Categoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FCategoria_Busca());
        }

        private void bbi_Equipamento_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FEquipamento_Busca());
        }

        private void bbi_EquipamentoUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FEquipamentoUsuario_Busca());
        }

        private void bbi_Comunicado_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FComunicado_Busca());
        }

        private void bbi_Conhecimento_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FConhecimento_Busca());
        }

        private void bbi_AlocacaoRecurso_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FAlocacaoRecurso_Busca());
        }

        private void bbi_Senha_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FSalvaSenha_Busca());
        }

        private void bbi_Dashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FDashboard());
        }


        private void bbi_R001_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarFormaDialog(new FR001());
        }
        private void bbi_R002_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR002());
        }
        private void bbi_R003_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR003());
        }
        private void bbi_R004_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR004());
        }
        private void bbi_R005_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR005());
        }
        private void bbi_R006_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR006());
        }

        private void bbi_R007_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR007());
        }

        private void bbi_R008_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarForma(new FR008());
        }
        private void bbi_EnvioEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarFormaDialog(new FConfiguracoesEmail());
        }

        private void bbi_AlterarSenha_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostrarFormaDialog(new FTrocarSenha());
        }


        private void t_aw_Tick(object sender, EventArgs e)
        {
            t_aw.Stop();

            var chamados = new FChamado_Busca().Buscar_Chamados();

            var qtd_abertos = chamados.Where(a => a.ST_CHAMADO == "A").Count();
            var qtd_emAtendimento = chamados.Where(a => a.ST_CHAMADO != "A" && a.ST_CHAMADO != "F").Count();

            var mensagem = "";
            var primeiraLinha = "";
            var segundaLinha = "";

            if (qtd_abertos > 0)
                primeiraLinha = String.Format("Existe{2} {0} chamado{1} não atendido{1}!", qtd_abertos, (qtd_abertos > 1 ? "s" : ""), (qtd_abertos > 0 ? "m" : ""));
            if (qtd_emAtendimento > 0)
                segundaLinha = String.Format("Você tem {0} chamado{1} ainda em atendimento!", qtd_emAtendimento, (qtd_emAtendimento > 1 ? "s" : ""));

            if (primeiraLinha.Length > 0)
                mensagem = primeiraLinha;

            if (segundaLinha.Length > 0)
                mensagem += (mensagem.Length > 0 ? "\n" : "") + segundaLinha;

            var ac = new AlertControl()
            {
                AutoFormDelay = 2000,
                ShowPinButton = false,
                AutoHeight = true,
                AllowHtmlText = true
            };

            if (mensagem.Length > 0)
                ac.Show(this, "<b>#SGC informa:</b>", mensagem);

            t_aw.Start();
        }

        #endregion
    }
}