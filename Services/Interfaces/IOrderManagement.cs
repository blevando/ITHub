 
//using System.Runtime.InteropServices;
using ITHub.Models.Dto;
using ITHub.Models.Entity;

namespace ITHub.Services.Interfaces
{
    public interface IOrderManagement
    {
        // Order Management
        Task<Response> CreateOrderAsync(string CustomerId, OrderDto model); //  1
        Task<Response> UpdateOrderAsync(string OrderNumber, OrderDto model); //  1
        Task<Response> DeleteOrderAsync(string OrderNumber); //  1
        Task<Response> GetAllOrdersAsync(); //  1
        Task<Response> GetOrderByNumberAsync(string OrderNumber); //  1x
        Task<Response> GetOrdersByCustomerIdAsync(string CustomerId, OrderDto model); // Transaction History

        // Order Details Management
        Task<Response> AddOrderDetailAsync(string OrderNumber, OrderDetailDto model); //  1
        Task<Response> AddOrderDetailsAsync(string OrderNumber, List<OrderDetailDto> model); //  1

        Task<Response> UpdateOrderDetailAsync(string OrderNumber, OrderDetailDto model); //  1
        Task<Response> DeleteOrderDetailAsync(string OrderNumber, OrderDetailDto model); //  1
        Task<Response> GetAllOrderDetailsAsync(); //  1
        Task<Response> GetOrderDetailsByOrderNumberAsync(string OrderNumber); //  1x        

       
      // InvoiceManagement
        Task<Response> CreateInvoiceAsync(string OrderNumber); //  4 
        Task<Response> UpdateInvoiceWithPaymentStatusAsync(string OrderNumber, bool PaymentStatus); //  4
        Task<Response> DeleteInvoiceAsync(string OrderNumber, bool PaymentStatus); //  4
        Task<Response> GetInvoiceByOrderNumberAsync(string OrderNumber, bool PaymentStatus); //  4
        Task<Response> GetInvoiceByCustomerIdAsync(string OrderNumber, bool PaymentStatus); //  4


        //Consolidated : Order + OrderDetails + Invoice + Receipt 
        Task<Response> GetConsolidatedOrderAsync(string OrderNumber); //GetOrderByNumberAsync + nested GetOrderDetailsByOrderNumberAsync


        // Order Details Management
        Task<Response> AddShipmentAsync(string OrderNumber, ShipmentDto model); //  1
                 
        Task<Response> DeleteShipmentAsync(string OrderNumber); //  1
      
        // Task<Response> FulfillOrderAsync(string OrderNumber, ShipmentDto model); //  Order, Shipment, 
       
         
        Task<Response> GetShipmentByOrderNumberAsync(string OrderNumber); //  1x   

    }
}
