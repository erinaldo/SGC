using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_CLIFOR
    {
        public static bool Salvar(E_CLIFOR clifor, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_clifor = (int?)clifor.ID_CLIFOR;

                 Conexao.Banco.CAD_DIV_CLIFOR(clifor.OPERACAO.Value(),
                                             ref id_clifor,
                                             clifor.NM_CLIFOR);

                 Conexao.Enviar();

                clifor.ID_CLIFOR = (int)id_clifor;
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