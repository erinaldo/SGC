using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_CARGO
    {
        public static bool Salvar(E_CARGO cargo, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_cargo = (int?)cargo.ID_CARGO;

                Conexao.Banco.CAD_DIV_CARGO(cargo.OPERACAO.Value(),
                                            ref id_cargo,
                                            cargo.DS_CARGO);

                Conexao.Enviar();

                cargo.ID_CARGO = (int)id_cargo;
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