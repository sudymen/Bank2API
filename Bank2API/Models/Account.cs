using System.ComponentModel.DataAnnotations;

namespace BankApi.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [Required]
        public decimal Balance { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountType { get; set; }

        public Customer Customer { get; set; }
    }
}

