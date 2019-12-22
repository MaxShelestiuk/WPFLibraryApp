using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfLibrary.Models;

namespace WpfLibrary.Repository
{
    public interface IReaderCardRepository
    {
        IEnumerable<ReaderCard> GetByReader(Reader reader);
        IEnumerable<ReaderCard> GetByBook(Book book);
    }
}
