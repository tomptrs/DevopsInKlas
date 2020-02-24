using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class Users_DTO
    {
        public int Id { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public bool FirstLoginStats { get; set; }
        public virtual ICollection<UserCategory_DTO> UserCategories { get; set; }
        public virtual ICollection<Agenda_DTO> Agendas { get; set; }
        public virtual ICollection<Stats_DTO> Stats { get; set; }
        public virtual ICollection<Goals_DTO> Goals { get; set; }
        public virtual ICollection<EigenNetwerk_DTO> EigenNetwerken { get; set; }
        public virtual ICollection<MomentKader_DTO> MomentKaders { get; set; }
        public virtual ICollection<UserHappiness_DTO> UserHappiness { get; set; }
    }
}
