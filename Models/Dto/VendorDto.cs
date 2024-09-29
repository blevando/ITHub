using ITHub.Models.Entity;

namespace ITHub.Models.Dto
{
    public class VendorDto
    {
        public string? VendorNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public VendorType? VendorType { get; set; }
    }
}
