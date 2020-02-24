using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;
using LBI_DTO;
using Microsoft.EntityFrameworkCore;

namespace LBI_DAL.Helpers
{
    class Stats_DAL : IStats_DAL

    {
        private readonly LBIContext context;
        public Stats_DAL(LBIContext _context)
        {
            context = _context;
        }

        public List<Stats> GetStats()
        {
            return context.Statsdb.Include(l => l.Logs).ThenInclude(c => c.UserCategory).ThenInclude(c => c.Category).ToList(); 
        }

        public Stats GetStatsByWeek(int id, int week, int year)
        {
            var entry = context.Statsdb.Include(l => l.Logs).ThenInclude(c => c.UserCategory).ThenInclude(c => c.Category).SingleOrDefault(s => s.Week == week && s.UserId == id && s.Year == year);
            if(entry != null)
            {
                context.Entry(entry).State = EntityState.Detached;
                foreach (var log in entry.Logs)
                {
                    context.Entry(log).State = EntityState.Detached;
                }
            }
            return entry; 
        }

        public void UpdateLog(int cId, double dif, int week, int uId, int year)
        {
            var stats = GetStatsByWeek(uId, week, year);
            var log = stats.Logs.SingleOrDefault(c => c.UserCategoryId == cId);
            if (log != null)
            {
                log.Duration += dif;
                context.LogDb.Update(log);
                context.SaveChanges();
            }
            else
            {
                Log l = new Log
                {
                    Duration = dif,
                    UserCategoryId = cId
                };
                stats.Logs.Add(l);
                context.SaveChanges();
            }
        }

        public Stats CreateStats(Stats stat)
        {
            context.Statsdb.Add(stat);
            context.SaveChanges();
            context.Entry(stat).State = EntityState.Detached; 
            return stat; 
        }

        public void UpdateStat(Stats stats)
        {
            context.Statsdb.Update(stats);
            context.SaveChanges(); 
        }
    }
}
