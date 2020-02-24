using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;

namespace LBI_DAL.Helpers
{
    public class Goals_DAL : IGoals_DAL
    {
        private readonly LBIContext context;
        public Goals_DAL(LBIContext _context)
        {
            context = _context;
        }

        public Goals AddGoal(Goals newGoal)
        {
            context.GoalsDb.Add(newGoal);
            context.SaveChanges();
            var goalAdd = context.GoalsDb.SingleOrDefault(x => x == newGoal); 
            return goalAdd;
        }

        public List<Goals> GetGoals(int id)
        {
            return context.GoalsDb.Where(x => x.UserId == id).ToList(); 

        }

        public Goals UpdateGoal(Goals updateGoal)
        {
            var orgGoal = context.GoalsDb.Find(updateGoal.Id);
            if(orgGoal != null) {
                orgGoal.Percentage = updateGoal.Percentage;
                orgGoal.Progress = updateGoal.Progress;
                
                context.SaveChanges();
                return orgGoal;
            }
            return null;
            
        }
    }
}
