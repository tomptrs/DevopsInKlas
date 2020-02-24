using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class Goals_DTO
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Progress { get; set; }
        public int Amount { get; set; }
        public double Percentage { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users_DTO User { get; set; }
    }
}
