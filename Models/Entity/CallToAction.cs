namespace ITHub.Models.Entity
{
    public class CallToAction
    {
        public int Id { get; set; }
        public int ActionNumber { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
// Status = 0:Cart, 1:Order Placed, 2:Shipped, 3:Out for Delivery, 4:Delivered,  8:Shop for Later (wish-list), 9:Cancelled