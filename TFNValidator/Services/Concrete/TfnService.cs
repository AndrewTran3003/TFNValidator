using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class TfnService : ITfnService
    {
        public OperationResultMessage<object> ValidateTfnString(string tfnString)
        {
            throw new NotImplementedException();
        }
    }
}
