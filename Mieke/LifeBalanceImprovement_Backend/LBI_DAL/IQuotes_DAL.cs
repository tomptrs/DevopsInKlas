using LBI_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBI_DAL
{
    public interface IQuotes_DAL
    {
        List<Quotes> GetQoutes();
        Quotes RandomQuotes();
    }
}
