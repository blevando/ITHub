using ITHub.Models.Entity;

namespace ITHub.Models.Entity
{
   
    public class Advert
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; }
        public string? AdvertPlanNumber { get; set; }
        public int CustomerId { get; set; }
        public string? Image { get; set; }
        public string? ImageUrl { get; set; } //<img src='' > </img>
        public string? AlternateText { get; set; }
        public string? CallToActionUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // remove or not
        public int TotalUnits { get; set; } //30000
        public int SpentUnits { get; set; }//100---->>
        public int BalanceUnits { get; set; }//29900 <-----
        public int ImpressionCount { get; set; }//29900 <-----
        public int ClickCount { get; set; }//29900 <-----
         
    }
}


