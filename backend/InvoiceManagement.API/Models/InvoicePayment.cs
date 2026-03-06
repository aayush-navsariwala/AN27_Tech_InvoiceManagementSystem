using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagement.API.Models
{
    public class InvoicePayment
    {
        public int PaymentId {get; set;}

        [Required]
        public int InvoiceId {get; set;}

        [Required]
        [MaxLength(20)]
        public string PaymentMethod {get; set;} = string.Empty;

        [Required]
        public decimal Amount {get; set;}

        [Required]
        public DateTime PaidOn {get; set;}

        [MaxLength(100)]
        public string? Reference {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [ForeignKey(nameof(InvoiceId))]
        public Invoice? Invoice {get; set;}
    }
}