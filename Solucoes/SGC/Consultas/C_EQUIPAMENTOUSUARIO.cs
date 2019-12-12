using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public class C_EQUIPAMENTOUSUARIO
    {
        public static bool Salvar(E_EQUIPAMENTOUSUARIO equipamentoUsuario, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                Conexao.Banco.CAD_DIV_EQUIPAMENTO_X_USUARIO(equipamentoUsuario.OPERACAO.Value(),
                                                            equipamentoUsuario.USUARIO.GetValue(),
                                                            equipamentoUsuario.EQUIPAMENTO.GetValue().ToInt(),
                                                            equipamentoUsuario.DS_OBSERVACAO,
                                                            equipamentoUsuario.ST_USOCOMPARTILHADO.Treat(),
                                                            equipamentoUsuario.ST_REGISTRO.Treat(),
                                                            equipamentoUsuario.LOGIN_CANCELAMENTO,
                                                            equipamentoUsuario.DS_CANCELAMENTO.Treat());

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