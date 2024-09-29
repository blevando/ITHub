namespace ITHub.Models.Entity
{
    public class Feature
    {
        public int Id { get; set; }
        
        /// FK -> Product
        public string? ProductNumber { get; set; }

        public string? FeatureName { get; set; }
        public string? Icon { get; set; }

        public bool Status { get; set; }
       

    }
}
