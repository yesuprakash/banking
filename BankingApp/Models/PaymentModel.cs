using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class PaymentModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TransactionDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
    }
}
