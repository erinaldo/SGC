using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_EVENTO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_EVENTO { get; set; }
        public int ID_CHAMADO { get; set; }
        public string STATUS { get; set; }
        public string DS_EVENTO { get; set; }
        public string TP_EVENTO { get; set; }

        public DateTime DT_EVENTO { get; set; }
        public List<E_ANEXO> ANEXOS { get; set; }

        public string LOGIN_ATENDENTE { get; set; }
        public string LOGIN_FINALIZADOR { get; set; }

        public E_EVENTO(TB_DIV_EVENTO evento = null)
        {
            OPERACAO = Operacao.Normal;

            if (evento != null)
            {
                ID_EVENTO = evento.ID_EVENTO;
                ID_CHAMADO = evento.ID_CHAMADO;
                STATUS = String.Format("{0} - {1}", evento.SIGLA_STATUS, Conexao.Banco.TB_DIV_STATUS.FirstOrDefault(a => a.SIGLA_STATUS == evento.SIGLA_STATUS).DS_STATUS.Treat());
                DS_EVENTO = evento.DS_EVENTO;
                DT_EVENTO = evento.DT_EVENTO.GetValueOrDefault();
                TP_EVENTO = evento.TP_EVENTO.Treat();

                if (evento.LOGIN_ATENDENTE != null)
                    LOGIN_ATENDENTE = String.Format("{0} - {1}", evento.LOGIN_ATENDENTE, Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == evento.LOGIN_ATENDENTE).NM_USUARIO.Treat());

                if(evento.LOGIN_FINALIZADOR != null)
                    LOGIN_FINALIZADOR = String.Format("{0} - {1}", evento.LOGIN_FINALIZADOR, Conexao.Banco.TB_DIV_USUARIOs.FirstOrDefault(a => a.LOGIN == evento.LOGIN_FINALIZADOR).NM_USUARIO.Treat());

                if (evento.TB_DIV_EVENTO_X_ANEXOs != null && evento.TB_DIV_EVENTO_X_ANEXOs.Count > 0)
                {
                    ANEXOS = new List<E_ANEXO>();
                    evento.TB_DIV_EVENTO_X_ANEXOs.Select(a => a.TB_DIV_ANEXO).ToList().ForEach(a => ANEXOS.Add(new E_ANEXO(a)));
                }
            }
        }
    }
}