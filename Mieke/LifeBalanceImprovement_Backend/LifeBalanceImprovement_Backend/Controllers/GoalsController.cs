using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LBI_BLL;
using LBI_DTO; 

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalsController : ControllerBase
    {
        public static IGoals_BLL goals_BLL;

        public GoalsController(IGoals_BLL _goals_BLL)
        {
            goals_BLL = _goals_BLL;
        }

        [Route("{id}")]
        [HttpGet]
        public List<Goals_DTO> GetGoals(int id)
        {
            return goals_BLL.GetGoals(id);
        }

        [HttpPost]
        public IActionResult AddGoal([FromBody] Goals_DTO newGoal)
        {
            var goalAdd = goals_BLL.AddGoal(newGoal);
            return Created("", goalAdd);
        }

        [HttpPut]
        public IActionResult UpdateGoal([FromBody] Goals_DTO updateGoal)
        {
            var result = goals_BLL.UpdateGoal(updateGoal);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}