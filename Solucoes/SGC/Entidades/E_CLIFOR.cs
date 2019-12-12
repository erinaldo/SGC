using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_CLIFOR
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CLIFOR { get; set; }
        public string NM_CLIFOR { get; set; }

        public E_CLIFOR(TB_DIV_CLIFOR clifor = null)
        {
            OPERACAO = Operacao.Normal;

            if (clifor != null)
            {
                ID_CLIFOR = clifor.ID_CLIFOR;
                NM_CLIFOR = clifor.NM_CLIFOR.Treat();
            }
        }
    }
}