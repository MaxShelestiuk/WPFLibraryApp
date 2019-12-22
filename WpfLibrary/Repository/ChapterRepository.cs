using System;
using System.Collections.Generic;
using System.Linq;
using WpfLibrary.Models;
using System.Data.Entity;

namespace WpfLibrary.Repository
{
    public class ChapterRepository : Repository<Chapter>
    {

        public ChapterRepository(LibraryContext context) : base(context)
        {
        }

        public override IEnumerable<Chapter> GetAll()
        {
            return Context.Authors.OfType<Chapter>().ToList();
        }

        public override Chapter GetById(int id)
        {
            return Context.Chapters.Find(id) as Chapter;
        }

        public override Chapter Create(Chapter chapt)
        {

            Chapter chapter = Context.Chapters.Add(chapt) as Chapter;
            Context.SaveChanges();
            return chapter;
        }

        public override void Delete(Chapter chapt)
        {
            Context.Chapters.Remove(chapt);
            Context.SaveChanges();
        }

        public override void Update(Chapter chapt)
        {
            Context.Entry(chapt).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
