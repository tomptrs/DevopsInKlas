using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;

namespace LBI_BLL.Helpers
{
    public class Mindfulness_BLL : IMindfulness_BLL
    {
        private readonly IMindfulness_DAL mindfulness_DAL;
        public Mindfulness_BLL(IMindfulness_DAL _mindfulness_DAL)
        {
            mindfulness_DAL = _mindfulness_DAL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Mindfulness, Mindfulness_DTO>();
            cfg.CreateMap<Mindfulness_DTO, Mindfulness>();
        }));
        public List<Mindfulness_DTO> GetMindfulness()
        {
            List<Mindfulness_DTO> result = new List<Mindfulness_DTO>();
            foreach (var element in mindfulness_DAL.GetMindfulness())
            {
                result.Add(mapper.Map<Mindfulness, Mindfulness_DTO>(element));
            }
            return result;
        }
    }
}
