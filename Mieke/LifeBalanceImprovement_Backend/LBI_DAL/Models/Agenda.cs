using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } 
        public virtual ICollection<AgendaItem> AgendaItems { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
