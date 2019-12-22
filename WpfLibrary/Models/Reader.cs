using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary.Models
{
    public class Reader:Person
    {
        public virtual List<Book> Listbooks { get; set; }
        public virtual List<ReaderCard> ListReaderCards { get; set; }
    }
}
