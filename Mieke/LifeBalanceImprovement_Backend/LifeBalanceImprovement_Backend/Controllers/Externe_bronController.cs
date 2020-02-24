using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LBI_BLL;
using Microsoft.AspNetCore.Mvc;
using LBI_DAL.Models;
using LBI_DTO;

namespace LifeBalanceImprovement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Externe_bronController : ControllerBase
    {
        public static IExterne_bron_BLL externe_Bron_BLL;

        public Externe_bronController(IExterne_bron_BLL _externe_Bron_BLL)
        {
            externe_Bron_BLL = _externe_Bron_BLL;
        }

        [HttpGet]
        public List<Externe_bron_DTO> read()
        {
            return externe_Bron_BLL.GetExterne_Bron();
        }
    }
}