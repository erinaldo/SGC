using Modelo;
using System;
using System.Collections.Generic;
using Utilidades;

namespace Entidades
{
    public class E_CONHECIMENTO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CONHECIMENTO { get; set; }
        public string CATEGORIA { get; set; }
        public string LOGIN_CAD { get; set; }
        public string DS_CONHECIMENTO { get; set; }
        public string DS_TITULO { get; set; }
        public DateTime? DT_LANCTO { get; set; }
        public string ST_REGISTRO { get; set; }

        public List<E_ANEXO> ANEXOS { get; set; }

        public E_CONHECIMENTO(TB_DIV_CONHECIMENTO conhecimento = null)
        {
            OPERACAO = Operacao.Normal;

            if (conhecimento != null)
            {
                ID_CONHECIMENTO = conhecimento.ID_CONHECIMENTO;
                CATEGORIA = conhecimento != null ? string.Format("{0} - {1}", conhecimento.TB_DIV_CATEGORIA.ID_CATEGORIA, conhecimento.TB_DIV_CATEGORIA.DS_CATEGORIA.Treat()) : "";
                LOGIN_CAD = conhecimento != null ? string.Format("{0} - {1}", conhecimento.TB_DIV_USUARIO.LOGIN, conhecimento.TB_DIV_USUARIO.NM_USUARIO.Treat()) : "";
                DS_CONHECIMENTO = conhecimento.DS_CONHECIMENTO.Treat();
                DS_TITULO = conhecimento.DS_TITULO.Treat();
                ST_REGISTRO = conhecimento.ST_REGISTRO.Treat();
                DT_LANCTO = conhecimento.DT_LANCTO.GetValueOrDefault();

                ANEXOS = new List<E_ANEXO>();

                if (conhecimento.TB_DIV_CONHECIMENTO_X_ANEXOs != null && conhecimento.TB_DIV_CONHECIMENTO_X_ANEXOs.Count > 0)
                    foreach (var anexo in conhecimento.TB_DIV_CONHECIMENTO_X_ANEXOs)
                        ANEXOS.Add(new E_ANEXO(anexo.TB_DIV_ANEXO));
            }
        }
    }
}