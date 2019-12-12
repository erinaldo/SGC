using Componentes;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FR002 : Formas.Padrao.FPadrao_Relatorio
    {
        public FR002()
        {
            InitializeComponent();
            Identificador = "R2";

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
                                   }).Single() != null
                               group new { a, b, b.TB_DIV_DEPARTAMENTO } by new
                               {
                                   a.LOGIN_SOLICITANTE,
                                   b.ID_DEPARTAMENTO,
                                   b.TB_DIV_DEPARTAMENTO.DS_DEPARTAMENTO
                               } into g
                               select new
                               {
                                   g.Key.LOGIN_SOLICITANTE,
                                   ID_DEPARTAMENTO = (System.Int32?)g.Key.ID_DEPARTAMENTO,
                                   g.Key.DS_DEPARTAMENTO,
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
