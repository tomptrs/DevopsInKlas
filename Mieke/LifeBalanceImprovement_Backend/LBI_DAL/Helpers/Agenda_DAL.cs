using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Threading.Tasks;

namespace LBI_DAL.Helpers
{
    public class Agenda_DAL : IAgenda_DAL
    {
        private static Calendar cal = new GregorianCalendar();
        private DayOfWeek firstDay = DayOfWeek.Monday; 

        private readonly LBIContext context;
        public Agenda_DAL(LBIContext _context)
        {
            context = _context;
        }

        public AgendaItem AddItem(int uId, AgendaItem agendaItem)
        {
            var agenda = context.AgendaDb.Include(a => a.AgendaItems).FirstOrDefault(x => x.Date.Date == agendaItem.StartDate.Date && x.UserId == uId);

            if (agenda == null)
            {
                Agenda a = new Agenda
                {
                    Date = agendaItem.StartDate.Date, 
                    AgendaItems = new List<AgendaItem>(),
                    UserId = uId
                };
                a.AgendaItems.Add(agendaItem);
                context.AgendaDb.Add(a);
                context.SaveChanges();
                return agendaItem; 
            }
            else
            {
                if (!checkOverlap(agendaItem, agenda))
                {
                    agenda.AgendaItems.Add(agendaItem);
                    context.AgendaDb.Update(agenda);
                    context.SaveChanges();
                    return agendaItem; 
                }
                else return null;
            }
        }

        private bool checkOverlap(AgendaItem agendaItem, Agenda agenda)
        {
            bool overlap = false; 
            foreach (var a in agenda.AgendaItems)
            {
                if (a.StartDate < agendaItem.EndDate && agendaItem.StartDate < a.EndDate)
                {
                    overlap = true;
                }
            }
            return overlap; 
        }

        public List<Agenda> getAgenda()
        {
            return context.AgendaDb.Include(i => i.AgendaItems).ThenInclude(u => u.UserCategory).ThenInclude(c => c.Category).ToList(); //Include(i => i.AgendaItems).
        }

        public Agenda GetAgendaByDate(int uId, string date)
        {
            var datum = DateTime.Parse(date); 
            var returnList = context.AgendaDb.Include(i => i.AgendaItems).ThenInclude(u => u.UserCategory).ThenInclude(c => c.Category).FirstOrDefault(a => a.Date.Date == datum.Date && a.UserId == uId);
            if(returnList != null)
            {
                var y = returnList.AgendaItems.OrderBy(x => x.StartDate.TimeOfDay);
                returnList.AgendaItems = y.ToList();
            }
            return returnList; 
        }

        public AgendaItem UpdateItem(AgendaItem agendaItem)
        {
            context.AgendaItemDb.Update(agendaItem);
            context.SaveChanges();
            return agendaItem;
        }

        public AgendaItem GetAgendaItemById(int id)
        {
            return context.AgendaItemDb.SingleOrDefault(a => a.Id == id); 
        }

        public void DeleteItem(int id)
        {
            var aItem = context.AgendaItemDb.SingleOrDefault(x => x.Id == id);
            this.RemoveLog(aItem); 
            context.AgendaItemDb.Remove(aItem);
            context.SaveChanges(); 
        }

        private void RemoveLog(AgendaItem agendaItem)
        {
            var week = cal.GetWeekOfYear(agendaItem.StartDate, CalendarWeekRule.FirstDay, firstDay);
            var stats = context.Statsdb.Include(l => l.Logs).SingleOrDefault(s => s.Week == week);
            var log = stats.Logs.SingleOrDefault(c => c.UserCategoryId == agendaItem.UserCategoryId);
            TimeSpan t = agendaItem.EndDate - agendaItem.StartDate;
            var h = t.TotalHours;
            log.Duration -= h;
            context.LogDb.Update(log);
            context.SaveChanges(); 
        }
    }
}
