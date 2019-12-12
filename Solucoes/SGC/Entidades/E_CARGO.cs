using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_CARGO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CARGO { get; set; }
        public string DS_CARGO { get; set; }

        public E_CARGO(TB_DIV_CARGO cargo = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (cargo != null)
            {
                this.ID_CARGO = cargo.ID_CARGO;
                this.DS_CARGO = cargo.DS_CARGO.Treat();
            }
        }
    }
}
