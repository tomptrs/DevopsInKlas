using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO;

namespace LBI_BLL
{
    public interface IStats_BLL
    {
        string UpdateLog(int id, AgendaItem_DTO agendaItem);
        List<Stats_DTO> GetStats();
        Stats_DTO GetStatsByDate(int id, DateTime date);
        Stats_DTO GetByWeek(int id, int week, int year);
        void UpdateStat(Stats_DTO stat);
        string AddLog(int uId, AgendaItem_DTO agendaItem); 
    }
}
