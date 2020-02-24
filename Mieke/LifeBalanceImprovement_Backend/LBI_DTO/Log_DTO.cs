using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class Log_DTO
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public int UserCategoryId { get; set; }
        public UserCategory_DTO UserCategory { get; set; }
        public int StatId { get; set; }
        [JsonIgnore]
        public Stats_DTO Stat { get; set; }
    }
}
