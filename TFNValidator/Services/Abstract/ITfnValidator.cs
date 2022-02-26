using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFNValidator.Services.Abstract
{
    public interface ITfnValidator
    {
        public bool Validate(string tfnNumber);
    }
}
