using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MonthlyCreditLimit { get; set; }
        public ICollection<PaymentModel> Payments { get; set; }
    }
}
