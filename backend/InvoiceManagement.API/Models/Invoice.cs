using System.ComponentModel.DataAnnotations;

namespace InvoiceManagement.API.Models
{
    public class Invoice
    {
        public int InvoiceID {get; set;}

        [Required]
        [MaxLength(50)]
        public string InvoiceNumber {get; set;} = string.Empty;
        
        [Required]
        public DateTime InvoiceDate {get; set;}

        [Required]
        public decimal GrossAmmount {get; set;}

        [MaxLength(500)]
        public string? Notes {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public ICollection<InvoicePayment> Payments {get; set;} = new List<InvoicePayment>();
        public ICollection<InvoiceDeduction> Deductions {get; set;} = new List<InvoiceDeduction>();
    }
}