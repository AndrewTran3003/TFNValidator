using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class NineDigitTfnValidator:INineDigitTfnValidator
    {
        private readonly ICommonTfnValidator _commonValidator;
        public NineDigitTfnValidator(ICommonTfnValidator commonTfnValidator)
        {
            _commonValidator = commonTfnValidator;
        }

        public bool Validate(string tfnNumber)
        {
            return _commonValidator.ValidateTfn(tfnNumber, WeightFactorHelper.Get_NineDigit);
        }
    }
}
