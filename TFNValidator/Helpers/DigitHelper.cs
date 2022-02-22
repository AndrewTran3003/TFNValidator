using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFNValidator.Helpers
{
    public static class DigitHelper
    {
        public static string RemoveWhiteSpace(string input)
        {
            return input.Replace(" ", string.Empty);
        }
        public static int GetWeightFactor_NineDigit(int input)
        {
            return input switch
            {
                1 => 10,
                2 => 7,
                3 => 8,
                4 => 4,
                5 => 6,
                6 => 3,
                7 => 5,
                8 => 2,
                9 => 1,
                _ => 0,
            };
        }
    }
}
