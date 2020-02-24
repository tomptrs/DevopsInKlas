using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;

namespace LBI_BLL.Helpers
{
    public class Happiness_BLL : IHappiness_BLL
    {
        private readonly IHappiness_DAL happiness_DAL;
        public Happiness_BLL(IHappiness_DAL _happiness_DAL)
        {
            happiness_DAL = _happiness_DAL;
        }

        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Happiness, Happiness_DTO>();
            cfg.CreateMap<Happiness_DTO, Happiness>();
            cfg.CreateMap<UserHappiness, UserHappiness_DTO>();
            cfg.CreateMap<UserHappiness_DTO, UserHappiness>(); 
        }));

        public List<UserHappiness_DTO> GetHappiness(int id)
        {
            List<UserHappiness_DTO> result = new List<UserHappiness_DTO>();

            foreach(var element in happiness_DAL.GetHappiness(id))
            {
                result.Add(mapper.Map<UserHappiness, UserHappiness_DTO>(element));
            }

            return result;
        }

        public UserHappiness_DTO UpdateHappiness(UserHappiness_DTO happinessItem)
        {
            UserHappiness item = mapper.Map<UserHappiness_DTO, UserHappiness>(happinessItem);
            UserHappiness_DTO returnItem = mapper.Map<UserHappiness, UserHappiness_DTO>(happiness_DAL.UpdateHappiness(item));
            return returnItem;
        }
    }
}
