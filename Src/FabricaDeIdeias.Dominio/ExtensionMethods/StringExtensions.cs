using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FabricaDeIdeias.Dominio.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string RemoverAcentos(this String valor)
        {
            return new string(valor.Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray()).ToUpper();
        }

        public static string ApenasNumeros(this String valor)
        {
            //string caracteres = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]|[^\w\s]|[ºª]";

            //return new Regex(caracteres).Replace(valor, "");
            return new Regex(@"[^0-9a]").Replace(valor, "");
        }
    }
}
