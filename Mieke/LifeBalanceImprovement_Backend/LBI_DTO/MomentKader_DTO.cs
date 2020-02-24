using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class MomentKader_DTO
    {
        public int Id { get; set; }
        public string Gedachte { get; set; }
        public string Emotie { get; set; }
        public string Lichaam { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public Users_DTO User { get; set; }
    }
}
