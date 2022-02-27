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

        

        #endregion Public Methods
    }
}