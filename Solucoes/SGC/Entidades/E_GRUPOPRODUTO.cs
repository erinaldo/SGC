using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_GRUPOPRODUTO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_GRUPO { get; set; }
        public string DS_GRUPO { get; set; }

        public E_GRUPOPRODUTO(TB_DIV_GRUPOPRODUTO grupoproduto = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (grupoproduto != null)
            {
                this.ID_GRUPO = grupoproduto.ID_GRUPO;
                this.DS_GRUPO = grupoproduto.DS_GRUPO.Treat();
            }
        }
    }
}