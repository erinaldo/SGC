using Modelo;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Utilidades
{
    public static class Conexao
    {
        public static class Parametros
        {
            public static string Servidor = "";
            public static string Banco = "";
            public static string Usuario = "Lorensoft";
            public static string Senha = "";
        }

        private static BancoDataContext dataContext = null;
        private static DbTransaction dbTransaction = null;
        private static bool testando = false;

        public static BancoDataContext Banco
        {
            get
            {
                if (dataContext == null)
                    dataContext = new BancoDataContext(String.Format("Data Source={0};Initial Catalog={1};User id={2};Password={3};Connection Timeout={4}", Parametros.Servidor, Parametros.Banco, Parametros.Usuario, Parametros.Senha, (testando) ? "5" : "30"));

                dataContext.CommandTimeout = 60000;

                return dataContext;
            }
        }

        public static void Reiniciar()
        {
            dataContext = null;
        }

        public static bool Testar()
        {
            testando = true;
            var transacao = 0;

            if (Iniciar(ref transacao))
            {
                Finalizar(ref transacao); // Se conectou, é necessário fechar a conexão.
                testando = false;
                return true;
            }
            else
            {
                testando = false;
                return false;
            }
        }

        public static bool Iniciar(ref int transacao)
        {
            try
            {
                if (transacao == 0)
                {
                    Banco.Connection.Open();
                    dbTransaction = Banco.Connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    Banco.Transaction = dbTransaction;
                }
                    
                transacao++;
            }
            catch (SqlException excessao)
            {
                if (excessao.Number == 67 && testando)
                    Mensagens.Alerta(string.Format("Não foi possível conectar-se ao banco de dados!{0}Por favor, verifique os dados de conexão e/ou sua conexão!", Environment.NewLine));
                else if (excessao.Number == 67)
                    Mensagens.Alerta(string.Format(@"Você está desconectado do banco de dados!{0}Por favor, verifique os dados de conexão e/ou sua conexão!{0}{0}Obs.: Os processos realizados não serão salvos!", Environment.NewLine));
                else
                    Mensagens.Alerta(excessao.Tratar());

                return false;
            }

            return true;
        }

        public static bool Enviar()
        {
            try
            {
                Banco.SubmitChanges();
            }
            catch (SqlException excessao)
            {
                if (excessao.Number == 1205) // Deadlock
                    Enviar();
                else
                    throw new Exception(excessao.Tratar());

                return false;
            }

            return true;
        }

        public static bool Finalizar(ref int transacao)
        {
            try
            {
                if (transacao == 1)
                {
                    Enviar();

                    Banco.Transaction = dbTransaction;
                    Banco.Transaction.Commit();
                    Banco.Transaction.Dispose();
                    Banco.Connection.Close();
                    Banco.Transaction = null;
                    dbTransaction = null;
                }
                 
                transacao--;
            }
            catch (SqlException excessao)
            {
                if (excessao.Number == 1205) // Deadlock
                    Finalizar(ref transacao);
                else
                    throw new Exception(excessao.Tratar());
            }

            return true;
        }

        public static bool Voltar(ref int transacao)
        {
            try
            {
                if (transacao == 1 && dbTransaction != null)
                {
                    dbTransaction.Rollback();
                    dbTransaction = null;

                    Banco.Transaction.Dispose();
                    Banco.Connection.Close();
                    Banco.Transaction = null;
                }

                transacao--;
            }
            catch (SqlException excessao)
            {
                if (excessao.Number == 1205) // Deadlock
                    Voltar(ref transacao);
                else
                    throw new Exception(excessao.Tratar());

                return false;
            }

            return true;
        }
    }
}