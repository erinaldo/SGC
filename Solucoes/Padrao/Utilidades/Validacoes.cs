using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utilidades
{
    public static class Validacoes
    {
        public static bool IPv4(this string ipv4)
        {
            try
            {
                var splitIp = ipv4.Split('.');

                if (splitIp.Length != 4)
                    return false;

                return !splitIp.Select(Int32.Parse).Any(a => a < 0 || a > 255);
            }
            catch
            {
                return false;
            }
        }

        public static bool OnlyNumbers(this string value)
        {
            value = value.Treat();

            return !Regex.IsMatch(value, "^[0-9]*$");
        }

        public static string WithoutAccentuation(this string value)
        {
            value.Treat();
            value = Regex.Replace(value, "[áàâãª]", "a");
            value = Regex.Replace(value, "[ÁÀÂÃ]", "A");
            value = Regex.Replace(value, "[éèê]", "e");
            value = Regex.Replace(value, "[ÉÈÊ]", "e");
            value = Regex.Replace(value, "[íìî]", "i");
            value = Regex.Replace(value, "[ÍÌÎ]", "I");
            value = Regex.Replace(value, "[óòôõº]", "o");
            value = Regex.Replace(value, "[ÓÒÔÕ]", "O");
            value = Regex.Replace(value, "[úùû]", "u");
            value = Regex.Replace(value, "[ÚÙÛ]", "U");
            value = Regex.Replace(value, "[ç]", "c");
            value = Regex.Replace(value, "[Ç]", "C");

            return value;
        }

        public static string WithoutPunctuation(this string value)
        {
            value = value.Treat();
            value = Regex.Replace(value, @"[^\w\s]", "");
            return value;
        }
    }
}