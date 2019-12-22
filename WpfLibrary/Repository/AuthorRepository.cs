using System;
using System.Collections.Generic;
using System.Linq;
using WpfLibrary.Models;
using System.Data.Entity;

namespace WpfLibrary.Repository
{
    public class AuthorRepository : Repository<Author>
    {
        public AuthorRepository(LibraryContext context) : base(context)
        {
        }

        public override IEnumerable<Author> GetAll()
        {
            return Context.Authors.OfType<Author>().ToList();
        }

        public override Author GetById(int id)
        {
            return Context.Authors.Find(id) as Author;
        }

        public override Author Create(Author auth)
        {

            Author author = Context.Authors.Add(auth) as Author;
            Context.SaveChanges();
            return author;
        }

        public override void Delete(Author author)
        {
            Context.Authors.Remove(author);
            Context.SaveChanges();
        }

        public override void Update(Author author)
        {
            Context.Entry(author).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
