using System;
using System.Windows.Forms;
using Utilidades;

namespace Aplicativo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Utilidades.Configuracoes.Padrao();

            if ((new FLogin().ShowDialog()) == DialogResult.OK)
                Application.Run(new FPrincipal());
        }
    }
}