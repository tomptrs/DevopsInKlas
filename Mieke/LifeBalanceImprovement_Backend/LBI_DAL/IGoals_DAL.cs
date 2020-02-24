using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL.Models;

namespace LBI_DAL
{
    public interface IGoals_DAL
    {
        List<Goals> GetGoals(int id);
        Goals AddGoal(Goals newGoal);
        Goals UpdateGoal(Goals updateGoal);
    }
}
