using AutoMapper;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_BLL.Helpers
{
    class User_BLL : IUsers_BLL
    {
        private readonly IUsers_DAL users_DAL;
        public User_BLL(IUsers_DAL _users_DAL)
        {
            users_DAL = _users_DAL;
        }

        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Users, Users_DTO>();
            cfg.CreateMap<Users_DTO, Users>();
            cfg.CreateMap<MomentKader, MomentKader_DTO>();
            cfg.CreateMap<MomentKader_DTO, MomentKader>();
            cfg.CreateMap<EigenNetwerk, EigenNetwerk_DTO>();
            cfg.CreateMap<EigenNetwerk_DTO, EigenNetwerk>();
            cfg.CreateMap<Goals, Goals_DTO>();
            cfg.CreateMap<Goals_DTO, Goals>();
            cfg.CreateMap<Agenda_DTO, Agenda>();
            cfg.CreateMap<Agenda, Agenda_DTO>();
            cfg.CreateMap<AgendaItem_DTO, AgendaItem>();
            cfg.CreateMap<AgendaItem, AgendaItem_DTO>();
            cfg.CreateMap<Category_DTO, Category>();
            cfg.CreateMap<Category, Category_DTO>();
            cfg.CreateMap<Happiness, Happiness_DTO>();
            cfg.CreateMap<Happiness_DTO, Happiness>();
            cfg.CreateMap<UserHappiness, UserHappiness_DTO>();
            cfg.CreateMap<UserHappiness_DTO, UserHappiness>();
            cfg.CreateMap<UserCategory_DTO, UserCategory>();
            cfg.CreateMap<UserCategory, UserCategory_DTO>();
            cfg.CreateMap<Stats_DTO, Stats>();
            cfg.CreateMap<Stats, Stats_DTO>();
            cfg.CreateMap<Log_DTO, Log>();
            cfg.CreateMap<Log, Log_DTO>();

        }));

        public Users_DTO UpdateNote(Users_DTO user)
        {
            var result = users_DAL.UpdateNote(mapper.Map<Users_DTO, Users>(user));
            return mapper.Map<Users, Users_DTO>(result);
        }

        public Users_DTO GetUser(string name)
        {
            return mapper.Map<Users, Users_DTO>(users_DAL.GetUser(name));
        }

        public List<Users_DTO> GetAllUsers()
        {
            var result = users_DAL.GetAllUsers();
            var returnResult = new List<Users_DTO>(); 
            foreach(Users user in result)
            {
                returnResult.Add(mapper.Map<Users, Users_DTO>(user)); 
            }
            return returnResult; 
        }

        public Users_DTO PostUser(Users_DTO newUser)
        {
            var result = users_DAL.PostUser(mapper.Map<Users_DTO, Users>(newUser));
            if (result != null) return mapper.Map<Users, Users_DTO>(result);
            else return null; 
        }
    }
}
