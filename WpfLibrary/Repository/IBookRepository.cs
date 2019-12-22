using System;
using System.Collections.Generic;
using System.Linq;
using WpfLibrary.Models;

namespace WpfLibrary.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        // IEnumerable<Book> GetByAuthor(Author author);
        Book GetByName(string name);
        IEnumerable<Book> GetByGanre(string ganre);
    }
}
