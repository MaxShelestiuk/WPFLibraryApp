using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WpfLibrary.Models;
using System.Data.Entity;

namespace WpfLibrary.Repository
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(LibraryContext context) : base(context)
        {
        }

        override public IEnumerable<Person> GetAll()
        {
            return Context.Persons.ToList();
        }

        public IEnumerable<Person> GetAll(Expression<Func<Person, bool>> predicate)
        {
            return Context.Persons.Where(predicate).ToList();
        }

        override public Person GetById(int id)
        {
            return Context.Persons.Find(id);
        }

        override public Person Create(Person pers)
        {
            Person person = Context.Persons.Add(pers);
            Context.SaveChanges();
            return person;
        }

        override public void Delete(Person pers)
        {
            Context.Persons.Remove(pers);
            Context.SaveChanges();
        }
    
        override public void Update(Person pers)
        {
            Context.Entry(pers).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
