using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL.Models; 

namespace LBI_DAL
{
    public interface IAgenda_DAL
    {
        List<Agenda> getAgenda();
        Agenda GetAgendaByDate(int uId, string date);
        AgendaItem AddItem(int uId, AgendaItem agendaItem);
        AgendaItem UpdateItem(AgendaItem agendaItem);
        AgendaItem GetAgendaItemById(int id);
        void DeleteItem(int id);
    }
}
