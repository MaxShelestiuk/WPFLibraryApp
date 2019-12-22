using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfLibrary.Models
{
    public class LibraryContext :DbContext
    {
        public LibraryContext() : base("Library")
        {
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<ReaderCard> ReaderCards { get; set; }
    }
}
