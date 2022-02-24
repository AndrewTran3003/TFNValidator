using System.Collections.Generic;

namespace TFNValidator.Helpers
{
    public static class WeightFactorHelper
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

        public static int Get_EightDigit(int input)
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

        public static int Get_NineDigit(int input)
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

        #endregion Public Methods
    }
}