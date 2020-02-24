using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO;
using LBI_DAL;
using LBI_DAL.Models; 
using AutoMapper;
using System.Linq;

namespace LBI_BLL.Helpers
{
    public class Agenda_BLL : IAgenda_BLL
    {
        private readonly IAgenda_DAL _agenda_DAL;

        public Agenda_BLL() { }

        public Agenda_BLL(IAgenda_DAL agenda_DAL)
        {
            _agenda_DAL = agenda_DAL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Agenda_DTO, Agenda>();
            cfg.CreateMap<Agenda, Agenda_DTO>();
            cfg.CreateMap<AgendaItem_DTO, AgendaItem>();
            cfg.CreateMap<AgendaItem, AgendaItem_DTO>();
            cfg.CreateMap<Category_DTO, Category>();
            cfg.CreateMap<Category, Category_DTO>();
            cfg.CreateMap<UserCategory_DTO, UserCategory>();
            cfg.CreateMap<UserCategory, UserCategory_DTO>();
        }));
        public List<Agenda_DTO> GetAgenda()
        {
            List<Agenda> result = _agenda_DAL.getAgenda();
            List<Agenda_DTO> returnResult = new List<Agenda_DTO>(); 
            foreach(var element in result)
            {
                returnResult.Add(mapper.Map<Agenda, Agenda_DTO>(element)); 
            }
            return returnResult; 
        }

        public Agenda_DTO GetAgendaByDate(int uId, string date)
        {
            var result = _agenda_DAL.GetAgendaByDate(uId, date);
            var returnResult = mapper.Map<Agenda, Agenda_DTO>(result);
            return returnResult; 
        }

        public AgendaItem_DTO AddItem(int uId, AgendaItem_DTO agendaItem)
        {
            agendaItem.StartDate = new DateTime(agendaItem.StartDate.Year, agendaItem.StartDate.Month, agendaItem.StartDate.Day, agendaItem.StartDate.Hour, agendaItem.StartDate.Minute, 0, 0);
            agendaItem.EndDate = new DateTime(agendaItem.EndDate.Year, agendaItem.EndDate.Month, agendaItem.EndDate.Day, agendaItem.EndDate.Hour, agendaItem.EndDate.Minute, 0, 0);
            AgendaItem item = mapper.Map<AgendaItem_DTO, AgendaItem>(agendaItem);
            var result = mapper.Map<AgendaItem, AgendaItem_DTO>(_agenda_DAL.AddItem(uId, item));
            return result; 
        }

        public AgendaItem_DTO UpdateItem(AgendaItem_DTO agendaItem)
        {
            AgendaItem item = mapper.Map<AgendaItem_DTO, AgendaItem>(agendaItem);
            AgendaItem_DTO returnItem = mapper.Map<AgendaItem, AgendaItem_DTO>(_agenda_DAL.UpdateItem(item));
            return returnItem; 

        }

        public AgendaItem_DTO GetAgendaItemById(int id)
        {
            return mapper.Map<AgendaItem, AgendaItem_DTO>(_agenda_DAL.GetAgendaItemById(id)); 
        }

        public void DeleteItem(int id)
        {
            _agenda_DAL.DeleteItem(id); 
        }
    }
}
