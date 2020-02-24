using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO; 

namespace LBI_BLL
{
    public interface IAgenda_BLL
    {
        List<Agenda_DTO> GetAgenda();
        Agenda_DTO GetAgendaByDate(int uId, string date);
        AgendaItem_DTO AddItem(int uId, AgendaItem_DTO agendaItem);
        AgendaItem_DTO UpdateItem(AgendaItem_DTO agendaItem);
        AgendaItem_DTO GetAgendaItemById(int id);
        void DeleteItem(int id);
    }
}
