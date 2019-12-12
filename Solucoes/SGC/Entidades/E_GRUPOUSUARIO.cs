using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_GRUPOUSUARIO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_GRUPOUSUARIO { get; set; }
        public string DS_GRUPO { get; set; }

        public E_GRUPOUSUARIO(TB_DIV_GRUPOUSUARIO grupousuario = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (grupousuario != null)
            {
                this.ID_GRUPOUSUARIO = grupousuario.ID_GRUPOUSUARIO;
                this.DS_GRUPO = grupousuario.DS_GRUPO.Treat();
            }
        }
    }
}