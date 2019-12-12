using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_TRANSF_CATEGORIA
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CHAMADO { get; set; }
        public int ID_TRANSF_CATEGORIA { get; set; }
        public int? ID_CATEGORIA_NEW { get; set; }
        public int? ID_CATEGORIA_OLD { get; set; }
        public string LOGIN { get; set; }

        public E_TRANSF_CATEGORIA(TB_DIV_TRANSF_CATEGORIA transf_categoria = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (transf_categoria != null)
            {
                this.ID_CHAMADO = transf_categoria.ID_CHAMADO;
                this.ID_TRANSF_CATEGORIA = transf_categoria.ID_TRANSF_CATEGORIA;
                this.ID_CATEGORIA_NEW = transf_categoria.ID_CATEGORIA_NEW;
                this.ID_CATEGORIA_OLD = transf_categoria.ID_CATEGORIA_OLD;
                this.LOGIN = transf_categoria.LOGIN;
            }
        }
    }
}