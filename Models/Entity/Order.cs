namespace ITHub.Models.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; } // Unique string
        public  string? OrderDate { get; set; }
        public string? CustomerId { get; set; } // matric number
        public string? MerchantReference { get; set; }
        public string? PaymentGateway { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentReference { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string? Note { get; set; }

    }

    public enum OrderStatus
    {
        Whish=0,
        Paid=1,
        InTransit=2,
        Delivered=3,
        Suspended=5,
        Cancelled=7
    }
}
