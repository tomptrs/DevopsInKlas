using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Externe_bron
    {
        public int Id { get; set; }
        public string Icone { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public string Site { get; set; }
        public string Mail { get; set; }
        public bool IsMail { get; set; }
        public string Phone { get; set; }
        public string Forum { get; set; }
        public string Chat { get; set; }
        public string ChatLink { get; set; }
    }

}

