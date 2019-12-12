using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilidades;

namespace Entidades
{
    public class E_CHAMADO
    {
        public Operacao OPERACAO { get; set; }
        public int ID_CHAMADO { get; set; }
        public string CATEGORIA { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string LOGIN_SOLICITANTE { get; set; }
        public string LOGIN_ATENDENTE { get; set; }
        public string DS_CHAMADO { get; set; }
        public string DS_OBSERVACAO { get; set; }
        public string DS_SOLUCAO { get; set; }
        public string DS_RESUMO { get; set; }
        public int ESTIMATIVA_TEMPO { get; set; }
        public E_PRIORIDADE PRIORIDADE { get; set; }
        public string ST_CHAMADO { get; set; }
        public DateTime? DT_CHAMADO { get; set; }
        public DateTime? DT_PREVISTA { get; set; }
        public DateTime? DT_FINALIZADO { get; set; }
        public DateTime? DT_ATENDIMENTO { get; set; }
        public DateTime? DT_REQUERIDA { get; set; }
        public List<E_ANEXO> ANEXOS { get; set; }

        public string DS_SUGESTAO { get; set; }
        public int NOTA { get; set; }

        public string EVOLUCAO { get; set; } // Informativo para o grid.
        public string ST_SOLICITANTE { get; set; } // Informativo para o grid.

        public DateTime? DT_ULTIMAEVOLUCAO { get; set; } // Informativo para o grid.
        public string DEPARTAMENTO_SOLICITANTE { get; set; } // Informativo para o grid.
        public string GRAVIDADE { get; set; } // Informativo para o grid.


        public E_CHAMADO(TB_DIV_CHAMADO chamado = null)
        {
            OPERACAO = Operacao.Normal;

            if (chamado != null)
            {
                ID_CHAMADO = chamado.ID_CHAMADO;
                LOGIN_SOLICITANTE = chamado.LOGIN_SOLICITANTE.Treat();
                LOGIN_ATENDENTE = chamado.LOGIN_ATENDENTE.Treat();
                
                CATEGORIA = chamado.TB_DIV_CATEGORIA != null ? String.Format("{0} - {1}", chamado.TB_DIV_CATEGORIA.ID_CATEGORIA, chamado.TB_DIV_CATEGORIA.DS_CATEGORIA.Treat()) : "";
                GRAVIDADE = chamado.TB_DIV_CATEGORIA != null ? (chamado.TB_DIV_CATEGORIA.GRAVIDADE == "1" ? "ALTA" : (chamado.TB_DIV_CATEGORIA.GRAVIDADE == "2" ? "MÉDIA" : (chamado.TB_DIV_CATEGORIA.GRAVIDADE == "3" ? "BAIXA" : ""))) : "";

                DEPARTAMENTO = chamado.TB_DIV_DEPARTAMENTO != null ? String.Format("{0} - {1}", chamado.TB_DIV_DEPARTAMENTO.ID_DEPARTAMENTO, chamado.TB_DIV_DEPARTAMENTO.DS_DEPARTAMENTO.Treat()) : "";

                if (LOGIN_SOLICITANTE.Length > 0)
                {
                    var departamento = Conexao.Banco.TB_DIV_USUARIOs.First(a => a.LOGIN == chamado.LOGIN_SOLICITANTE).TB_DIV_DEPARTAMENTO;

                    if (departamento != null)
                        DEPARTAMENTO_SOLICITANTE = String.Format("{0} - {1}", departamento.ID_DEPARTAMENTO, departamento.DS_DEPARTAMENTO.Treat());
                }

                DS_CHAMADO = chamado.DS_CHAMADO.Treat();
                DS_OBSERVACAO = chamado.DS_OBSERVACAO.Treat();
                DS_SOLUCAO = chamado.DS_SOLUCAO.Treat();
                DS_RESUMO = chamado.DS_RESUMO.Treat();
                ESTIMATIVA_TEMPO = chamado.ESTIMATIVA_TEMPO ?? 0;
                PRIORIDADE = new E_PRIORIDADE(chamado.PRIORIDADE);

                ST_CHAMADO = chamado.ST_CHAMADO.Treat();
                switch (ST_CHAMADO)
                {
                    case "A": ST_CHAMADO = "ABERTO"; break;
                    case "F": ST_CHAMADO = "FECHADO"; break;
                }

                if (chamado.TB_DIV_EVENTOs != null && chamado.TB_DIV_EVENTOs.Count > 0)
                {
                    var evolucao = chamado.TB_DIV_EVENTOs.OrderBy(a => a.ID_EVENTO).LastOrDefault().TB_DIV_STATUS;

                    if (evolucao != null)
                    {
                        EVOLUCAO = String.Format("{0} - {1}", evolucao.SIGLA_STATUS, evolucao.DS_STATUS);
                        ST_SOLICITANTE = evolucao.ST_SOLICITANTE.Treat();

                        switch (ST_SOLICITANTE)
                        {
                            case "S": ST_SOLICITANTE = "SIM"; break;
                            case "N": ST_SOLICITANTE = "NÃO"; break;
                        }
                    }
                }

                DT_CHAMADO = chamado.DT_CHAMADO;
                DT_PREVISTA = chamado.DT_PREVISTA;
                DT_FINALIZADO = chamado.DT_FINALIZADO;
                DT_ATENDIMENTO = chamado.DT_ATENDIMENTO;
                DT_REQUERIDA = chamado.DT_REQUERIDO;

                if (chamado.TB_DIV_EVENTOs != null && chamado.TB_DIV_EVENTOs.Count > 0)
                    DT_ULTIMAEVOLUCAO = chamado.TB_DIV_EVENTOs.OrderByDescending(a => a.ID_EVENTO).First().DT_EVENTO.GetValueOrDefault();

                ANEXOS = new List<E_ANEXO>();
                chamado.TB_DIV_ANEXO_X_CHAMADOs.Select(a => a.TB_DIV_ANEXO).ToList().ForEach(a =>
                    {
                        ANEXOS.Add(new E_ANEXO
                        {
                            ID_ANEXO = a.ID_ANEXO,
                            EXTENSAO = a.EXTENSAO,
                            ANEXO = a.ANEXO,
                            NM_ANEXO = a.NM_ANEXO
                        });
                    });
            }
        }
    }
}