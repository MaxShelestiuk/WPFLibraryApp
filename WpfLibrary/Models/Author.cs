using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfLibrary.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        private int id;
        private string name;
        private string surname;
        private DateTime datebirth;
        private string nationality;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Datebirth { get => datebirth; set => datebirth = value; }
        public string Nationality { get => nationality; set => nationality = value; }

        public virtual List<Book> ListBooks { get; set; }
    }
}
