using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Model;

namespace TFNValidator.Services.Abstract
{
    public interface ILinkedValidator
    {
        public bool Validate(List<RequestEntry> input);
    }
}
