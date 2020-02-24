using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO;
using LBI_DAL;
using LBI_DAL.Models;
using AutoMapper;

namespace LBI_BLL.Helpers
{
    public class EigenNetwerk_BLL : IEigenNetwerk_BLL
    {
        private readonly IEigenNetwerk_DAL eigenNetwerk_DAL;
        public EigenNetwerk_BLL(IEigenNetwerk_DAL _eigenNetwerk_DAL)
        {
            eigenNetwerk_DAL = _eigenNetwerk_DAL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<EigenNetwerk, EigenNetwerk_DTO>();
            cfg.CreateMap<EigenNetwerk_DTO, EigenNetwerk>();
        }));


        public List<EigenNetwerk_DTO> GetEigenNetwerk(int id)
        {
            var result = eigenNetwerk_DAL.GetEigenNetwerk(id);
            List<EigenNetwerk_DTO> returnResult = new List<EigenNetwerk_DTO>();

            foreach (var element in result)
            {
                returnResult.Add(mapper.Map<EigenNetwerk, EigenNetwerk_DTO>(element));
            }

            return returnResult;
        }
        public EigenNetwerk_DTO AddEigenNetwerk(EigenNetwerk_DTO newEigenNetwerk)
        {
            var eigenNetwerkAdd = eigenNetwerk_DAL.AddEigenNetwerk(mapper.Map<EigenNetwerk_DTO, EigenNetwerk>(newEigenNetwerk));
            return mapper.Map<EigenNetwerk, EigenNetwerk_DTO>(eigenNetwerkAdd);
        }
    }
}
