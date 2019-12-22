using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfLibrary.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        private int id;
        private string name;
        private int year;
        private string ganre;
        private int pages;
        private bool status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Ganre { get => ganre; set => ganre = value; }
        public int Pages { get => pages; set => pages = value; }
        public bool Status { get => status; set => status = value; }

        public virtual Reader Reader { get; set; }
        public virtual List<Author> ListAuthors { get; set; }
        public virtual List<Chapter> ListChapters { get; set; }
    }
}

