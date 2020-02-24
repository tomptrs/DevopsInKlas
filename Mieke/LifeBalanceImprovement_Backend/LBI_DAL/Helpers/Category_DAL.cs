using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LBI_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LBI_DAL.Helpers
{
    public class Category_DAL : ICategory_DAL
    {
        private LBIContext context;
        public Category_DAL(LBIContext _context)
        {
            context = _context;
        }
        public UserCategory Update(UserCategory userCategory)
        {
            context.Update(userCategory);
            context.SaveChanges();
            return userCategory; 
        }

        public List<UserCategory> GetAll(int id)
        {
            return context.UserCategoryDb.Include(c => c.Category).Include(l => l.Logs).Include(i => i.AgendaItems).Where(x => x.UserId == id).ToList(); 
        }

        public List<UserCategory> UpdateCategories(List<UserCategory> updateCats)
        {
            foreach(var c in updateCats)
            {
                context.UserCategoryDb.Update(c); 
            }
            context.SaveChanges();
            return updateCats; 
        }
    }
}
