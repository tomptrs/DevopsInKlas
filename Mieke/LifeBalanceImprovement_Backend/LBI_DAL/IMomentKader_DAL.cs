using System;
using System.Collections.Generic;
using System.Text;
using LBI_DAL.Models;

namespace LBI_DAL
{
    public interface IMomentKader_DAL
    {
        List<MomentKader> GetMomentKader(int id);
        MomentKader AddMomentKader(MomentKader newMomentKader);
    }
}
