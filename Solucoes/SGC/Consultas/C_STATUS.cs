using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_STATUS
    {
        public static bool Salvar(E_STATUS status, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                Conexao.Banco.CAD_DIV_STATUS(status.OPERACAO.Value(),
                                             status.SIGLA_STATUS,
                                             status.DS_STATUS,
                                             status.ST_TEMPORIZAR ? "S" : "N",
                                             status.ST_AUTORIZAR ? "S" : "N",
                                             status.ST_INICIAR ? "S" : "N",
                                             status.ST_FINALIZAR ? "S" : "N",
                                             status.ST_REGISTRO,
                                             status.ST_INTERNO ? "S" : "N",
                                             status.ST_SOLICITANTE ? "S" : "N");

                Conexao.Enviar();
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