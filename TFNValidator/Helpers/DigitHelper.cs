using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TFNValidator.Helpers
{
    public static class DigitHelper
    {
        #region Private Fields

        private static readonly Dictionary<int, int> BaseWeightFactor = new()
        {
            { 1, 10 },
            { 2, 7 },
            { 3, 8 },
            { 4, 4 },
            { 5, 6 },
            { 6, 3 },
            { 7, 5 }
        };

        #endregion Private Fields

        #region Public Methods

        public static bool ContainsOnlyNumber(string input)
        {
            Regex onlyNumber = new("^[0-9\\s]+$");
            return onlyNumber.IsMatch(input);
        }
        public static int GetWeightFactor_EightDigit(int input)
        {
            if (input == 8)
            {
                return 1;
            }
            if (BaseWeightFactor.ContainsKey(input))
            {
                return BaseWeightFactor[input];
            }
            return 0;
        }

        public static int GetWeightFactor_NineDigit(int input)
        {
            if (input == 9)
            {
                return 1;
            }
            if (input == 8)
            {
                return 2;
            }
            if (BaseWeightFactor.ContainsKey(input))
            {
                return BaseWeightFactor[input];
            }
            return 0;
        }

        public static string RemoveWhiteSpace(string input)
        {
            return input.Replace(" ", string.Empty);
        }

        #endregion Public Methods
    }
}