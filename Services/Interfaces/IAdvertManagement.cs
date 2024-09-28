using ITHub.Models.Dto;

namespace ITHub.Services.Interfaces
{
    public interface IAdvertManagement
    {
        Task<Response> CreateAdvertAsync(AdvertDto model);
        Task<Response> UpdateAdvertAsync(AdvertDto model);
        Task<Response> DeleteAdvertAsync(AdvertDto model);
        Task<Response> SuspendAdvertAsync(AdvertDto model);
        Task<Response> ScheduleAdvertAsync(AdvertDto model);
        Task<Response> GetAllAdvertAsync(AdvertDto model);
        Task<Response> GetAdvertByIdAsync(AdvertDto model);
        Task<Response> GetAdvertByCustomerIdAsync(AdvertDto model);
    }
}
