using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFNValidator.Model
{
    public class RequestEntry
    {
        public Guid Id{ get; set; }
        public string Value{ get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
