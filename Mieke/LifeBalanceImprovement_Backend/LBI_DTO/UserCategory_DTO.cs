using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class UserCategory_DTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Color { get; set; }
        public double IdealValue { get; set; }
        public Category_DTO Category { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users_DTO User { get; set; }
        [JsonIgnore]
        public virtual ICollection<Log_DTO> Logs { get; set; }
        [JsonIgnore]
        public virtual ICollection<AgendaItem_DTO> AgendaItems { get; set; }
    }
}
