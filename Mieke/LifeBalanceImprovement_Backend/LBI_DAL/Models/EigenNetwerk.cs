using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class EigenNetwerk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Nummer { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
