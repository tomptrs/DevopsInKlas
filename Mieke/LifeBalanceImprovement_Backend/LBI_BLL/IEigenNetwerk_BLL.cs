using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO;

namespace LBI_BLL
{
    public interface IEigenNetwerk_BLL
    {
        List<EigenNetwerk_DTO> GetEigenNetwerk(int id);
        EigenNetwerk_DTO AddEigenNetwerk(EigenNetwerk_DTO newEigenNetwerk);
    }
}
