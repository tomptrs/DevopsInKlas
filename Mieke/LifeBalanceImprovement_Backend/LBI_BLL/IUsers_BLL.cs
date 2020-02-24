using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_BLL
{
    public interface IUsers_BLL
    {
        Users_DTO UpdateNote(Users_DTO user);
        Users_DTO GetUser(string name);
        List<Users_DTO> GetAllUsers();
        Users_DTO PostUser(Users_DTO newUser);
    }
}
