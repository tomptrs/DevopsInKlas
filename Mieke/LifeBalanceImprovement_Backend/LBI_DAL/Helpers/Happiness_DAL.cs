using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LBI_DAL.Helpers
{
    public class Happiness_DAL: IHappiness_DAL
    {
        private readonly LBIContext context;
        public Happiness_DAL(LBIContext _context)
        {
            context = _context;
        }

        public List<UserHappiness> GetHappiness(int id)
        {
            return context.UserHappinessDb.Include(h => h.Happiness).Where(x => x.UserId == id).ToList();
        }

        public UserHappiness UpdateHappiness(UserHappiness happinessItem)
        {
            context.UserHappinessDb.Update(happinessItem);
            context.SaveChanges();
            return happinessItem;
        }
    }
}
