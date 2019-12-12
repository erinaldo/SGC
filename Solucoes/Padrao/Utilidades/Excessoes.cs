using System;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Excessoes
    {
        public static string Tratar(this Exception excessao)
        {
            var message = excessao.InnerException != null ? excessao.InnerException.Message : excessao.Message;
            message = message.Replace("Ã£", "ã");
            message = message.Replace("Ãi", "á");
            message = message.Replace("Ã­", "í");

            return message;
        }

        public static Exception AlterandoSemRegistro(string nomeObjeto = "um registro")
        {
            return new Exception(String.Format("É necessário selecionar {0} para alterar!", nomeObjeto));
        }
    }
}