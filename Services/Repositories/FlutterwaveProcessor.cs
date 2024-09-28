using ITHub.Models.Dto;
using ITHub.Models.Entity;
using ITHub.Services.Interfaces;
namespace ITHub.Services.Repositories
{
    public class FlutterwaveProcessor : IPaymentManagement
    {
        public FlutterwaveProcessor()
        {
            
        }

        public async Task<Response> ProcessPaymentAsync(string processorType, PaymentRequestDto model, PaymentConfigDto config)
        {
            Response response = new Response();
            response.Message = $"{processorType}: Using Flutterwave";
            response.Code = 200;
            response.Data = processorType;

            return await Task.FromResult(response);

        }
    }
}
