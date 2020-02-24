using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LBI_BLL;
using LBI_DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static IUsers_BLL users_BLL;
        public UsersController(IUsers_BLL _users_BLL)
        {
            users_BLL = _users_BLL;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(users_BLL.GetAllUsers()); 
        }
        [HttpPut]
        public IActionResult UpdateNote([FromBody] Users_DTO updateUser)
        {
            var result = users_BLL.UpdateNote(updateUser);
            if (result == null) return NotFound();
            else return Ok(result);
        }
        [HttpPost]
        public IActionResult PostUser([FromBody] Users_DTO newUser)
        {
            var result = users_BLL.PostUser(newUser);
            if (result != null) return Ok(result);
            else return BadRequest("Failed to add user to Db!"); 
        }
        [Route("{guid}")]
        [HttpGet]
        public IActionResult GetUserByGuid(string guid)
        {
            var result = users_BLL.GetUser(guid);
            if (result == null) return NotFound();
            else return Ok(result);
        }
    }
}