using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO; 

namespace LBI_BLL
{
    public interface ICategory_BLL
    {
        List<UserCategory_DTO> GetAll(int id); 
        UserCategory_DTO Update(UserCategory_DTO userCategory_DTO);
        List<UserCategory_DTO> UpdateCategories(List<UserCategory_DTO> userCategories);
    }
}
