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
    public class QuotesController : ControllerBase
    {
        public static IQuotes_BLL quotes_BLL;

        public QuotesController(IQuotes_BLL _quotes_BLL)
        {
            quotes_BLL = _quotes_BLL;
        }

        [HttpGet]
        public Quotes_DTO read()
        {
            return quotes_BLL.RandomQuotes();
        }

        // Er moet eigenlijk maar 1 quote terug komen
        // Dit kan random via ID of een andere protocol (navragen bij de klant) 
    }
}