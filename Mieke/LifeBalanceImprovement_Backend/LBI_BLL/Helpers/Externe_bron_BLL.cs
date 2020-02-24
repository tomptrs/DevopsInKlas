using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;
using AutoMapper;

namespace LBI_BLL.Helpers
{
    public class Externe_bron_BLL : IExterne_bron_BLL
    {
        private readonly IExterne_bron_DAL externe_Bron_DAL;

        public Externe_bron_BLL(IExterne_bron_DAL _externe_bron_DAL)
        {
            externe_Bron_DAL = _externe_bron_DAL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Externe_bron, Externe_bron_DTO>();
            cfg.CreateMap<Externe_bron_DTO, Externe_bron>();
        }));

        public List<Externe_bron_DTO> GetExterne_Bron()
        {
            var result = externe_Bron_DAL.GetExterne_bron();
            List<Externe_bron_DTO> returnResult = new List<Externe_bron_DTO>();

            foreach (var element in result)
            {
                returnResult.Add(mapper.Map<Externe_bron, Externe_bron_DTO>(element));
            }

            return returnResult;
        }
    }
}
