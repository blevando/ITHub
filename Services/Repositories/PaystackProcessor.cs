using ITHub.Models.Dto;
using ITHub.Services.Interfaces;

namespace ITHub.Services.Repositories
{
    public class PaystackProcessor : IPaymentManagement
    {
        public async Task<Response> ProcessPaymentAsync(string processorType, PaymentRequestDto model, PaymentConfigDto config)
        {

            Response response = new Response();
            response.Message = $"{processorType}: Using PaystackPayment";
            response.Code = 200;
            response.Data = processorType;

            return await Task.FromResult(response);
        }
    }
}
