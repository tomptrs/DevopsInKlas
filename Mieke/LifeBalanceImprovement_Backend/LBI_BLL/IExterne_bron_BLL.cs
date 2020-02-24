using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL.Models;
using LBI_DTO;

namespace LBI_BLL
{
    public interface IExterne_bron_BLL
    {
        List<Externe_bron_DTO> GetExterne_Bron();
    }
}
