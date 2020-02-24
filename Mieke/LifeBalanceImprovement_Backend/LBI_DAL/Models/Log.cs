using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Log
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public int UserCategoryId { get; set; }
        public UserCategory UserCategory { get; set; }
        public Stats Stat { get; set; }
    }
}
