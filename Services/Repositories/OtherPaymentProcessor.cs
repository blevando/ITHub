using ITHub.Models.Dto;
using ITHub.Services.Interfaces;
 
 
namespace ITHub.Services.Repositories
{
    public class OtherPaymentProcessor : IPaymentManagement
    {

        public OtherPaymentProcessor()
        {
            
        }
        public async Task<Response> ProcessPaymentAsync(string processorType, PaymentRequestDto model, PaymentConfigDto config)
        {
            Response response = new Response();
            response.Message = $"{processorType}: Using OtherPayment";
            response.Code = 200;
            response.Data = processorType;

            return await Task.FromResult(response);

        }
    }
}
