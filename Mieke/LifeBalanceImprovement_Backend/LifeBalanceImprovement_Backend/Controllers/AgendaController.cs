using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LBI_BLL;
using LBI_DTO;
using System.Globalization; 
using Newtonsoft.Json; 

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly IAgenda_BLL _agenda_BLL;
        public AgendaController(IAgenda_BLL agenda_BLL)
        {
            _agenda_BLL = agenda_BLL;
        }
        [HttpGet]
        public IActionResult getAgenda()
        {
            List<Agenda_DTO> result = _agenda_BLL.GetAgenda();

            return Ok(result);
        }
        [Route("GetByDate/{id}")]
        [HttpPost]
        public IActionResult getAgendaByDate(int id, [FromBody] String date)
        {
            var result = _agenda_BLL.GetAgendaByDate(id, date);
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("No agenda yet on this date!");
        }
        [Route("{id}")]
        [HttpPost]
        public IActionResult AddAgendaItem(int id, [FromBody] AgendaItem_DTO agendaItem)
        {
            var result = _agenda_BLL.AddItem(id, agendaItem);
            if (result != null)
            {
                return Ok();
            }
            else return BadRequest("De datums van je agendapunt overlappen met een ander agendapunt!");
        }
        [HttpPut]
        public IActionResult UpdateAgendaItem([FromBody] AgendaItem_DTO agendaItem)
        {
            var x = _agenda_BLL.UpdateItem(agendaItem);
            return Ok();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteAgendaItem(int id)
        {
            _agenda_BLL.DeleteItem(id); 
            return Ok(); 
        }
    }
}