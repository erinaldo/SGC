using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public class C_CHAMADO
    {
        public static bool Salvar(E_CHAMADO chamado, ref int transacao, E_EVENTO evento = null)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_chamado = (int?)chamado.ID_CHAMADO;
                var id_categoria = (int?)(chamado.CATEGORIA.HasValue() ? chamado.CATEGORIA.Split('-').FirstOrDefault().ToInt() as int? : null);
                var id_departamento = (int?)(chamado.DEPARTAMENTO.HasValue() ? chamado.DEPARTAMENTO.Split('-').FirstOrDefault().ToInt() as int? : null);
                var login_solicitante = chamado.LOGIN_SOLICITANTE.Treat().Split('-').FirstOrDefault().Treat().Trim();
                var login_atendente = chamado.LOGIN_ATENDENTE.Treat().Split('-').FirstOrDefault().Trim().Trim();

                Conexao.Banco.CAD_DIV_CHAMADO(chamado.OPERACAO.Value(),
                                              ref id_chamado,
                                              id_categoria,
                                              login_solicitante.HasValue() ? login_solicitante : null,
                                              login_atendente.HasValue() ? login_atendente : null,
                                              id_departamento,
                                              chamado.DS_CHAMADO,
                                              chamado.DS_OBSERVACAO,
                                              chamado.DS_SOLUCAO,
                                              chamado.DS_RESUMO,
                                              chamado.DS_SUGESTAO,
                                              chamado.NOTA,
                                              chamado.ESTIMATIVA_TEMPO,
                                              (chamado.PRIORIDADE ?? new E_PRIORIDADE()).ID_PRIORIDADE,
                                              chamado.ST_CHAMADO,
                                              chamado.DT_CHAMADO,
                                              chamado.DT_PREVISTA,
                                              chamado.DT_FINALIZADO,
                                              chamado.DT_ATENDIMENTO,
                                              chamado.DT_REQUERIDA);
                Conexao.Enviar();

                chamado.ID_CHAMADO = (int)id_chamado;

                if (evento != null)
                {
                    evento.ID_CHAMADO = chamado.ID_CHAMADO;
                    evento.OPERACAO = Operacao.Cadastrar;

                    C_EVENTO.Salvar(evento, ref transacao);
                }

                if (chamado.ANEXOS != null && chamado.ANEXOS.Count > 0 && chamado.OPERACAO == Operacao.Cadastrar)
                    foreach (var anexo in chamado.ANEXOS)
                    {
                        var id_anexo = (int?)anexo.ID_ANEXO;

                        Conexao.Banco.CAD_DIV_ANEXO(chamado.OPERACAO.Value(),
                                                    ref id_anexo,
                                                    anexo.ANEXO,
                                                    anexo.NM_ANEXO,
                                                    anexo.EXTENSAO);
                        Conexao.Enviar();
                        anexo.ID_ANEXO = (int)id_anexo;

                        Conexao.Banco.CAD_DIV_ANEXO_X_CHAMADO(chamado.OPERACAO.Value(),
                                                              id_chamado,
                                                              id_anexo);
                        Conexao.Enviar();
                    }
            }
            catch (Exception excessao)
            {
                Conexao.Voltar(ref transacao);
                throw excessao;
            }

            Conexao.Finalizar(ref transacao);

            return true;
        }
    }
}