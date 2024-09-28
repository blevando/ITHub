namespace ITHub.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } 
        public Category? Category { get; set; }
        public string? ProductNumber { get; set; } // QRCode/Barcode-EAN13
        public string? ProductName { get; set; }        
        public string? Overview { get; set; }
        public string? Warranty { get; set; }
        public string? FeatureSummary { get; set; }
        public List<Feature>? Features { get; set; }

        public string? BenefitSummary { get; set; }
        public List<Benefit>? Benefits { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public List<ActionType>? ActionTypes { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Vendor { get; set; } // Come back to modify
         
    }
}
