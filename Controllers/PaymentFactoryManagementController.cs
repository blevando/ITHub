using ITHub.Managers;
using ITHub.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentFactoryManagementController : ControllerBase
    {
        private readonly PaymentFactoryManager _payment;

        public PaymentFactoryManagementController(PaymentFactoryManager payment)
        {
            _payment = payment;
        }

        [HttpPost]
        [Route("InitiatePayment")]
       public async Task<Response> InitiatePaymentAsync(string processorType, PaymentRequestDto model)
        {
           return await _payment.InitiatePaymentAsync(processorType, model);
        }
    }
}
