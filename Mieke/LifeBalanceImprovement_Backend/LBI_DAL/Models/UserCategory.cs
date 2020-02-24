using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class UserCategory
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public double IdealValue { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users User { get; set; }
        [JsonIgnore]
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<AgendaItem> AgendaItems { get; set; }
    }
}
