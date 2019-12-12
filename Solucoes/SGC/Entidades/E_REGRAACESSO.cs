using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_REGRAACESSO
    {
        public int ID_REGRAACESSO { get; set; }
        public string DS_REGRA { get; set; }
        public string DS_OBSERVACAO { get; set; }

        public E_REGRAACESSO(TB_DIV_REGRAACESSO regra = null)
        {
            if (regra != null)
            {
                this.ID_REGRAACESSO = regra.ID_REGRAACESSO;
                this.DS_REGRA = regra.DS_REGRA.Treat();
                this.DS_OBSERVACAO = regra.DS_OBSERVACAO.Treat();
            }
        }
    }
}