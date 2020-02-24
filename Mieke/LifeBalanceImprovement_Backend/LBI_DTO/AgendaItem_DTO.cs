using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class AgendaItem_DTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserCategoryId { get; set; }
        public UserCategory_DTO UserCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [JsonIgnore]
        public Agenda_DTO Agenda { get; set; }
    }
}
