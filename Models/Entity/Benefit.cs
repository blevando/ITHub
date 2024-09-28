namespace ITHub.Models.Entity
{
    
    public class Benefit
    {
        public int Id { get; set; }

        /// FK -> Product
        public string ProductNumber { get; set; }

        public string BenefitName { get; set; }
        public string Icon { get; set; }

        public bool Status { get; set; }


    }

}
