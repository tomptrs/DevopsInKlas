using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LBI_DTO;
using LBI_BLL; 

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory_BLL _category_BLL; 
        public CategoryController(ICategory_BLL category_BLL)
        {
            _category_BLL = category_BLL;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetCategoriesByUser(int id)
        {
            var result = this._category_BLL.GetAll(id); 
            if(result != null)
            {
                return Ok(result); 
            }
            return BadRequest(result); 
        }
        [Route("mCategories")]
        [HttpPut]
        public IActionResult UpdateCategories(List<UserCategory_DTO> userCategories)
        {
            List<UserCategory_DTO> updatedCats = _category_BLL.UpdateCategories(userCategories);
            if (updatedCats != null)
            {
                return Ok(updatedCats);
            }
            else return BadRequest("not able to update categories");  
        }
        [HttpPut]
        public UserCategory_DTO Update(UserCategory_DTO userCategory)
        {
            return _category_BLL.Update(userCategory); 
        }
    }
}