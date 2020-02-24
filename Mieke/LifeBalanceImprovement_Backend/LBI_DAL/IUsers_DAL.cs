using LBI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL
{
    public interface IUsers_DAL
    {
        Users UpdateNote(Users user);
        Users GetUser(string user);
        List<Users> GetAllUsers();
        Users PostUser(Users users);
    }
}
