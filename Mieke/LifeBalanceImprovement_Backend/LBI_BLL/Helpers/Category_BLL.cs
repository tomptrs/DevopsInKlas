using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO;
using LBI_DAL;
using LBI_DAL.Models; 
using AutoMapper; 

namespace LBI_BLL.Helpers
{
    public class Category_BLL : ICategory_BLL
    {
        private readonly ICategory_DAL _category_DAL;

        public Category_BLL() { }

        public Category_BLL(ICategory_DAL category_DAL)
        {
            _category_DAL = category_DAL; 
        }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Category_DTO, Category>();
            cfg.CreateMap<Category, Category_DTO>();
            cfg.CreateMap<UserCategory_DTO, UserCategory>();
            cfg.CreateMap<UserCategory, UserCategory_DTO>();
            cfg.CreateMap<Log, Log_DTO>();
            cfg.CreateMap<Log_DTO, Log>();
            cfg.CreateMap<AgendaItem, AgendaItem_DTO>();
            cfg.CreateMap<AgendaItem_DTO, AgendaItem>(); 
        })); 
        public UserCategory_DTO Update(UserCategory_DTO cat)
        {
            var category =  mapper.Map<UserCategory_DTO, UserCategory>(cat);
            return mapper.Map<UserCategory, UserCategory_DTO>(_category_DAL.Update(category)); 
        }

        public List<UserCategory_DTO> GetAll(int id)
        {
            var result = _category_DAL.GetAll(id);
            List<UserCategory_DTO> returnResult = new List<UserCategory_DTO>();
            if (result != null)
            {
                foreach (var element in result)
                {
                    returnResult.Add(mapper.Map<UserCategory, UserCategory_DTO>(element));
                }
                return returnResult;
            }
            else return null; 
        }

        public List<UserCategory_DTO> UpdateCategories(List<UserCategory_DTO> userCategories)
        {
            List<UserCategory> updateCats = new List<UserCategory>();
            foreach(var c in userCategories)
            {
                updateCats.Add(mapper.Map<UserCategory_DTO, UserCategory>(c)); 
            }
            var result = _category_DAL.UpdateCategories(updateCats); 
            List<UserCategory_DTO> returnResult = new List<UserCategory_DTO>();
            foreach (var c in result)
            {
                returnResult.Add(mapper.Map<UserCategory, UserCategory_DTO>(c));
            }
            return returnResult; 
        }
    }
}
