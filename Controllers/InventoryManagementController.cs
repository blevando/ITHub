using ITHub.Managers;
using ITHub.Models.Dto;
using ITHub.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryManagementController : ControllerBase
    {

        private readonly InventoryManager _inventory;

        public InventoryManagementController(InventoryManager inventory)
        {
            _inventory = inventory;
        }

        [HttpPost]
        [Route("CreateCategory")]
        public async Task<Response> CreateCategoryAsync(Category model)
        {
            return await _inventory.CreateCategoryAsync(model);
        }
        [HttpPost]
        [Route("CreateProduct")]
        public Task<Response> CreateProductAsync(ProductDto model)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public Task<Response> DeleteCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        //public Task<Response> DeleteProductAsync(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> FulfillOrderAsync(string OrderNumber, ShipmentDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetAllCategoryAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetAllProductAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetCategoryByIdAsync(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetProductByProductNumberAsync(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> GetShipmentByOrderNumberAsync(string OrderNumber)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> UpdateCategoryAsync(Category model, int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Response> UpdateProductAsync(Commodity model, int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Response> CreateShippingPricing(ShipmentPricingConfigDto model)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Response> DeleteShippingPricing(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Response> UpdateShippingPricing(int Id, ShipmentPricingConfigDto model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
