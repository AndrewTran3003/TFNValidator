using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Model;
namespace TFNValidator.Data
{
    public class RequestEntriesContext : DbContext
    {
        public RequestEntriesContext (DbContextOptions<RequestEntriesContext> options)
            :base(options)
        {

        }
        public DbSet<RequestEntry> RequestEntries{ get; set; }
    }
}
