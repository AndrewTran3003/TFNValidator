using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFNValidator.Services.Concrete
{
    public class NineDigitTFNValidator
    {
        public bool VerifyTFNNumber(string tfnNumber)
        {
            return false;
        }

        private int GetWeightFactor(int input)
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
