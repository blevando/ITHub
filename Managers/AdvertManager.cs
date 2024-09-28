using ITHub.Models.Dto;
using ITHub.Services.Interfaces;

namespace ITHub.Managers
{
    public class AdvertManager
    {
        private readonly IAdvertManagement _advertclient;

        public AdvertManager( IAdvertManagement advertclient)
        {
            _advertclient = advertclient;
        }
        public async Task<Response> CreateAdvertAsync(AdvertDto model)
        {
          return await  _advertclient.CreateAdvertAsync(model);

             
        }

        public Task<Response> DeleteAdvertAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAdvertByCustomerIdAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAdvertByIdAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAllAdvertAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> ScheduleAdvertAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> SuspendAdvertAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAdvertAsync(AdvertDto model)
        {
            throw new NotImplementedException();
        }

    }
}
