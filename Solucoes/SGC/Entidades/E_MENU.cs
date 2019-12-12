using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_MENU
    {
        public Operacao OPERACAO { get; set; }
        public string ID_MENU { get; set; }
        public string DS_MENU { get; set; }

        public E_MENU(TB_DIV_MENU menu = null)
        {
            this.OPERACAO = Operacao.Normal;

            if (menu != null)
            {
                this.ID_MENU = menu.ID_MENU.Treat();
                this.DS_MENU = menu.DS_MENU.Treat();
            }
        }
    }
}