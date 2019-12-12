using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_SALVASENHA
    {
        public static bool Salvar(E_SALVASENHA salvasenha, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_salvasenha = (int?)salvasenha.ID_SALVASENHA;

                Conexao.Banco.CAD_DIV_SALVASENHA(salvasenha.OPERACAO.Value(),
                                                 ref id_salvasenha,
                                                 salvasenha.LOGIN.LOGIN,
                                                 salvasenha.DS_OBSERVACAO,
                                                 salvasenha.SENHA);

                Conexao.Enviar();

                salvasenha.ID_SALVASENHA = (int)id_salvasenha;
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