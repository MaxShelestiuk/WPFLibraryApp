using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfLibrary.Models
{
    public class Chapter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        private int id;
        [ForeignKey("Book")]
        private int bookid;
        private int number;
        private string name;
        private int startPage;

        public int Id { get => id; set => id = value; }
        public int Bookid { get => bookid; set => bookid = value; }
        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public int StartPage { get => startPage; set => startPage = value; }
    }
}
