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
    public class EigenNetwerkController : Controller
    {
        public static IEigenNetwerk_BLL EigenNetwerk_BLL;

        public EigenNetwerkController(IEigenNetwerk_BLL _eigennetwerk_BLL)
        {
            EigenNetwerk_BLL = _eigennetwerk_BLL;
        }

        [Route("{id}")]
        [HttpGet]
        public List<EigenNetwerk_DTO> read(int id)
        {
            return EigenNetwerk_BLL.GetEigenNetwerk(id);
        }

        [HttpPost]
        public IActionResult AddEigenNetwerk([FromBody] EigenNetwerk_DTO newEigenNetwerk)
        {
            var eigenNetwerkAdd = EigenNetwerk_BLL.AddEigenNetwerk(newEigenNetwerk);
            return Created("", eigenNetwerkAdd);
        }

    }
}