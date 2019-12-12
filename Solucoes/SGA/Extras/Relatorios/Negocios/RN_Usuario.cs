using Extras.Relatorios.Entidades;
using Utilidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Extras.Relatorios.Negocios
{
    public class RN_Usuario
    {
        public IEnumerable<RE_Usuario> Buscar()
        {
            return Conexao.Banco.ExecuteQuery<RE_Usuario>("select Login, Nome = ISNULL(NM_Usuario, '') from TB_DIV_USUARIO");
        }


        public IEnumerable<RE_Usuario> Buscar(string login, string nm_usuario)
        {
            var consulta = new StringBuilder();
            consulta.AppendLine("select a.* from (");
            consulta.AppendLine("select Login, Nome = ISNULL(NM_Usuario, '') from TB_DIV_USUARIO");
            consulta.AppendLine(") as a");

            if (login.HasValue() || nm_usuario.HasValue())
            {
                consulta.AppendLine("where");

                if (login.HasValue())
                    consulta.AppendLine(string.Format("a.login = {0}", login));
                if (nm_usuario.HasValue())
                    consulta.AppendLine(string.Format("a.nm_usuario = {0}", nm_usuario));
            }

            return Conexao.Banco.ExecuteQuery<RE_Usuario>(consulta.ToString());
        }
    }
}