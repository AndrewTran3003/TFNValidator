using System.Text.RegularExpressions;

namespace TFNValidator.Helpers
{
    public static class DigitHelper
    {
        #region Public Methods

        public static bool ContainsOnlyNumber(string input)
        {
            Regex onlyNumber = new("^[0-9\\s]+$");
            return onlyNumber.IsMatch(input);
        }

        public static int ConvertToInt(char numberChar)
        {
            return numberChar - '0';
        }

        public static string RemoveWhiteSpace(string input)
        {
            return input.Replace(" ", string.Empty);
        }

        #endregion Public Methods
    }
}