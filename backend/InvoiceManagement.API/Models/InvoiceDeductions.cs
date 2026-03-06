using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagement.API.Models
{
    public class InvoiceDeduction
    {
        public int DeductionId { get; set;}

        [Required]
        public int InvoiceId { get; set;}

        [Required]
        public DateTime DeductionDate { get; set;}

        [Required]
        public decimal Amount { get; set;}

        [Required]
        [MaxLength(255)]
        public string Description { get; set;} = string.Empty;

        public DateTime CreatedAt { get; set;} = DateTime.Now;

        [ForeignKey(nameof(InvoiceId))]
        public Invoice? Invoice { get; set;}
    }
}