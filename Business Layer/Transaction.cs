using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Business_Layer
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Category { get; set; }

        [Required]
        public float Amount { get; set; }


        public string? Description { get; set; }

        [Required]
        public bool IncomeOrOutcome { get; set; }



        private Transaction() { }
        public Transaction(string category, float amount)
        {
            this.Category = category;
            this.Amount = amount;

        }
        public Transaction(string category, float amount, string description)
        {
            this.Category = category;
            this.Amount = amount;
            this.Description = description;

            if (amount > 0) IncomeOrOutcome = true;
            else IncomeOrOutcome = false;
        }
        public Transaction(string category, float amount, bool incomeOrOutcome)
        {
            this.Category = category;
            this.Amount = amount;
            this.IncomeOrOutcome = incomeOrOutcome;
        }
    }
}
