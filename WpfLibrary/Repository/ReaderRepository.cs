using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WpfLibrary.Models;
using System.Data.Entity;

namespace WpfLibrary.Repository
{
    public class ReaderRepository : Repository<Reader>
    {
        public ReaderRepository(LibraryContext context) : base(context)
        {
        }

        public override IEnumerable<Reader> GetAll()
        {
            return Context.Persons.OfType<Reader>().ToList();
        }

        public override Reader GetById(int id)
        {
            return Context.Persons.Find(id) as Reader;
        }

        public override Reader Create(Reader readerEntity)
        {
            Reader reader = Context.Persons.Add(readerEntity) as Reader;
            Context.SaveChanges();
            return reader;
        }

        public override void Delete(Reader reader)
        {
            Context.Persons.Remove(reader);
            Context.SaveChanges();
        }

        public override void Update(Reader reader)
        {
            Context.Entry(reader).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
