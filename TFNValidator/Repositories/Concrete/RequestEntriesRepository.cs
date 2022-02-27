﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFNValidator.Data;
using TFNValidator.Helpers;
using TFNValidator.Model;
using TFNValidator.Repositories.Abstract;

namespace TFNValidator.Repositories.Concrete
{
    public class RequestEntriesRepository : IRequestEntriesRepository
    {
        private readonly RequestEntriesContext _context;
        public RequestEntriesRepository(RequestEntriesContext context)
        {
            _context = context;
        }
        public void Add(string tfnValue)
        {
            _context.RequestEntries.Add(new RequestEntry
            {
                Id = new Guid(),
                DateSubmitted = DateTime.Now,
                Value = tfnValue
            }); 
        }

        public List<RequestEntry> GetRequestEntriesLast30Seconds()
        {
            return null;
        }
    }
}