using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_MODELO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_MODELO { get; set; }
        public E_MARCA MARCA { get; set; }
        public string DS_MODELO { get; set; }

        public E_MODELO(TB_DIV_MODELO modelo = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (modelo != null)
            {
                this.ID_MODELO = modelo.ID_MODELO;
                this.MARCA = modelo.TB_DIV_MARCA == null ? null : new E_MARCA(modelo.TB_DIV_MARCA);
                this.DS_MODELO = modelo.DS_MODELO.Treat();
            }
        }
    }
}