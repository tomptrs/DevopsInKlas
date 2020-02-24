using LBI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBI_DAL.Helpers
{
    public class EigenNetwerk_DAL : IEigenNetwerk_DAL
    {
        private readonly LBIContext context;
        public EigenNetwerk_DAL(LBIContext _context)
        {
            context = _context;
        }

        public List<EigenNetwerk> GetEigenNetwerk(int id)
        {
            return context.EigenNetwerkDb.Where(x => x.UserId == id).ToList();
        }

        public EigenNetwerk AddEigenNetwerk(EigenNetwerk newEigenNetwerk)
        {
            context.EigenNetwerkDb.Add(newEigenNetwerk);
            context.SaveChanges();
            var eigenNetwerkAdd = context.EigenNetwerkDb.SingleOrDefault(x => x == newEigenNetwerk);
            return eigenNetwerkAdd;
        }
    }
}
