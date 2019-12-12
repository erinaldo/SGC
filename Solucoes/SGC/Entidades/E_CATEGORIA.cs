using Modelo;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_CATEGORIA
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public string DS_CATEGORIA { get; set; }
        public E_DEPARTAMENTO DEPARTAMENTO { get; set; }
        public string DS_DEPARTAMENTO { get; set; }

        public string CLASSIFICACAO { get; set; }
        public string GRAVIDADE { get; set; }
        public string TIPO { get; set; }
        public int? TEMPO_HORA_MIN { get; set; }
        public int? TEMPO_HORA_MAX { get; set; }

        public E_CATEGORIA(TB_DIV_CATEGORIA categoria = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (categoria != null)
            {
                this.ID_CATEGORIA = categoria.ID_CATEGORIA;
                this.DS_CATEGORIA = categoria.DS_CATEGORIA.Treat();

                if (categoria.TB_DIV_DEPARTAMENTO != null)
                {
                    this.DEPARTAMENTO = new E_DEPARTAMENTO(categoria.TB_DIV_DEPARTAMENTO);
                    this.DS_DEPARTAMENTO = string.Format("{0} - {1}", DEPARTAMENTO.ID_DEPARTAMENTO, DEPARTAMENTO.DS_DEPARTAMENTO.Treat());
                }
                
                this.CLASSIFICACAO = categoria.CLASSIFICACAO.Treat();
                this.GRAVIDADE = categoria.GRAVIDADE.Treat();
                this.TEMPO_HORA_MIN = categoria.TEMPO_HORA_MIN;
                this.TEMPO_HORA_MAX = categoria.TEMPO_HORA_MAX;
            }
        }
    }
}