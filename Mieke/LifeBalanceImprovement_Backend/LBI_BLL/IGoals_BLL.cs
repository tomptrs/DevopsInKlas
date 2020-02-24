using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO; 

namespace LBI_BLL
{
    public interface IGoals_BLL
    {
        List<Goals_DTO> GetGoals(int id);
        Goals_DTO AddGoal(Goals_DTO newGoal);
        Goals_DTO UpdateGoal(Goals_DTO updateGoal);
    }
}
