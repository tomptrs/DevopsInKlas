using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Stats
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public bool Good { get; set; }
        public bool Bad { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
