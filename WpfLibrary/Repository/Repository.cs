using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfLibrary.Models;

namespace WpfLibrary.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public LibraryContext Context { get; set; }

        public Repository(LibraryContext context)
        {
            Context = context;
        }
      
        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(int id);

        public abstract TEntity Create(TEntity entity);

        public abstract void Update(TEntity entity);

        public abstract void Delete(TEntity entity);
    }
}
