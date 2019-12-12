using Utilidades;

namespace Extras.Cadastros.Entidades
{
    public class CE_USUARIO
    {
        public Operacao OPERACAO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public string NM_USUARIO { get; set; }
        public string TELEFONE { get; set; }
        public string EMAIL { get; set; }

        public CE_USUARIO()
        {
            OPERACAO = Operacao.Normal;
            LOGIN = "";
            SENHA = "";
            NM_USUARIO = "";
            TELEFONE = "";
            EMAIL = "";
        }
    }
}