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
    public class StatsController : ControllerBase
    {
        private readonly IStats_BLL _stats_BLL;
        public StatsController(IStats_BLL stats_BLL)
        {
            _stats_BLL = stats_BLL;
        }
        [HttpGet]
        public IActionResult GetStats() {
            return Ok(_stats_BLL.GetStats());
        }

        [Route("GetByDate/{id}/{date}")]
        [HttpGet]
        public IActionResult GetStatsByDate(int id, DateTime date)
        {
            return Ok(_stats_BLL.GetStatsByDate(id, date));
        }
        [Route("GetByWeek/{id}/{week}/{year}")]
        [HttpGet]
        public IActionResult GetByWeek(int id, int week, int year)
        {
            var result = _stats_BLL.GetByWeek(id, week, year); 
            return Ok(result);
        }
        [Route("{id}")]
        [HttpPost]
        public IActionResult AddLogItem(int id, [FromBody] AgendaItem_DTO agendaItem)
        {
            var result = _stats_BLL.AddLog(id, agendaItem);
            if (result != null)
            {
                return Ok();
            }
            else return BadRequest("De datums van je agendapunt overlappen met een ander agendapunt!");
        }

        [HttpPut]
        public IActionResult UpdateStat(Stats_DTO stat)
        {
            _stats_BLL.UpdateStat(stat); 
            return Ok(); 
        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult UpdateLog(int id, [FromBody] AgendaItem_DTO agendaItem)
        {
            var result = _stats_BLL.UpdateLog(id, agendaItem);
            if (result != null)
            {
                return Ok();
            }
            else return BadRequest("De datums van je agendapunt overlappen met een ander agendapunt!"); 
        }


    }
}