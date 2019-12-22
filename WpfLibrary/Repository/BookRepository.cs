using System;
using System.Collections.Generic;
using System.Linq;
using WpfLibrary.Models;
using System.Data.Entity;
using System.Linq.Expressions;

namespace WpfLibrary.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public override IEnumerable<Book> GetAll()
        {
            return Context.Books.ToList();
        }
        public List<Book> GetAll(Expression<Func<Book, bool>> predicate)
        {
            return Context.Books.Where(predicate).ToList();
        }

        public override Book GetById(int id)
        {
            return Context.Books.Find(id);
        }

        public override Book Create(Book entity)
        {
            Book book = Context.Books.Add(entity);
            Context.SaveChanges();
            return book;
        }

        public override void Delete(Book entity)
        {
            Context.Books.Remove(entity);
            Context.SaveChanges();
        }

        public override void Update(Book entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public IEnumerable<Book> GetByGanre(string ganre)
        {
            var query = from b in Context.Books
                        where b.Ganre == ganre
                        select b;
            return query.ToList();
        }

        public Book GetByName(string name)
        {
            var query = from b in Context.Books
                        where b.Name == name
                        select b;
            return query.FirstOrDefault();
        }    
    }
}
