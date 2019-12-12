using Componentes;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FR005 : Formas.Padrao.FPadrao_Relatorio
    {
        public FR005()
        {
            InitializeComponent();

            Identificador = "R5";

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
                               join b in Conexao.Banco.TB_DIV_USUARIOs on new { LOGIN_ATENDENTE = a.LOGIN_ATENDENTE } equals new { LOGIN_ATENDENTE = b.LOGIN }
                               where
                                 a.ST_CHAMADO == "F" &&
                                 a.DT_FINALIZADO >= cde_DataInicial.DateTime &&
                                 a.DT_FINALIZADO <= cde_DataFinal.DateTime &&
                                   (from x in Conexao.Banco.TB_DIV_USUARIOs
                                    where
                                      x.ID_DEPARTAMENTO == a.ID_DEPARTAMENTO &&
                                      x.LOGIN == Parametros.Usuario
                                    select new
                                    {
                                        Column1 = 1
                                    }).Single() != null
                               group new { a, b } by new
                               {
                                   a.LOGIN_ATENDENTE,
                                   b.NM_USUARIO
                               } into g
                               select new
                               {
                                   MEDIA_NOTA = (System.Double?)g.Average(p => p.a.NOTA),
                                   g.Key.LOGIN_ATENDENTE,
                                   g.Key.NM_USUARIO
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
