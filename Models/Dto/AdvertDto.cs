namespace ITHub.Models.Dto
{
    public class AdvertDto
    {
        public string? OrderNumber { get; set; }
        public string? AdvertPlanNumber { get; set; }
        public int CustomerId { get; set; }
        public string? Image { get; set; }
        public string? ImageUrl { get; set; } // CloudFlair
        public string? AlternateText { get; set; }
        public string? CallToActionUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // remove or not
        public int TotalUnits { get; set; } //TotalUnit 
        public int SpentUnits { get; set; }//0
        public int BalanceUnits { get; set; }//= TotalUnit
        public int ImpressionCount { get; set; }//0
        public int ClickCount { get; set; }//0

    }
}
