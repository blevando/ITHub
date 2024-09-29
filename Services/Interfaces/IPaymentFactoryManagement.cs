
using ITHub.Models.Dto;
using ITHub.Models.Entity;
namespace ITHub.Services.Interfaces
{
    public interface IPaymentFactoryManagement
    {

        Task<Response> InitiatePaymentAsync(string processorType, PaymentRequestDto model);
        Task<Response> RequeryPaymentAsync(string paymentReference);
        
    }
}
