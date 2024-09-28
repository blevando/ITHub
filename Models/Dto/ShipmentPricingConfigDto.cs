using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Dto
{
    public class ShipmentPricingConfigDto
    {
        public ShipmentType ShipmentType { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Status { get; set; }
    }
}
