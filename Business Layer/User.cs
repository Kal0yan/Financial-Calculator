using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Business_Layer
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(40)]
        public string Password { get; set; }

        [Required]
        public float Balance { get; set; }

        public List<Transaction> Transactions { get; set; }

        private User() { }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Balance = 0;
        }
        public User(string username, string password, float balance)
        {
            this.Username = username;
            this.Password = password;
            this.Balance = balance;
        }
    }
}