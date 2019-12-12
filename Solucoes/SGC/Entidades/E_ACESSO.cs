using Modelo;
using Utilidades;

namespace Entidades
{
    public class E_ACESSO
    {
        public string ID_MENU { get; set; }
        public string DS_MENU { get; set; }
        public string ST_CADASTRAR { get; set; }
        public string ST_ALTERAR { get; set; }
        public string ST_DELETAR { get; set; }
        public string ST_RELATORIO { get; set; }

        private void Parametrizar()
        {
            ST_CADASTRAR = "N";
            ST_ALTERAR = "N";
            ST_DELETAR = "N";
            ST_RELATORIO = "N";
        }

        public E_ACESSO()
        {
            Parametrizar();
        }

        public E_ACESSO(TB_DIV_ACESSO acesso = null, TB_DIV_MENU menu = null)
        {
            Parametrizar();

            if (acesso == null && menu == null)
                return;

            this.ID_MENU = acesso != null ? acesso.ID_MENU : menu.ID_MENU;
            this.DS_MENU = acesso != null ? (acesso.TB_DIV_MENU != null ? acesso.TB_DIV_MENU.DS_MENU.Treat() : "") : menu.DS_MENU.Treat();
            this.ST_CADASTRAR = acesso != null ? acesso.ST_CADASTRAR.Treat() : "N";
            this.ST_CADASTRAR = this.ST_CADASTRAR.Length > 0 ? this.ST_CADASTRAR : "N";
            this.ST_ALTERAR = acesso != null ? acesso.ST_ALTERAR.Treat() : "N";
            this.ST_ALTERAR = this.ST_ALTERAR.Length > 0 ? this.ST_ALTERAR : "N";
            this.ST_DELETAR = acesso != null ? acesso.ST_DELETAR.Treat() : "N";
            this.ST_DELETAR = this.ST_DELETAR.Length > 0 ? this.ST_DELETAR : "N";
            this.ST_RELATORIO = acesso != null ? acesso.ST_RELATORIO.Treat() : "N";
            this.ST_RELATORIO = this.ST_RELATORIO.Length > 0 ? this.ST_RELATORIO : "N";
        }
    }
}