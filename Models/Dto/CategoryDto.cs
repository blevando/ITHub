using ITHub.Models.Entity;

namespace ITHub.Models.Dto
{
    public class CategoryDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CategoryType? CategoryType { get; set; }

    }
}
