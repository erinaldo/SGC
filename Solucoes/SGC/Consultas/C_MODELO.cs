using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_MODELO
    {
        public static bool Salvar(E_MODELO modelo, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_modelo = (int?)modelo.ID_MODELO;

                Conexao.Banco.CAD_DIV_MODELO(modelo.OPERACAO.Value(),
                                             ref id_modelo,
                                             modelo.MARCA != null ? (int?)modelo.MARCA.ID_MARCA : null,
                                             modelo.DS_MODELO);

                Conexao.Enviar();

                modelo.ID_MODELO = (int)id_modelo;
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