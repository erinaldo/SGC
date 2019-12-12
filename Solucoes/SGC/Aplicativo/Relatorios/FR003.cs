using Componentes;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FR003 : Formas.Padrao.FPadrao_Relatorio
    {
        public FR003()
        {
            InitializeComponent();
            Identificador = "R3";

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

                var consulta = from a in Conexao.Banco.TB_DIV_CHAMADOs
                               join b in Conexao.Banco.TB_DIV_USUARIOs on new { LOGIN = a.LOGIN_SOLICITANTE } equals new { LOGIN = b.LOGIN }
                               where
                                  (from x in Conexao.Banco.TB_DIV_USUARIOs
                                   where
                                     x.ID_DEPARTAMENTO == a.ID_DEPARTAMENTO &&
                                     x.LOGIN == Parametros.Usuario
                                   select new
                                   {
                                       Column1 = 1
                                   }).Single() != null &&
                                 a.DT_CHAMADO >= cde_DataInicial.DateTime &&
                                 a.DT_CHAMADO <= cde_DataFinal.DateTime
                               group new { b, b.TB_DIV_DEPARTAMENTO, a, a.TB_DIV_CATEGORIA } by new
                               {
                                   b.ID_DEPARTAMENTO,
                                   b.TB_DIV_DEPARTAMENTO.DS_DEPARTAMENTO,
                                   a.ID_CATEGORIA,
                                   a.TB_DIV_CATEGORIA.DS_CATEGORIA
                               } into g
                               orderby
                                 g.Count() descending
                               select new
                               {
                                   ID_DEPARTAMENTO = (System.Int32?)g.Key.ID_DEPARTAMENTO,
                                   g.Key.DS_DEPARTAMENTO,
                                   ID_CATEGORIA = (System.Int32?)g.Key.ID_CATEGORIA,
                                   g.Key.DS_CATEGORIA,
                                   QTD = (Int64?)g.Count()
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
