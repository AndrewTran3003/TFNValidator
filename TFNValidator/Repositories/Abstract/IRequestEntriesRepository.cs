using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Model;

namespace TFNValidator.Repositories.Abstract
{
    public interface IRequestEntriesRepository
    {
        public void Add(string tfnValue);
        public List<RequestEntry> GetRequestEntriesLast30Seconds();
    }
}
