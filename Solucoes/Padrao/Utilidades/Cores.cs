using System.Drawing;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Cores
    {
        //public static void Required(this Control control)
        //{
        //    control.BackColor = Color.FromArgb(255, 192, 192);
        //}

        public static void In(this Control control, bool readyOnly)
        {
            if (!readyOnly)
                control.BackColor = Color.FromArgb(255, 255, 192);
        }

        public static void Out(this Control control, bool readyOnly)
        {
            if (control != null && !control.Disposing)
                control.BackColor = readyOnly ? Color.FromArgb(245, 245, 247) : Color.FromArgb(255, 255, 255);
        }

        public static Color Sistema()
        {
            return Color.FromArgb(235, 236, 239);
        }
    }
}