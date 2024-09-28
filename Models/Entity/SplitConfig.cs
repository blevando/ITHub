namespace ITHub.Models.Entity
{
    public class SplitConfig
    {
        public int Id { get; set; }
        public string? WalletCode { get; set; }
        public int Amount { get; set; }
        public bool ShouldDeductFrom { get; set; }
    }
}
