namespace ITHub.Models.Entity
{
    public class Vendor
    {
        public int Id { get; set; }

        public string? VendorNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public VendorType? VendorType { get; set; }

    }

    public enum VendorType
    {
        Individual = 1,
        Corporate= 2,
    }

}
