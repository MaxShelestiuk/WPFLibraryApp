using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using WpfLibrary.Models;

namespace WpfLibrary.Repository
{
    public class ReaderCardRepository : Repository<ReaderCard>,IReaderCardRepository
    {
        public ReaderCardRepository(LibraryContext context) : base(context)
        {
        }

        public override IEnumerable<ReaderCard> GetAll()
        {
            return Context.ReaderCards.ToList();
        }

        public IEnumerable<ReaderCard> GetAll(Expression<Func<ReaderCard, bool>> predicate)
        {
            return Context.ReaderCards.Where(predicate).ToList();
        }

        public override ReaderCard GetById(int id)
        {
            return Context.ReaderCards.Find(id);
        }

        public override ReaderCard Create(ReaderCard card)
        {
            ReaderCard readercard = Context.ReaderCards.Add(card);
            Context.SaveChanges();
            return readercard;
        }

        public override void Delete(ReaderCard card)
        {
            Context.ReaderCards.Remove(card);
            Context.SaveChanges();
        }

        public override void Update(ReaderCard entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public IEnumerable<ReaderCard> GetByBook(Book book)
        {
            var query = from rc in Context.ReaderCards
                        where rc.Idbook == book.Id
                        select rc;
            return query.ToList();
        }

        public IEnumerable<ReaderCard> GetByReader(Reader reader)
        {
            var query = from rc in Context.ReaderCards
                        where rc.Reader.Id == reader.Id
                        select rc;
            return query.ToList();
        }
    }
}
