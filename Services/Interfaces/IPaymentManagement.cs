using ITHub.Models.Dto;
using ITHub.Models.Entity;

namespace ITHub.Services.Interfaces
{
    public interface IPaymentManagement
    {               
        Task<Response> ProcessPaymentAsync(string processorType, PaymentRequestDto model, PaymentGatewayConfigDto config);

       
    }
}