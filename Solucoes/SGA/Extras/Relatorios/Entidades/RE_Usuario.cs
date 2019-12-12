using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extras.Relatorios.Entidades
{
    public class RE_Usuario
    {
        public string Login { get; set; }
        public string Nome { get; set; }

        public RE_Usuario()
        {
            Login = "";
            Nome = "";
        }
    }
}
