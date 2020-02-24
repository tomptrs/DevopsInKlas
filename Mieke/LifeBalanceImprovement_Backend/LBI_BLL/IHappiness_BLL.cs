using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_BLL
{
    public interface IHappiness_BLL
    {
        List<UserHappiness_DTO> GetHappiness(int id);
        UserHappiness_DTO UpdateHappiness(UserHappiness_DTO happinessItem);
    }
}
