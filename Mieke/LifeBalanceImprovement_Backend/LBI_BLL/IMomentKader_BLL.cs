using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_BLL
{
    public interface IMomentKader_BLL
    {
        List<MomentKader_DTO> GetMomentkader(int id);
        MomentKader_DTO AddMomentKader(MomentKader_DTO newMomentKader);
    }
}
