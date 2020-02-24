using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;
using AutoMapper;

namespace LBI_BLL.Helpers
{
    public class Quotes_BLL : IQuotes_BLL
    {
        private readonly IQuotes_DAL quotes_DAL;
        public Quotes_BLL(IQuotes_DAL _quotes_DAL)
        {
            quotes_DAL = _quotes_DAL;
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Quotes, Quotes_DTO>();
            cfg.CreateMap<Quotes_DTO, Quotes>();
        }));

        public List<Quotes_DTO> GetQuotes()
        {
            var result = quotes_DAL.GetQoutes();
            List<Quotes_DTO> returnResult = new List<Quotes_DTO>();

            foreach (var element in result)
            {
                returnResult.Add(mapper.Map<Quotes, Quotes_DTO>(element));
            }

            return returnResult;
        }
        public Quotes_DTO RandomQuotes()
        {
            Random r = new Random();
            var result = quotes_DAL.GetQoutes();
            Quotes_DTO returnResult = new Quotes_DTO();
            int num = r.Next(0, result.Count);
            returnResult = mapper.Map<Quotes, Quotes_DTO>(result[num]);
            return returnResult;
        }
    }
}
