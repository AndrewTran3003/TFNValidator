using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class CommonTfnValidator : ICommonTfnValidator
    {
        public bool ValidateTfn(string tfnNumber, Func<int, int> weightFactorFunc)
        {
            string tfnTrimmed = DigitHelper.RemoveWhiteSpace(tfnNumber);
            if (!DigitHelper.ContainsOnlyNumber(tfnTrimmed))
            {
                return false;
            }
            return Result();


            IEnumerable<int> WeightFactorTimesNumberList()
            {
                return tfnTrimmed.Select(WeightFactorTimesNumber);
            }
            int WeightFactorTimesNumber(char numberChar, int index)
            {
                return weightFactorFunc(index + 1) * DigitHelper.ConvertToInt(numberChar);
            }
            bool Result()
            {
                return WeightFactorTimesNumberList().Sum() % 11 == 0;
            }
        }
    }
}
