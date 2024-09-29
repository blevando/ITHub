using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Entity
{
    public class Invoice
    {
        public int Id { get; set; }  
        public string? InvoiceNumber { get; set; }
        public string? OrderNumber { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProdctSubTotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ShippmentSubtotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDiscount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }        
        public int Status { get; set; } // Paid or not paid


    }
}
