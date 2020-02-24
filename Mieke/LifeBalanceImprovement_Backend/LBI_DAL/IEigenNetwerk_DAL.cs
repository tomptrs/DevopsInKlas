using LBI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL
{
    public interface IEigenNetwerk_DAL
    {
        List<EigenNetwerk> GetEigenNetwerk(int id);
        EigenNetwerk AddEigenNetwerk(EigenNetwerk newEigenNetwerk);
    }
}
