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
    public class MindfulnessController : Controller
    {
        public static IMindfulness_BLL mindfulness_BLL;
        public MindfulnessController(IMindfulness_BLL _mindfulness_BLL)
        {
            mindfulness_BLL = _mindfulness_BLL;
        }

        [HttpGet]
        public List<Mindfulness_DTO> GetMindfulness()
        {
            return mindfulness_BLL.GetMindfulness();
        }
    }
}