using System.Globalization;

namespace ElficoTM.Pages
{
    internal static class Extensions
    {
        private static readonly CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
        private static readonly CompareOptions options = CompareOptions.IgnoreCase | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreNonSpace;
        public static bool Contains(this Word word, string userInput)
        {
            return compareInfo.IndexOf(word.Elven, userInput, options) >= 0;
        }
    }
}
