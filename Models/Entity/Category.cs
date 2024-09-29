namespace ITHub.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CategoryType? CategoryType { get; set; }
    }

    public enum CategoryType
    {
        Product = 1,
        Advert=2,
        Others=3
    }
}
