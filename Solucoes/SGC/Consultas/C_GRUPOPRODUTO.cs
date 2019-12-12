using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_GRUPOPRODUTO
    {
        public static bool Salvar(E_GRUPOPRODUTO grupoproduto, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_grupo = (int?)grupoproduto.ID_GRUPO;

                Conexao.Banco.CAD_DIV_GRUPOPRODUTO(grupoproduto.OPERACAO.Value(),
                                                   ref id_grupo,
                                                   grupoproduto.DS_GRUPO);

                Conexao.Enviar();

                grupoproduto.ID_GRUPO = (int)id_grupo;
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