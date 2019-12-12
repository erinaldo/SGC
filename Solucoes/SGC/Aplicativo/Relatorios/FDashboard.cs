using DevExpress.XtraCharts;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FDashboard : Formas.Padrao.FPadrao
    {
        public FDashboard()
        {
            InitializeComponent();
        }

        private void CarregarControles()
        {
            #region Consultas

            var data = Conexao.Banco.GetDate();
            var dataInicial = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0, 0);
            var dataFinal = new DateTime(data.Year, data.Month, data.Day, 23, 59, 59, 999);

            #endregion

            var chamadosHoje = (from a in Conexao.Banco.TB_DIV_CHAMADOs where a.DT_CHAMADO >= dataInicial && a.DT_CHAMADO <= dataFinal select a);

            Atualizar(cc_hoje, new List<E_DASHBOARD>
            {
                new E_DASHBOARD { Coluna = "Solicitados", Valor = chamadosHoje.Count() },
                new E_DASHBOARD { Coluna = "Atendido", Valor =   chamadosHoje.Where(a => a.ST_CHAMADO == "F").Count() },
                new E_DASHBOARD { Coluna = "Abertos", Valor =  chamadosHoje.Where(a => a.ST_CHAMADO == "A").Count() }
            });

            dataInicial = new DateTime(data.Year, data.Month, 1);
            dataFinal = dataInicial.AddMonths(1).AddMilliseconds(-1);

            var chamadosMes = (from a in Conexao.Banco.TB_DIV_CHAMADOs where a.DT_CHAMADO >= dataInicial && a.DT_CHAMADO <= dataFinal select a);

            Atualizar(cc_mes, new List<E_DASHBOARD>
            {
                new E_DASHBOARD { Coluna = "Solicitados", Valor =  chamadosMes.Count() },
                new E_DASHBOARD { Coluna = "Atendido", Valor =  chamadosMes.Where(a => a.ST_CHAMADO == "F").Count() },
                 new E_DASHBOARD { Coluna = "Abertos", Valor =  chamadosMes.Where(a => a.ST_CHAMADO == "A").Count() }
            });

            var chamados = (from a in Conexao.Banco.TB_DIV_CHAMADOs where a.ST_CHAMADO != "C" select a);

            Atualizar(cc_todos, new List<E_DASHBOARD>
            {
                new E_DASHBOARD { Coluna = "Solicitados", Valor = chamados.Count() },
                new E_DASHBOARD { Coluna = "Atendido", Valor = chamados.Where(a => a.ST_CHAMADO == "F").Count() },
                new E_DASHBOARD { Coluna = "Abertos", Valor =  chamados.Where(a => a.ST_CHAMADO == "A").Count() }
            });

            Atualizar(cc_abertosCategoria, (from a in Conexao.Banco.TB_DIV_CHAMADOs
                                            where
                                              a.ST_CHAMADO == "A"
                                            group new { a, a.TB_DIV_CATEGORIA } by new
                                            {
                                                a.ID_CATEGORIA,
                                                a.TB_DIV_CATEGORIA.DS_CATEGORIA
                                            } into g
                                            orderby g.Key.ID_CATEGORIA
                                            select new E_DASHBOARD
                                            {
                                                Coluna = (g.Key.ID_CATEGORIA + " - " + g.Key.DS_CATEGORIA),
                                                Valor = g.Count()
                                            }).ToList());

            Atualizar(cc_abertosStatus, (from t in
                                             (
                                                 (from a in Conexao.Banco.TB_DIV_CHAMADOs
                                                  where
                                                    a.ST_CHAMADO == "A"
                                                  select new
                                                  {
                                                      SIGLA_STATUS = (
                                                        ((from x0 in Conexao.Banco.TB_DIV_EVENTOs
                                                          where
                                                            x0.ID_CHAMADO == a.ID_CHAMADO &&
                                                            x0.ID_EVENTO ==
                                                              (from x01 in Conexao.Banco.TB_DIV_EVENTOs
                                                               where
                                                                 x01.ID_CHAMADO == a.ID_CHAMADO
                                                               select new
                                                               {
                                                                   x01.ID_EVENTO
                                                               }).Max(p => p.ID_EVENTO)
                                                          select new
                                                          {
                                                              x0.SIGLA_STATUS
                                                          }).First().SIGLA_STATUS) ?? "SA")
                                                  }))
                                         join x in Conexao.Banco.TB_DIV_STATUS on new { SIGLA_STATUS = Convert.ToString(t.SIGLA_STATUS) } equals new { SIGLA_STATUS = x.SIGLA_STATUS } into x_join
                                         from x in x_join.DefaultIfEmpty()
                                         group new { t, x } by new
                                         {
                                             t.SIGLA_STATUS,
                                             x.DS_STATUS
                                         } into g
                                         orderby g.Key.SIGLA_STATUS
                                         select new E_DASHBOARD
                                         {
                                             Coluna = (g.Key.SIGLA_STATUS + " - " + (g.Key.DS_STATUS ?? "SEM ATENDIMENTO")),
                                             Valor = g.Count()
                                         }).ToList());

            Atualizar(cc_atendidasCategoriaMes, (from a in Conexao.Banco.TB_DIV_CHAMADOs
                                                 join b in Conexao.Banco.TB_DIV_CATEGORIAs on new { ID_CATEGORIA = Convert.ToInt32(a.ID_CATEGORIA) } equals new { ID_CATEGORIA = b.ID_CATEGORIA }
                                                 where
                                                   a.ST_CHAMADO == "F" &&
                                                   a.DT_CHAMADO.Year == data.Year &&
                                                   a.DT_CHAMADO.Month == data.Month
                                                 group new { a, b } by new
                                                 {
                                                     a.ID_CATEGORIA,
                                                     b.DS_CATEGORIA
                                                 } into g
                                                 orderby
                                                   g.Count() descending
                                                 select new E_DASHBOARD
                                                 {
                                                     Coluna = g.Key.ID_CATEGORIA + " - " + g.Key.DS_CATEGORIA,
                                                     Valor = g.Count()
                                                 }).ToList());

            Atualizar(cc_abertosDepartamento, (from a in Conexao.Banco.TB_DIV_CHAMADOs
                                               join b in Conexao.Banco.TB_DIV_USUARIOs on new { LOGIN_SOLICITANTE = a.LOGIN_SOLICITANTE } equals new { LOGIN_SOLICITANTE = b.LOGIN }
                                               where
                                                 a.ST_CHAMADO == "A"
                                               group new { b, b.TB_DIV_DEPARTAMENTO } by new
                                               {
                                                   b.ID_DEPARTAMENTO,
                                                   b.TB_DIV_DEPARTAMENTO.DS_DEPARTAMENTO
                                               } into g
                                               orderby g.Key.ID_DEPARTAMENTO
                                               select new E_DASHBOARD
                                               {
                                                   Coluna = (g.Key.ID_DEPARTAMENTO + " - " + g.Key.DS_DEPARTAMENTO),
                                                   Valor = g.Count()
                                               }).ToList());
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            timer_Tick(null, null);
            timer.Start();
        }

        private void Atualizar(ChartControl cc, List<E_DASHBOARD> dataSource)
        {
            cc.Series.Clear();
            cc.DataSource = dataSource;

            var serie = new Series("", ViewType.Bar);
            cc.Series.Add(serie);

            serie.ArgumentDataMember = "Coluna";
            serie.ValueDataMembers.AddRange(new string[] { "Valor" });
            serie.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            serie.LegendPointOptions.Pattern = "{A}";

            ((BarSeriesView)serie.View).ColorEach = true;
            ((BarSeriesView)serie.View).AxisX.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CarregarControles();
        }
    }
}