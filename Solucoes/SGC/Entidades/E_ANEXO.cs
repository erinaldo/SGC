using Modelo;
using System.Data.Linq;
using Utilidades;

namespace Entidades
{
    public class E_ANEXO
    {
        public int ID_ANEXO { get; set; }
        public string NM_ANEXO { get; set; }
        public string EXTENSAO { get; set; }
        public Binary ANEXO { get; set; }

        public E_ANEXO(TB_DIV_ANEXO anexo = null)
        {
            ID_ANEXO = 0;
            NM_ANEXO = "";
            EXTENSAO = "";
            ANEXO = null;

            if (anexo != null)
            {
                ID_ANEXO = anexo.ID_ANEXO;
                NM_ANEXO = anexo.NM_ANEXO.Treat();
                EXTENSAO = anexo.EXTENSAO.Treat();
                ANEXO = anexo.ANEXO;
            }
        }
    }
}