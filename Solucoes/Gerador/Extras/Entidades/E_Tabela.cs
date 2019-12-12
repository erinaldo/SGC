using System.Collections.Generic;

namespace Extras.Entidades
{
    public class E_Tabela
    {
        public string Name { get; set; }
        public List<E_Coluna> Columns { get; set; }

        public E_Tabela()
        {
            Name = "";
            Columns = new List<E_Coluna>();
        }
    }
}
