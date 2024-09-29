using ITHub.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Entity
{
    // [PrimaryKey(nameof(State), nameof(LicensePlate))]
    public class AdvertPlan
    {
        public int Id { get; set; }
        public string? AdvertPlanNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public AdvertPositon AdvertPositon { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerClick { get; set; } //10

        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerImpression { get; set; } //2

        public int Duration { get; set; } // in days

        public bool Status { get; set; }
    }

    public enum AdvertPositon
        {        
        TopBanner=1,
        LeftBar=3,
        RightBar=5,
        UnderCheckoutPage=7
    }
}

