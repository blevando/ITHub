using ITHub.Services.Interfaces;
using ITHub.Services.Repositories;

namespace ITHub.Services.Repositories
{
    public static class PaymentFactory
    {
        public static IPaymentManagement GetPaymentProcessor(string processorType)
        {
            IPaymentManagement processor = null;
           

            switch(processorType.ToLower())
            {
                case "cyberpay":
                    processor = new CyberPayProcessor();
                    break;
                case "flutterwave":
                    processor = new FlutterwaveProcessor();
                    break;

                case "paystack":
                    processor = new PaystackProcessor();
                    break;
                    
                default:
                    processor = new OtherPaymentProcessor();
                    break;

            }

            return processor;
        }
    }
}
