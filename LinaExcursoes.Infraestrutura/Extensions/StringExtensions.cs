using System.Globalization;
using System.Text;

namespace LinExcursoes.Infraestrutura.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveAccents(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public static string Normalizacao(this string text)
        {
            return text.RemoveAccents().ToUpper();
        }

    }
}