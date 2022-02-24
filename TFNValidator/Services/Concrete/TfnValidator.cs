using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;

namespace TFNValidator.Services.Concrete
{
    public class TfnValidator
    {
        public bool VerifyNineDigitTfn(string tfnNumber)
        {
            string tfnTrimmed = DigitHelper.RemoveWhiteSpace(tfnNumber);
            if (!DigitHelper.ContainsOnlyNumber(tfnTrimmed))
            {
                return false;
            }
            int factor = tfnTrimmed.Select((numberChar, index) => DigitHelper.GetWeightFactor_NineDigit(index+1) * DigitHelper.ConvertToInt(numberChar)).Sum() % 11;
            return factor == 0;
        }

        
    }
}
