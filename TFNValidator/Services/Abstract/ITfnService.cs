using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Helpers;

namespace TFNValidator.Services.Abstract
{
    public interface ITfnService
    {
        public OperationResultMessage<object> ValidateTfnString(string tfnString);
    }
}
