using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_COMUNICADO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_COMUNICADO { get; set; }
        public string LOGIN_COMUNICADOR { get; set; }
        public string DS_COMUNICADO { get; set; }
        public string ST_REGISTRO { get; set; }
        public List<E_ANEXO> ANEXOS { get; set; }
        public List<E_COMUNICADO_X_USUARIO> USUARIOS { get; set; }
        public List<E_COMUNICADO_X_GRUPOUSUARIO> GRUPOUSUARIOS { get; set; }

        public DateTime DT_CAD { get; set; }

        public E_COMUNICADO(TB_DIV_COMUNICADO comunicado = null)
        {
            if (comunicado != null)
            {
                ID_COMUNICADO = comunicado.ID_COMUNICADO;
                LOGIN_COMUNICADOR = comunicado.LOGIN_COMUNICADOR;
                DS_COMUNICADO = comunicado.DS_COMUNICADO.Treat();
                ST_REGISTRO = comunicado.ST_REGISTRO.Treat() == "A" ? "ATIVO" : "CANCELADO";
                DT_CAD = comunicado.DT_CAD.GetValueOrDefault();

                ANEXOS = new List<E_ANEXO>();
                USUARIOS = new List<E_COMUNICADO_X_USUARIO>();
                GRUPOUSUARIOS = new List<E_COMUNICADO_X_GRUPOUSUARIO>();

                if (comunicado.TB_DIV_COMUNICADO_X_ANEXOs != null && comunicado.TB_DIV_COMUNICADO_X_ANEXOs.Count > 0)
                    comunicado.TB_DIV_COMUNICADO_X_ANEXOs.ToList().ForEach(a => ANEXOS.Add(new E_ANEXO(a.TB_DIV_ANEXO)));

                if (comunicado.TB_DIV_COMUNICADO_X_USUARIOs != null && comunicado.TB_DIV_COMUNICADO_X_USUARIOs.Count > 0)
                    comunicado.TB_DIV_COMUNICADO_X_USUARIOs.ToList().ForEach(a => USUARIOS.Add(new E_COMUNICADO_X_USUARIO(a)));

                if (comunicado.TB_DIV_COMUNICADO_X_GRUPOUSUARIOs != null && comunicado.TB_DIV_COMUNICADO_X_GRUPOUSUARIOs.Count > 0)
                    comunicado.TB_DIV_COMUNICADO_X_GRUPOUSUARIOs.ToList().ForEach(a => GRUPOUSUARIOS.Add(new E_COMUNICADO_X_GRUPOUSUARIO(a)));
            }
        }
    }
}