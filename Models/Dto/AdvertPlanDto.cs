using ITHub.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Dto
{
    public class AdvertPlanDto
    {
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
}
