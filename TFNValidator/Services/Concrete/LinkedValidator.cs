using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Model;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Services.Concrete
{
    public class LinkedValidator : ILinkedValidator
    {
        public bool Validate(List<RequestEntry> input)
        {
            return true;
        }
    }
}
