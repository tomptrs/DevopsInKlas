using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class MomentKader
    {
        public int Id { get; set; }
        public string Gedachte { get; set; }
        public string Emotie { get; set; }
        public string Lichaam { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
