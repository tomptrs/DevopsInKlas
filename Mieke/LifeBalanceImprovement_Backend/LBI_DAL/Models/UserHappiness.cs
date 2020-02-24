using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class UserHappiness
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public int HappinessId { get; set; }
        public Happiness Happiness { get; set; }
        public bool Status { get; set; }
    }
}
