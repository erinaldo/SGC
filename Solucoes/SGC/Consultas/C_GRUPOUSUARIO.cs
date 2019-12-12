using Entidades;
using System;
using Utilidades;

namespace Consultas
{
    public static class C_GRUPOUSUARIO
    {
        public static bool Salvar(E_GRUPOUSUARIO grupousuario, ref int transacao)
        {
            try
            {
                Conexao.Iniciar(ref transacao);

                var id_grupo = (int?)grupousuario.ID_GRUPOUSUARIO;

                Conexao.Banco.CAD_DIV_GRUPOUSUARIO(grupousuario.OPERACAO.Value(),
                                                   ref id_grupo,
                                                   grupousuario.DS_GRUPO);

                Conexao.Enviar();

               grupousuario.ID_GRUPOUSUARIO = (int)id_grupo;
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