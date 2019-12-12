using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_ITEM
    {
        public static bool Salvar(E_ITEM item, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_item = (int?)item.ID_ITEM;

                Conexao.Banco.CAD_DIV_ITEM(item.OPERACAO.Value(),
                                            ref id_item,
                                            item.GRUPOPRODUTO == null ? null : (int?)item.GRUPOPRODUTO.ID_GRUPO,
                                            item.MODELO == null ? null : (int?)item.MODELO.ID_MODELO,
                                            item.DS_ITEM);

                Conexao.Enviar();

                item.ID_ITEM = (int)id_item;
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