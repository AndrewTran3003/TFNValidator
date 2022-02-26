using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class EightDigitValidator : IEightDigiValidator
    {
        private readonly ICommonTfnValidator _commonValidator;
        public EightDigitValidator(ICommonTfnValidator commonTfnValidator)
        {
            _commonValidator = commonTfnValidator;
        }
        public bool Validate(string tfnNumber)
        {
            return _commonValidator.ValidateTfn(tfnNumber, WeightFactorHelper.Get_EightDigit);
        }
    }
}
