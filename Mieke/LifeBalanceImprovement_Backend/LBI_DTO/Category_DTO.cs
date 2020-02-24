using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DTO
{
    public class Category_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<UserCategory_DTO> UserCategories { get; set; }
    }
}
