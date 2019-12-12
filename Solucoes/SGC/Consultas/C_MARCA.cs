using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_MARCA
    {
        public static bool Salvar(E_MARCA marca, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_marca = (int?)marca.ID_MARCA;

                Conexao.Banco.CAD_DIV_MARCA(marca.OPERACAO.Value(),
                                            ref id_marca,
                                            marca.DS_MARCA);

                Conexao.Enviar();

                marca.ID_MARCA = (int)id_marca;
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