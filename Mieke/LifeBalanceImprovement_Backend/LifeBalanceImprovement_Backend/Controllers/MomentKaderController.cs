using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LBI_BLL;
using LBI_DTO;

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MomentKaderController : Controller
    {
        public static IMomentKader_BLL momentKader_BLL;
        public MomentKaderController(IMomentKader_BLL _momentkader_BLL)
        {
            momentKader_BLL = _momentkader_BLL;
        }
        [Route("{id}")]
        [HttpGet]
        public List<MomentKader_DTO> GetMomentkader(int id)
        {
            return momentKader_BLL.GetMomentkader(id);
        }
        [HttpPost]
        public IActionResult AddMomentKader([FromBody] MomentKader_DTO newMomentKader)
        {
            var momentkaderAdd = momentKader_BLL.AddMomentKader(newMomentKader);
            return Created("", momentkaderAdd);
        }
    }
}