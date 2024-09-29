namespace ITHub.Models.Entity
{
    public class PaymentGatewayConfig
    {
        public int Id { get; set; }
        public string? PaymentGatewayId { get; set; }
        public string? Apikey { get; set; } // This will be used in the header as key
        public string? ApiSecret { get; set; } // This will be used in the header as value for the key above
        public string? GatewayUrl { get; set; } // The link to the payment processor being used
        public string? PaymentHookUrl { get; set; }// internal page to which payment processors returns stattus payload in case it could not be returned at realtime
        public string? ReturnUrl { get; set; } // Internal page to which the payment returns status after payment [Ref, Status, Method]
        public string? IntegrationKey { get; set; } // This is a known number to be provided by the payment processor
        public string? ReferencePrefix { get; set; } // All reference numbers will be generated using this value as a prefix
      
    }
}
