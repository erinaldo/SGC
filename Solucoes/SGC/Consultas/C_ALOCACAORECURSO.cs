using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_ALOCACAORECURSO
    {
        public static bool Salvar(E_ALOCACAORECURSO alocacaoRecurso, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_alocacao = (int?)alocacaoRecurso.ID_ALOCACAO;
                var id_grupoUsuario = (int?)alocacaoRecurso.GRUPOUSUARIO.GetValue().ToInt();
                var id_equipamento = (int?)alocacaoRecurso.EQUIPAMENTO.GetValue().ToInt();

                Conexao.Banco.CAD_DIV_ALOCACAORECURSO(alocacaoRecurso.OPERACAO.Value(),
                                                      ref id_alocacao,
                                                      id_grupoUsuario > 0 ? id_grupoUsuario : null,
                                                      id_equipamento > 0 ? id_equipamento : null,
                                                      alocacaoRecurso.DS_OBSERVACAO,
                                                      alocacaoRecurso.DT_INICIO_HMS,
                                                      alocacaoRecurso.DT_FINAL_HMS,
                                                      alocacaoRecurso.ST_REGISTRO);
                Conexao.Enviar();

                alocacaoRecurso.ID_ALOCACAO = (int)id_alocacao;
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