using LBI_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBI_DAL.Helpers
{
    class Users_DAL : IUsers_DAL
    {
        private List<string> colors = new List<string>()
        {
            "rgb(0,0,255)",
            "rgb(255,0,0)",
            "rgb(0,128,0)",
            "rgb(255,255,0)",
            "rgb(255,165,0)",
            "rgb(139,69,19)"
        }; 
        private readonly LBIContext context;
        public Users_DAL(LBIContext _context)
        {
            context = _context;
        }

        public List<Users> GetAllUsers()
        {
            return context.UsersDb.Include(c => c.UserCategories).ThenInclude(c => c.Category)
                                    .Include(e => e.EigenNetwerken)
                                    .Include(a => a.Agendas).ThenInclude(i => i.AgendaItems)
                                    .Include(u => u.UserHappiness).ThenInclude(h => h.Happiness)
                                    .Include(m => m.MomentKaders)
                                    .Include(g => g.Goals)
                                    .Include(s => s.Stats).ThenInclude(l => l.Logs)
                                    .ToList(); 
        }

        public Users UpdateNote(Users user)
        {
            var orgUser = context.UsersDb.Find(user.Id);
            if(orgUser != null)
            {
                orgUser.Note = user.Note;
                orgUser.FirstLoginStats = user.FirstLoginStats; 

                context.SaveChanges();
                return orgUser;
            }
            return null;
        }

        public Users GetUser(string guid)
        {
            var user = context.UsersDb.SingleOrDefault(x => x.GUID == guid);
            return user; 
        }

        public Users PostUser(Users newUser)
        {
            var categories = context.CategoryDb.ToList(); 
            foreach(var c in categories)
            {
                context.Entry(c).State = EntityState.Detached;
                var uC = new UserCategory();
                uC.CategoryId = c.Id;
                uC.Color = this.colors[c.Id - 1];
                newUser.UserCategories.Add(uC); 
            }
            var happiness = context.HappinessDb.ToList(); 
            foreach(var h in happiness)
            {
                context.Entry(h).State = EntityState.Detached;
                var uH = new UserHappiness();
                uH.HappinessId = h.Id;
                uH.Status = false;
                newUser.UserHappiness.Add(uH); 
            }
            context.UsersDb.Add(newUser);
            context.SaveChanges();
            return newUser;
        }
    }
}
