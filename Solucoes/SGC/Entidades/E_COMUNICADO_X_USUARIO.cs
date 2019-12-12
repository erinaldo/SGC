using Modelo;

namespace Entidades
{
    public class E_COMUNICADO_X_USUARIO
    {
        public int ID_COMUNICADO { get; set; }
        public string LOGIN { get; set; }

        public E_COMUNICADO_X_USUARIO(TB_DIV_COMUNICADO_X_USUARIO comunicadoUsuario = null)
        {
            if (comunicadoUsuario != null)
            {
                ID_COMUNICADO = comunicadoUsuario.ID_COMUNICADO;
                LOGIN = comunicadoUsuario.LOGIN;
            }
        }
    }
}