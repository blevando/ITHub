namespace ITHub.Models.Dto
{
    public class PaymentConfigDto
    {
        public string PaymentGatewayId { get; set; }
        public string Apikey { get; set; }
        public string ApiSecret { get; set; }
        public string GatewayUrl { get; set; }
        public string PaymentHookUrl { get; set; }
        public string IntegrationKey { get; set; }
        public string ReferencePrefix { get; set; }

    }
}
