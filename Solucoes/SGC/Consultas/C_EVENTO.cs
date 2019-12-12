using Entidades;
using System;
using System.Linq;
using Utilidades;

namespace Consultas
{
    public static class C_EVENTO
    {
        public static bool Salvar(E_EVENTO evento, ref int transacao, bool finalizando = false, int nota = 0, string ds_sugestao = "", E_TRANSF_ATENDENTE transferencia = null)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_evento = (int?)evento.ID_EVENTO;

                Conexao.Banco.CAD_DIV_EVENTO(evento.OPERACAO.Value(),
                                             ref id_evento,
                                             evento.ID_CHAMADO,
                                             evento.STATUS.GetValue(),
                                             evento.DT_EVENTO,
                                             evento.DS_EVENTO,
                                             evento.TP_EVENTO,
                                             evento.LOGIN_ATENDENTE,
                                             evento.LOGIN_FINALIZADOR);
                Conexao.Enviar();

                evento.ID_EVENTO = (int)id_evento;

                if (finalizando)
                {
                    var chamado = Conexao.Banco.TB_DIV_CHAMADOs.First(a => a.ID_CHAMADO == evento.ID_CHAMADO);

                    chamado.ST_CHAMADO = "F";
                    chamado.DT_FINALIZADO = Conexao.Banco.GetDate();
                    chamado.DT_PREVISTA = chamado.DT_PREVISTA != null ? chamado.DT_PREVISTA : chamado.DT_FINALIZADO;
                    chamado.DT_ATENDIMENTO = chamado.DT_ATENDIMENTO != null ? chamado.DT_ATENDIMENTO : chamado.DT_FINALIZADO;
                    chamado.LOGIN_ATENDENTE = chamado.LOGIN_ATENDENTE != null ? chamado.LOGIN_ATENDENTE : Parametros.Usuario;
                    chamado.NOTA = nota;
                    chamado.DS_SUGESTAO = ds_sugestao.Treat();

                    Conexao.Enviar();
                }

                if (evento.OPERACAO == Operacao.Cadastrar && evento.ANEXOS != null && evento.ANEXOS.Count > 0)
                    evento.ANEXOS.ForEach(a =>
                    {
                        var id_anexo = (int?)a.ID_ANEXO;

                        Conexao.Banco.CAD_DIV_ANEXO(Operacao.Cadastrar.Value(),
                                                    ref id_anexo,
                                                    a.ANEXO,
                                                    a.NM_ANEXO,
                                                    a.EXTENSAO);
                        Conexao.Enviar();

                        Conexao.Banco.CAD_DIV_EVENTO_X_ANEXO(Operacao.Cadastrar.Value(),
                                                             evento.ID_EVENTO,
                                                             evento.ID_CHAMADO,
                                                             id_anexo);
                        Conexao.Enviar();
                    });

                if (transferencia != null)
                    C_TRANSFERENCIAUSUARIO.Salvar(transferencia, ref transacao);
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