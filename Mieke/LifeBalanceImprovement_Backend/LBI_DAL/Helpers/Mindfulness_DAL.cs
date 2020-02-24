using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;

namespace LBI_DAL.Helpers
{
    public class Mindfulness_DAL: IMindfulness_DAL
    {
        private readonly LBIContext context;
        public Mindfulness_DAL(LBIContext _context)
        {
            context = _context;
        }
        public List<Mindfulness> GetMindfulness()
        {
            return context.MindfulnessDb.ToList();
        }
    }
}
