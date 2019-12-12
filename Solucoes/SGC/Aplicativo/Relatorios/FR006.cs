using Componentes;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FR006 : Formas.Padrao.FPadrao_Relatorio
    {
        public FR006()
        {
            InitializeComponent();
            Identificador = "R6";

            cde_DataInicial.DateTime = Conexao.Banco.GetDate();
            cde_DataFinal.DateTime = Conexao.Banco.GetDate();
        }

        public override void Relatorio()
        {
            try
            {
                cpc_Dados.Controls.Validate();

                if (cde_DataInicial.DateTime > cde_DataFinal.DateTime)
                    throw new Exception("É necessário informar uma data inicial menor que a data final!");

                base.Relatorio();

                var consulta = from t in
                                   (
                                       (from a in Conexao.Banco.TB_DIV_CHAMADOs
                                        join b in Conexao.Banco.TB_DIV_CATEGORIAs on new { ID_CATEGORIA = Convert.ToInt32(a.ID_CATEGORIA) } equals new { ID_CATEGORIA = b.ID_CATEGORIA }
                                        where
                                          a.ST_CHAMADO == "F" &&
                                          a.DT_CHAMADO >= cde_DataInicial.DateTime &&
                                            a.DT_CHAMADO <= cde_DataFinal.DateTime &&
                                            (from x in Conexao.Banco.TB_DIV_USUARIOs
                                             where
                                               x.ID_DEPARTAMENTO == a.ID_DEPARTAMENTO &&
                                               x.LOGIN == Parametros.Usuario
                                             select new
                                             {
                                                 Column1 = 1
                                             }).Single() != null
                                        select new
                                        {
                                            ID_CATEGORIA = (Int32?)a.ID_CATEGORIA,
                                            b.DS_CATEGORIA,
                                            MIN_LANCTO_X_ATENDIMENTO = (a.DT_ATENDIMENTO.GetValueOrDefault()-a.DT_CHAMADO ).TotalMinutes,//diferença em horas data chamado - data atendimento
                                            MIN_ATENDIMENTO_X_FINALIZADO = (a.DT_FINALIZADO.GetValueOrDefault() - a.DT_ATENDIMENTO.GetValueOrDefault()).TotalMinutes,//diferença em horas data atendimento - data finalizado
                                            MIN_LANCTO_X_FINALIZADO = (a.DT_FINALIZADO.GetValueOrDefault() - a.DT_CHAMADO).TotalMinutes,//diferença em horas data chamado - data finalizado
                                            MIN_ATENDIMENTO_X_FECHADO = (a.DT_FINALIZADO.GetValueOrDefault() - a.DT_ATENDIMENTO.GetValueOrDefault()).TotalMinutes//diferença em horas data atendimento - data fechado
                                        }))
                               group t by new
                               {
                                   t.ID_CATEGORIA,
                                   t.DS_CATEGORIA
                               } into g
                               select new
                               {
                                   ID_CATEGORIA = (Int32?)g.Key.ID_CATEGORIA,
                                   g.Key.DS_CATEGORIA,
                                   QTD_CHAMADO = (Int64?)g.Count(),
                                   MIN_LANCTO_X_ATENDIMENTO = (Double?)g.Average(p => p.MIN_LANCTO_X_ATENDIMENTO),
                                   MIN_LANCTO_X_FINALIZADO = (Double?)g.Average(p => p.MIN_LANCTO_X_FINALIZADO),
                                   MIN_ATENDIMENTO_X_FINALIZADO = (Double?)g.Average(p => p.MIN_ATENDIMENTO_X_FINALIZADO),
                                   MIN_ATENDIMENTO_X_FECHADO = (Double?)g.Average(p => p.MIN_ATENDIMENTO_X_FECHADO)
                               };

                var parametros = new List<Parameter>()
                {
                    new  Parameter
                    {
                        Name = "DT_INICIAL",
                        Value = new DateTime(cde_DataInicial.DateTime.Year, cde_DataInicial.DateTime.Month, cde_DataInicial.DateTime.Day, 0, 0, 0, 0)
                    },
                    new Parameter {
                        Name = "DT_FINAL",
                        Value = new DateTime(cde_DataFinal.DateTime.Year, cde_DataFinal.DateTime.Month, cde_DataFinal.DateTime.Day, 23, 59, 59, 999)
                    }
                };

                RelatorioGerar(consulta, parametros);

                RelatorioSalvar();
            }
            catch (Exception excessao)
            {
                Mensagens.Alerta(excessao.Tratar());
            }
        }
    }
}
