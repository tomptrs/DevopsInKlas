using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;

namespace LBI_BLL.Helpers
{
    public class MomentKader_BLL : IMomentKader_BLL
    {
        private readonly IMomentKader_DAL momentKader_DAL;
        public MomentKader_BLL(IMomentKader_DAL _momentKader_DAL)
        {
            momentKader_DAL = _momentKader_DAL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<MomentKader, MomentKader_DTO>();
            cfg.CreateMap<MomentKader_DTO, MomentKader>();
        }));
        public List<MomentKader_DTO> GetMomentkader(int id)
        {
            List<MomentKader_DTO> result = new List<MomentKader_DTO>();
            foreach (var element in momentKader_DAL.GetMomentKader(id))
            {
                result.Add(mapper.Map<MomentKader, MomentKader_DTO>(element));
            }
            return result;
        }

        public MomentKader_DTO AddMomentKader(MomentKader_DTO newMomentKader)
        {
            var momentKaderAdd = momentKader_DAL.AddMomentKader(mapper.Map<MomentKader_DTO, MomentKader>(newMomentKader));
            return mapper.Map<MomentKader, MomentKader_DTO>(momentKaderAdd);
        }
    }
}
