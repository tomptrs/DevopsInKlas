using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Happiness
    {
        public int Id { get; set; }
        public string SmallDescription { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserHappiness> UserHapinesses { get; set; }
    }
}
