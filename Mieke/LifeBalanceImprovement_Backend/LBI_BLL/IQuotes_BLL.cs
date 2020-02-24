using System;
using System.Collections.Generic;
using System.Text;
using LBI_DTO;

namespace LBI_BLL
{
    public interface IQuotes_BLL
    {
        List<Quotes_DTO> GetQuotes();
        Quotes_DTO RandomQuotes();
    }
}
