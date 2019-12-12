using Modelo;

namespace Entidades
{
    public class E_COMUNICADO_X_GRUPOUSUARIO
    {
        public int ID_COMUNICADO { get; set; }
        public int ID_GRUPOUSUARIO { get; set; }

        public E_COMUNICADO_X_GRUPOUSUARIO(TB_DIV_COMUNICADO_X_GRUPOUSUARIO comunicadoGrupoUsuario = null)
        {
            if (comunicadoGrupoUsuario != null)
            {
                ID_COMUNICADO = comunicadoGrupoUsuario.ID_COMUNICADO;
                ID_GRUPOUSUARIO = comunicadoGrupoUsuario.ID_GRUPOUSUARIO;
            }
        }
    }
}