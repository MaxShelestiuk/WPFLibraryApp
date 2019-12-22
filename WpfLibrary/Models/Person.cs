using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfLibrary.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        private int id;
        private string name;
        private string surname;
        private int phone;
        [Required]
        private string login;
        [Required]
        private string password;
        [Required]
        public bool IsAdmin { get; set; }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
