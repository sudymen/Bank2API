using System;
using System.ComponentModel.DataAnnotations;

namespace BankApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public Account Account { get; set; }
    }
}
