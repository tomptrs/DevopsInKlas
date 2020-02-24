using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserCategory> UserCategories { get; set; }
    }
}
