using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LBI_DTO
{
    public class Agenda_DTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<AgendaItem_DTO> AgendaItems { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users_DTO User { get; set; }
    }
}
