using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class UserHappiness_DTO
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users_DTO User { get; set; }
        public int HappinessId { get; set; }
        public Happiness_DTO Happiness { get; set; }
    }
}
