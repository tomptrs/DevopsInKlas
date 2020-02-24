using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LBI_BLL;
using LBI_DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HappinessController : ControllerBase
    {
        public static IHappiness_BLL happiness_BLL;

        public HappinessController(IHappiness_BLL _happiness_BLL)
        {
            happiness_BLL = _happiness_BLL;
        }

        [Route("{id}")]
        [HttpGet]
        //[Authorize]
        public List<UserHappiness_DTO> GetHappiness(int id)
        {
            return happiness_BLL.GetHappiness(id);
        }
        [HttpPut]
        //[Authorize]
        public IActionResult UpdateHappiness([FromBody] UserHappiness_DTO happinessItem)
        {
            var hp = happiness_BLL.UpdateHappiness(happinessItem);
            return Ok(hp);
        }
    }
}