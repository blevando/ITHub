using ITHub.Models.Entity;
namespace ITHub.Models.Dto
{
    public class ConsolidatedOrderDto
    {
        public string? OrderNumber { get; set; } // Unique string
        public string OrderDate { get; set; }
        public string CustomerId { get; set; } // matric number        
        public string? PaymentGateway { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentReference { get; set; }

        public DocumentDto DocumentDto { get; set; }

         public List<OrderDetailDto> Details { get; set; }     
        public List<ShipmentDto> ShipmentDto { get; set; }

        public InvoiceDto InvoiceDto { get; set; }

    }
}
