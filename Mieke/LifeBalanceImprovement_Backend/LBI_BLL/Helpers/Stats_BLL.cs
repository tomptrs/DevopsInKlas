using AutoMapper;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace LBI_BLL.Helpers
{
    public class Stats_BLL : IStats_BLL
    {
        private static Calendar cal = new GregorianCalendar();
        private DayOfWeek firstDay = DayOfWeek.Monday;

        private readonly IStats_DAL _stats_DAL;
        private readonly IAgenda_BLL _agenda_BLL; 

        public Stats_BLL() { }

        public Stats_BLL(IStats_DAL stats_DAL, IAgenda_BLL agenda_BLL)
        {
            _stats_DAL = stats_DAL;
            _agenda_BLL = agenda_BLL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Agenda_DTO, Agenda>();
            cfg.CreateMap<Agenda, Agenda_DTO>();
            cfg.CreateMap<AgendaItem_DTO, AgendaItem>();
            cfg.CreateMap<AgendaItem, AgendaItem_DTO>();
            cfg.CreateMap<Log_DTO, Log>();
            cfg.CreateMap<Log, Log_DTO>(); 
            cfg.CreateMap<Category_DTO, Category>();
            cfg.CreateMap<Category, Category_DTO>();
            cfg.CreateMap<Stats_DTO, Stats>();
            cfg.CreateMap<Stats, Stats_DTO>();
            cfg.CreateMap<UserCategory_DTO, UserCategory>();
            cfg.CreateMap<UserCategory, UserCategory_DTO>();
        }));
        public string UpdateLog(int id, AgendaItem_DTO newItem)
        {
            var agenda = _agenda_BLL.GetAgendaByDate(id, newItem.StartDate.Date.ToString());
            if (!CheckOverlap.checkOverlap(newItem, agenda))
            {
                AgendaItem_DTO prevItem = _agenda_BLL.GetAgendaItemById(newItem.Id);

                TimeSpan prevT = prevItem.EndDate - prevItem.StartDate;
                TimeSpan newT = newItem.EndDate - prevItem.StartDate;

                double pH = prevT.TotalHours;
                double nH = newT.TotalHours;

                var week = cal.GetWeekOfYear(prevItem.StartDate, CalendarWeekRule.FirstDay, firstDay);

                if (newItem.UserCategoryId == prevItem.UserCategoryId)
                {
                    double timeDif = nH - pH;

                    _stats_DAL.UpdateLog(prevItem.UserCategoryId, timeDif, week, id, newItem.StartDate.Year);
                }
                else
                {
                    _stats_DAL.UpdateLog(prevItem.UserCategoryId, -pH, week, id, newItem.StartDate.Year);
                    _stats_DAL.UpdateLog(newItem.UserCategoryId, nH, week, id, newItem.StartDate.Year);
                }
                return "success"; 
            }
            else return null; 
        }

        public List<Stats_DTO> GetStats()
        {
            var returnResult = new List<Stats_DTO>();
            foreach (Stats stat in _stats_DAL.GetStats())
            {
                returnResult.Add(mapper.Map<Stats, Stats_DTO>(stat)); 
            }
            return returnResult; 
        }

        public Stats_DTO GetStatsByDate(int id, DateTime date)
        {
            var week = cal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, firstDay);
            if (date.DayOfWeek.ToString() != "Sunday")
            {
                var result = GetByWeek(id, week - 1, date.Year);
                if (result == null)
                {
                    var returnResult = CreateNewStats(id, week - 1, date.Year); 
                    return returnResult; 
                }
                else return result; 
            }
            else {
                var result = GetByWeek(id, week, date.Year); 
                if (result == null)
                {
                    var returnResult = CreateNewStats(id, week - 1, date.Year);
                    return returnResult; 
                }
                return result; 
            }
        }
        public string AddLog(int uId, AgendaItem_DTO agendaItem)
        {
            var week = cal.GetWeekOfYear(agendaItem.StartDate, CalendarWeekRule.FirstDay, firstDay);
            var stats = GetByWeek(uId, week, agendaItem.StartDate.Date.Year);
            TimeSpan t = agendaItem.EndDate - agendaItem.StartDate;
            var h = t.TotalHours;
            if (stats != null)
            {
                var log = stats.Logs.SingleOrDefault(c => c.UserCategoryId == agendaItem.UserCategoryId);
                if (log != null)
                {
                    log.Duration += h;
                    UpdateStat(stats);
                    return "success"; 
                }
                else
                {
                    Log_DTO l = new Log_DTO
                    {
                        Duration = h,
                        UserCategoryId = agendaItem.UserCategoryId
                    };
                    stats.Logs.Add(l);
                    UpdateStat(stats);
                    return "success";
                }
            }
            else
            {
                Stats_DTO s = CreateNewStats(uId, week, agendaItem.StartDate.Year);

                Log_DTO l = new Log_DTO
                {
                    Duration = h,
                    UserCategoryId = agendaItem.UserCategoryId
                };
                s.Logs.Add(l);
                UpdateStat(s);
                return "success";
            }
        }

        private Stats_DTO CreateNewStats(int uId, int week, int year)
        {
            Stats_DTO stat = new Stats_DTO
            {
                UserId = uId,
                Week = week,
                Year = year,
                Logs = new List<Log_DTO>()
            };
            var s = mapper.Map<Stats, Stats_DTO>(_stats_DAL.CreateStats(mapper.Map<Stats_DTO, Stats>(stat))); 
            return s; 
        }

        public Stats_DTO GetByWeek(int id, int week, int year)
        {
            return mapper.Map<Stats, Stats_DTO>(_stats_DAL.GetStatsByWeek(id, week, year));
        }

        public void UpdateStat(Stats_DTO stat)
        {
            _stats_DAL.UpdateStat(mapper.Map<Stats_DTO, Stats>(stat)); 
        }
    }
}
