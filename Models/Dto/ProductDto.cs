using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
 

namespace ITHub.Models.Dto
{
    public class ProductDto
    {       
        public string? ProductName { get; set; }
        public string? ProductNumber { get; set; }         

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
 

    }
}
