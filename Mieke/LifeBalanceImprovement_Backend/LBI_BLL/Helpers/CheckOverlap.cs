using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_BLL.Helpers
{
    public static class CheckOverlap
    {
        public static bool checkOverlap(AgendaItem_DTO agendaItem, Agenda_DTO agenda)
        {
            bool overlap = false;
            foreach (var a in agenda.AgendaItems)
            {
                if(a.Id != agendaItem.Id)
                {
                    if (a.StartDate < agendaItem.EndDate && agendaItem.StartDate < a.EndDate)
                    {
                        overlap = true;
                    }
                }
            }
            return overlap;
        }
    }
}
