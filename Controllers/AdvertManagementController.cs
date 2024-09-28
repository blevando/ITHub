using ITHub.Managers;
using ITHub.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHub.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AdvertManagementController : ControllerBase
    {
        private readonly AdvertManager _advert;

        public AdvertManagementController(AdvertManager advert)
        {
            _advert = advert;
        }
        [HttpPost]
        [Route("CreateAdvert")]
        public async Task<Response> CreateAdvertAsync(AdvertDto model)
        {
            
            return await _advert.CreateAdvertAsync(model);

        }

        //public Task<Response> DeleteAdvertAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetAdvertByCustomerIdAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetAdvertByIdAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetAllAdvertAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> ScheduleAdvertAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> SuspendAdvertAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> UpdateAdvertAsync(AdvertDto model)
        //{
        //    throw new NotImplementedException();
        //}

    }


}
