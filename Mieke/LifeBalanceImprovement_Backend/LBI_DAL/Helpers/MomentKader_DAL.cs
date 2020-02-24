using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LBI_DAL.Models;

namespace LBI_DAL.Helpers
{
    public class MomentKader_DAL : IMomentKader_DAL
    {
        private readonly LBIContext context;
        public MomentKader_DAL(LBIContext _context)
        {
            context = _context;
        }
        public List<MomentKader> GetMomentKader(int id)
        {
            return context.MomentKaderDb.Where(m => m.UserId == id).ToList();
        }
        public MomentKader AddMomentKader(MomentKader newMomentKader)
        {
            context.MomentKaderDb.Add(newMomentKader);
            context.SaveChanges();
            var momentkaderAdd = context.MomentKaderDb.SingleOrDefault(x => x == newMomentKader);
            return momentkaderAdd;
        }
    }
}
