using ITHub.Data;
using ITHub.Models.Dto;
using ITHub.Services.Repositories;
using ITHub.Services.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace ITHub.Services.Repositories
{
    public class PaymentFactoryManagement : IPaymentFactoryManagement
    {
        private readonly ApplicationDbContext _context;
        public PaymentFactoryManagement(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<Response> InitiatePaymentAsync(string processorType, PaymentRequestDto model)
        {

            Response response = new Response();
            var paymentConfig = await _context.PaymentGatewayConfig.FirstOrDefaultAsync(p => p.PaymentGatewayId == processorType);

            if (paymentConfig != null)
            {
                PaymentConfigDto config = new PaymentConfigDto();
                config.Apikey = paymentConfig.Apikey;
                config.ApiSecret = paymentConfig.ApiSecret;
                config.GatewayUrl = paymentConfig.GatewayUrl;


                model.MerchantRef = paymentConfig.ReferencePrefix + model.ProductCode; // To be changed to orderNumber
                model.ReturnUrl = paymentConfig.ReturnUrl;
                model.WebhookUrl = paymentConfig.PaymentHookUrl;
                model.IntegrationKey = paymentConfig.IntegrationKey;
                
                // Config

                IPaymentManagement payment = PaymentFactory.GetPaymentProcessor(processorType);

                var resp = await payment.ProcessPaymentAsync(processorType, model, config);

                response.Code = 200;
                response.Message = "successful";
                response.Data = resp;
            }
            else
            {
                response.Code = 200;
                response.Message = "successful";
                response.Data = null;
            }

            return await Task.FromResult(response);
        }

        public Task<Response> RequeryPaymentAsync(string paymentReference)
        {
            throw new NotImplementedException();
        }
    }
}
