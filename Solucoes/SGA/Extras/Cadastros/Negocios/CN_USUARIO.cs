using Extras.Cadastros.Entidades;
using Utilidades;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Extras.Cadastros.Negocios
{
    public static class CN_USUARIO
    {
        public static IQueryable<CE_USUARIO> Buscar()
        {
            //return (from a in Conexao.Banco.TB_DIV_USUARIOs
            //        select new CE_USUARIO
            //        {
            //            LOGIN = a.LOGIN,
            //            SENHA = a.SENHA,
            //            NM_USUARIO = a.NM_USUARIO,
            //            TELEFONE = a.TELEFONE,
            //            EMAIL = a.EMAIL
            //        });

            return null;
        }

        public static void Gravar(CE_USUARIO usuario, int transacao)
        {
            try
            {
                Conexao.Iniciar(transacao);

                //Conexao.Banco.CAD_DIV_USUARIO(usuario.OPERACAO.Value(),
                //                              usuario.LOGIN,
                //                              usuario.SENHA,
                //                              usuario.NM_USUARIO,
                //                              usuario.TELEFONE,
                //                              usuario.EMAIL);

                Conexao.Finalizar(transacao);
            }
            catch (SqlException sqlExcessao)
            {
                Conexao.Voltar(transacao);

                Excessoes.SqlExceptions(sqlExcessao);
            }
            catch (Exception excessao)
            {
                Excessoes.Exceptions(excessao);
            }
        }
    }
}