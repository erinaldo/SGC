using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Configuracoes
    {
        public static void Padrao()
        {
            PT_BR();
            Skin();
        }

        public static void PT_BR()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", true);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR", true);
        }

        public static void Skin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinRegistrator.Register();
            SkinManager.EnableFormSkins();
        }
    }
}