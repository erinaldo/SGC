using Utilidades;

namespace Entidades
{
    public class E_PRIORIDADE
    {
        public string ID_PRIORIDADE { get; set; }
        public string DS_PRIORIDADE
        {
            get
            {
                switch (ID_PRIORIDADE)
                {
                    case "1": return "ALTA";
                    case "2": return "MÉDIA";
                    case "3": return "BAIXA";
                    case "4": return "NÃO DEFINIDA";
                    default: return "";
                }
            }
        }

        public E_PRIORIDADE(string PRIORIDADE = null)
        {
            ID_PRIORIDADE = PRIORIDADE.Treat().Length == 0 ? "4" : PRIORIDADE.Treat().Split('-')[0].Trim();
        }
    }
}
