using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_MARCA
    {
        public Operacao OPERACAO { get; set; }
        public int ID_MARCA { get; set; }
        public string DS_MARCA { get; set; }

        public E_MARCA(TB_DIV_MARCA marca = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (marca != null)
            {
                this.ID_MARCA = marca.ID_MARCA;
                this.DS_MARCA = marca.DS_MARCA.Treat();
            }
        }
    }
}