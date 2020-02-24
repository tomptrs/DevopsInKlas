using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL.Models;

namespace LBI_DAL
{
    public interface IStats_DAL
    {
        Stats GetStatsByWeek(int week, int v, int year);
        void UpdateLog(int cId, double dif, int week, int uId, int year);
        List<Stats> GetStats();
        void UpdateStat(Stats stats);
        Stats CreateStats(Stats stat); 
    }
}
