using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;

namespace LBI_DAL.Helpers
{
    public class Quotes_DAL : IQuotes_DAL
    {
        private readonly LBIContext context;
        public Quotes_DAL(LBIContext _context)
        {
            context = _context;
        }
        public List<Quotes> GetQoutes()
        {
            return context.QuotesDb.ToList();
        }
        public Quotes RandomQuotes()
        {
            return context.QuotesDb.SingleOrDefault();
        }
    }
}
