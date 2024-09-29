using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Entity
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; } // Order FK
        public string? ProductName { get; set; } // Commodity FK
        public string? ProductNumber { get; set; }
        public int Qty { get; set; }       

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; } 
        public bool Status { get; set; }       

         

    }

 
}
