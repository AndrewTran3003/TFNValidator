using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class TfnValidatorFactory : ITfnValidatorFactory
    {
        private readonly INineDigitTfnValidator _nineDigitTfnValidator;
        private readonly IEightDigiValidator _eightDigiValidator;
        public TfnValidatorFactory(
            INineDigitTfnValidator nineDigitTfnValidator,
            IEightDigiValidator eightDigiValidator)
        {
            _nineDigitTfnValidator = nineDigitTfnValidator;
            _eightDigiValidator = eightDigiValidator;
        }

        public ITfnValidator GetValidator(string tfnNumber)
        {
            if (tfnNumber.Length == 8)
            {
                return _eightDigiValidator;
            }
            if (tfnNumber.Length == 9)
            {
                return _nineDigitTfnValidator;
            }
            return null;
        }
    }
}
