using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL.Models; 

namespace LBI_DAL
{
    public interface ICategory_DAL
    {
        List<UserCategory> GetAll(int id);
        UserCategory Update(UserCategory userCategory);
        List<UserCategory> UpdateCategories(List<UserCategory> updateCats);
    }
}
