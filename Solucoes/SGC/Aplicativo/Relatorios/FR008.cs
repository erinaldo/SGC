using Componentes;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Aplicativo.Relatorios
{
    public partial class FR008 : Formas.Padrao.FPadrao_Relatorio
    {
        public FR008()
        {
            InitializeComponent();
            Identificador = "R8";
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

                var consulta = 0;
                               // from b in Conexao.Banco.TB_DIV_EQUIPAMENTO_X_USUARIOs
                               //join c in Conexao.Banco.TB_DIV_MODELOs on new { ID_MODELO = Convert.ToInt32(b.TB_DIV_EQUIPAMENTOs.ID_MODELO) } equals new { ID_MODELO = c.ID_MODELO }
                               //where
                               //  b.DT_CAD >= cde_DataInicial.DateTime &&
                               //  b.DT_CAD <= cde_DataFinal.DateTime &&
                               //  b.TB_DIV_EQUIPAMENTOs.ST_ATIVO == "S" &&
                               //  b.ST_REGISTRO == "A"
                               //select new
                               //{
                               //    b.TB_DIV_EQUIPAMENTOs.DS_OBSERVACAO,
                               //    DT_AQUISICAO = (System.DateTime?)b.TB_DIV_EQUIPAMENTOs.DT_AQUISICAO,
                               //    DT_VALIDADE = (System.DateTime?)b.TB_DIV_EQUIPAMENTOs.DT_VALIDADE,
                               //    ID_EQUIPAMENTO = (System.Int32?)b.TB_DIV_EQUIPAMENTOs.ID_EQUIPAMENTO,
                               //    ID_GRUPO = (System.Int32?)b.TB_DIV_EQUIPAMENTOs.ID_GRUPO,
                               //    ID_MODELO = (System.Int32?)b.TB_DIV_EQUIPAMENTOs.ID_MODELO,
                               //    b.TB_DIV_EQUIPAMENTOs.NR_IDENTIFICACAO,
                               //    b.TB_DIV_EQUIPAMENTOs.ST_ATIVO,
                               //    b.LOGIN,
                               //    c.DS_MODELO,
                               //    b.TB_DIV_EQUIPAMENTOs.TB_DIV_GRUPOPRODUTOs.DS_GRUPO,
                               //    b.DT_CAD
                               //};
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
