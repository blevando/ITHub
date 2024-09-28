using ITHub.Models.Dto;
using ITHub.Models.Entity;

namespace ITHub.Services.Interfaces
{
    public interface IInventoryManagement
    {
        // Category
        Task<Response> GetAllCategoryAsync();
        Task<Response> GetCategoryByIdAsync(int Id);
        Task<Response> CreateCategoryAsync(Category model);
        Task<Response> UpdateCategoryAsync(Category model, int Id);
        Task<Response> DeleteCategoryAsync(int Id);

        //Product
        Task<Response> GetAllProductAsync();
        Task<Response> GetProductByProductNumberAsync(int Id);
        Task<Response> CreateProductAsync(Commodity model);
        Task<Response> UpdateProductAsync(Commodity model, int Id);
        Task<Response> DeleteProductAsync(int Id);

        
        // Order Details Management
      
       
        Task<Response> FulfillOrderAsync(string OrderNumber,ShipmentDto model); // PUT  Order, Shipment, 

        Task<Response> GetShipmentByOrderNumberAsync(string OrderNumber); //  1x
                                                                          //  
                                                                          // Shipment

        Task<Response> CreateShippingPricing(ShipmentPricingConfigDto model);
        Task<Response> UpdateShippingPricing(int Id, ShipmentPricingConfigDto model);
        Task<Response> DeleteShippingPricing(int Id);


    }
}
