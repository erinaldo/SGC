using Componentes;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FR007 : Formas.Padrao.FPadrao_Relatorio
    {
        public FR007()
        {
            InitializeComponent();
            Identificador = "R7";

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
                               where
                                 a.ST_CHAMADO == "A" &&
                                 a.DT_CHAMADO >= cde_DataInicial.DateTime &&
                                 a.DT_CHAMADO <= cde_DataFinal.DateTime &&

                                   (from x in Conexao.Banco.TB_DIV_USUARIOs
                                    where
                                      x.ID_DEPARTAMENTO == a.ID_DEPARTAMENTO &&
                                      x.LOGIN == Utilidades.Parametros.Usuario
                                    select new
                                    {
                                        Column1 = 1
                                    }).Single() != null
                               group a by new
                               {
                                   a.PRIORIDADE
                               } into g
                               select new
                               {
                                   QTD = (Int64?)g.Count(),
                                   PRIORIDADE =
                                   g.Key.PRIORIDADE == Convert.ToString(1) ? "ALTA" :
                                   g.Key.PRIORIDADE == Convert.ToString(2) ? "MÉDIA" :
                                   g.Key.PRIORIDADE == Convert.ToString(3) ? "BAIXA" : "SEM PRIORIDADE"
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
