using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public bool FirstLoginStats { get; set; }
        public virtual ICollection<UserCategory> UserCategories { get; set; }
        public virtual ICollection<Stats> Stats { get; set; }
        public virtual ICollection<Agenda> Agendas { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<EigenNetwerk> EigenNetwerken { get; set; }
        public virtual ICollection<MomentKader> MomentKaders { get; set; }
        public virtual ICollection<UserHappiness> UserHappiness { get; set; }

    }
}
