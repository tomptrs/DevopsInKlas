using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class AgendaItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserCategoryId { get; set; } 
        public UserCategory UserCategory { get; set; }
        public Agenda Agenda { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
