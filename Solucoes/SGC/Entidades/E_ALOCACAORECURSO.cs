using Modelo;
using System;
using Utilidades;

namespace Entidades
{
    public class E_ALOCACAORECURSO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_ALOCACAO { get; set; }
        public string GRUPOUSUARIO { get; set; }
        public string EQUIPAMENTO { get; set; }
        public string DS_OBSERVACAO { get; set; }
        public DateTime? DT_INICIO_HMS { get; set; }
        public DateTime? DT_FINAL_HMS { get; set; }
        public string ST_REGISTRO { get; set; }

        public E_MODELO MODELO { get; set; }
        public string DS_MODELO { get; set; }
        public E_MARCA MARCA { get; set; }
        public string DS_MARCA { get; set; }

        public E_ALOCACAORECURSO(TB_DIV_ALOCACAORECURSO alocacaoRecurso = null)
        {
            OPERACAO = Operacao.Normal;

            if (alocacaoRecurso != null)
            {
                ID_ALOCACAO = alocacaoRecurso.ID_ALOCACAO;
                GRUPOUSUARIO = alocacaoRecurso.TB_DIV_GRUPOUSUARIO != null ? (string.Format("{0} - {1}", alocacaoRecurso.TB_DIV_GRUPOUSUARIO.ID_GRUPOUSUARIO, alocacaoRecurso.TB_DIV_GRUPOUSUARIO.DS_GRUPO.Treat())) : "";
                EQUIPAMENTO = alocacaoRecurso.TB_DIV_EQUIPAMENTO != null ? (string.Format("{0} - {1}", alocacaoRecurso.TB_DIV_EQUIPAMENTO.ID_EQUIPAMENTO, alocacaoRecurso.TB_DIV_EQUIPAMENTO.DS_OBSERVACAO.Treat())) : "";
                DS_OBSERVACAO = alocacaoRecurso.DS_OBSERVACAO.Treat();
                DT_INICIO_HMS = alocacaoRecurso.DT_INICIO_HMS.GetValueOrDefault();
                DT_FINAL_HMS = alocacaoRecurso.DT_FINAL_HMS.GetValueOrDefault();
                ST_REGISTRO = alocacaoRecurso.ST_REGISTRO.Treat();

                if (alocacaoRecurso.TB_DIV_EQUIPAMENTO != null && alocacaoRecurso.TB_DIV_EQUIPAMENTO.TB_DIV_MODELO != null)
                {
                    MODELO = new E_MODELO(alocacaoRecurso.TB_DIV_EQUIPAMENTO.TB_DIV_MODELO);
                    DS_MODELO = string.Format("{0} - {1}", MODELO.ID_MODELO, MODELO.DS_MODELO.Treat());

                    if (alocacaoRecurso.TB_DIV_EQUIPAMENTO.TB_DIV_MODELO.TB_DIV_MARCA != null)
                    {
                        MARCA = new E_MARCA(alocacaoRecurso.TB_DIV_EQUIPAMENTO.TB_DIV_MODELO.TB_DIV_MARCA);
                        DS_MARCA = string.Format("{0} - {1}", MARCA.ID_MARCA, MARCA.DS_MARCA.Treat());
                    }
                }
            }
        }
    }
}