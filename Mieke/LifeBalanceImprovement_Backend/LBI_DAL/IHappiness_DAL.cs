using LBI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL
{
    public interface IHappiness_DAL
    {
        List<UserHappiness> GetHappiness(int id);
        UserHappiness UpdateHappiness(UserHappiness happinessItem);
    }
}
