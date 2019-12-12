using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_DEPARTAMENTO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_DEPARTAMENTO { get; set; }
        public string DS_DEPARTAMENTO { get; set; }

        public E_DEPARTAMENTO(TB_DIV_DEPARTAMENTO departamento = null)
        {
            OPERACAO = Operacao.Normal;

            if (departamento != null)
            {
                ID_DEPARTAMENTO = departamento.ID_DEPARTAMENTO;
                DS_DEPARTAMENTO = departamento.DS_DEPARTAMENTO.Treat();
            }
        }
    }
}