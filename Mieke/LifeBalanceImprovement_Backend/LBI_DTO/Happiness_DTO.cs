using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class Happiness_DTO
    {
        public int Id { get; set; }
        public string SmallDescription { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserHappiness_DTO> UserHappiness { get; set; }
    }
}
