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
        public bool Validate(string tfnNumber)
        {
            if (tfnNumber.Length == 8)
            {
                return _eightDigiValidator.Validate(tfnNumber);
            }
            if (tfnNumber.Length == 9)
            {
                return _nineDigitTfnValidator.Validate(tfnNumber);
            }
            return false;
        }
    }
}
