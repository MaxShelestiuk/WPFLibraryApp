using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfLibrary.Models
{
    public class ReaderCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        private int id;
        [ForeignKey("Book")]
        private int idbook;
        private DateTime dateTaken;

        public int Id { get => id; set => id = value; }
        public int Idbook { get => idbook; set => idbook = value; }
        public DateTime DateTaken { get => dateTaken; set => dateTaken = value; }

        public virtual Reader Reader { get; set; }
    }
}
