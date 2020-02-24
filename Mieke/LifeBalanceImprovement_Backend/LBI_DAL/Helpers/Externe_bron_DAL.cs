using LBI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBI_DAL.Helpers
{
    public class Externe_bron_DAL : IExterne_bron_DAL
    {
        private readonly LBIContext context;
        public Externe_bron_DAL(LBIContext _context)
        {
            context = _context;
        }

        public List<Externe_bron> GetExterne_bron()
        {
            return context.Externe_bronDb.ToList();
        }
    }
}
