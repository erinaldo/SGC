
using System;
using System.Data;
using Utilidades;

namespace Extras.Entidades
{
    public class E_Coluna
    {
        public string Name { get; set; }

        public bool PK { get; set; }
        public bool FK { get; set; }
        public bool Identity { get; set; }

        public string SqlType { get; set; }
        public Type CSharpType
        {
            get
            {
                return SqlType.ToCSharpType(Nullable);
            }
            set
            {
                SqlType = SqlType;
            }
        }

        public int Size { get; set; }
        public int Scale { get; set; }

        public bool Nullable { get; set; }
    }
}