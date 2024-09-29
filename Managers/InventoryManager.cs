using ITHub.Models.Dto;
using ITHub.Models.Entity;
using ITHub.Services.Repositories;
using ITHub.Services.Interfaces;

namespace ITHub.Managers
{
    public class InventoryManager
    {
        private readonly IInventoryManagement _order;

        public InventoryManager(IInventoryManagement order)
        {
            _order = order;
        }

        public async Task<Response> CreateCategoryAsync(Category model)
        {
            return await _order.CreateCategoryAsync(model);
        }

        public async Task<Response> CreateProductAsync(ProductDto model)
        {
           return await _order.CreateProductAsync(model);
        }

        public Task<Response> DeleteCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteProductAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> FulfillOrderAsync(string OrderNumber, ShipmentDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetCategoryByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetProductByProductNumberAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetShipmentByOrderNumberAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateCategoryAsync(Category model, int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateProductAsync(ProductDto model, int Id)
        {
            throw new NotImplementedException();
        }

        Task<Response> CreateShippingPricing(ShipmentPricingConfigDto model)
        {
            throw new NotImplementedException();
        }

        Task<Response> DeleteShippingPricing(int Id)
        {
            throw new NotImplementedException();
        }

        Task<Response> UpdateShippingPricing(int Id, ShipmentPricingConfigDto model)
        {
            throw new NotImplementedException();
        }
    }
}