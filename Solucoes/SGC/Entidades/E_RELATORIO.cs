using DevExpress.XtraReports.UI;
using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_RELATORIO
    {
        public int ID_RELATORIO { get; set; }
        public string DS_RELATORIO { get; set; }
        public XtraReport ARQUIVO { get; set; }

        public E_RELATORIO(TB_DIV_RELATORIO relatorio = null)
        {
            if (relatorio != null)
            {
                ID_RELATORIO = relatorio.ID_RELATORIO;
                DS_RELATORIO = relatorio.DS_RELATORIO.Treat();
                ARQUIVO = relatorio.ARQUIVO.ToXtraReport();
            }
        }
    }
}