using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Componentes.Menu
{
    public partial class Buscar_Filtro_x16 : CDropDownButton
    {
        public Buscar_Filtro_x16()
        {
            InitializeComponent();
        }

        public Buscar_Filtro_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
