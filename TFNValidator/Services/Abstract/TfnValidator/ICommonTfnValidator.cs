using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFNValidator.Services.Abstract
{
    public interface ICommonTfnValidator
    {
        public bool ValidateTfn(string tfnNumber, Func<int, int> weightFactorFunc);
    }
}
