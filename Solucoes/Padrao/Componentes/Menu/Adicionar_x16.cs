using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Componentes.Menu
{
    public partial class Adicionar_x16 : CSimpleButton
    {
        public Adicionar_x16()
        {
            InitializeComponent();
        }

        public Adicionar_x16(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
