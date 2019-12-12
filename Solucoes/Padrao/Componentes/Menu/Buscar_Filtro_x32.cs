using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Componentes.Menu
{
    public partial class Buscar_Filtro_x32 : CDropDownButton
    {
        public Buscar_Filtro_x32()
        {
            InitializeComponent();
        }

        public  Buscar_Filtro_x32(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        
    }
}
