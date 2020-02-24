using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class Stats_DTO
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public bool Good { get; set; }
        public bool Bad { get; set; }
        public virtual ICollection<Log_DTO> Logs { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users_DTO User { get; set; }
    }
}
