using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL;
using LBI_DAL.Models; 
using System.Linq;
using LBI_DTO;
using AutoMapper; 
namespace LBI_BLL.Helpers
{
    public class Goals_BLL : IGoals_BLL
    {
        private readonly IGoals_DAL goals_DAL;
        public Goals_BLL(IGoals_DAL _goals_DAL)
        {
            goals_DAL = _goals_DAL;
        }

        public Goals_DTO AddGoal(Goals_DTO newGoal)
        {
            var goalAdd = goals_DAL.AddGoal(mapper.Map<Goals_DTO, Goals>(newGoal));
            return mapper.Map<Goals, Goals_DTO>(goalAdd);
        }

        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
       {
           cfg.CreateMap<Goals, Goals_DTO>();
           cfg.CreateMap<Goals_DTO, Goals>();
       })); 

        public List<Goals_DTO> GetGoals(int id)
        {
            var result = goals_DAL.GetGoals(id);
            List<Goals_DTO> resultResult = new List<Goals_DTO>();

            if (result != null)
            {
                foreach (var element in result)
                {
                    resultResult.Add(mapper.Map<Goals, Goals_DTO>(element));
                }
                return resultResult;
            }
            else return resultResult; 
        }

        public Goals_DTO UpdateGoal(Goals_DTO updateGoal)
        {
            if (updateGoal.Progress >= updateGoal.Amount) updateGoal.Progress = updateGoal.Amount;
            else if (updateGoal.Progress <= 0) updateGoal.Progress = 0;

            var percentage = (double) updateGoal.Progress / (double) updateGoal.Amount;
            updateGoal.Percentage = percentage; 
            
            var Result = goals_DAL.UpdateGoal(mapper.Map<Goals_DTO, Goals>(updateGoal));

            return mapper.Map<Goals, Goals_DTO>(Result); 
            
        }
    }
}
