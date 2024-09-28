using ITHub.Models.Dto;
using ITHub.Models.Entity;
using ITHub.Services.Repositories;
using ITHub.Services.Interfaces;
using System.Collections.Generic;

namespace ITHub.Managers
{
    public class OrderManager
    {
        private readonly IOrderManagement _order;
        public OrderManager(IOrderManagement order)
        {
            _order = order;
        }

        public Task<Response> AddOrderDetailAsync(string OrderNumber, OrderDetailDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> AddOrderDetailsAsync(string OrderNumber, List<OrderDetailDto> model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> AddShipmentAsync(string OrderNumber, ShipmentDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> CreateInvoiceAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> CreateOrderAsync(string CustomerId, OrderDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteInvoiceAsync(string OrderNumber, bool PaymentStatus)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteOrderAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteOrderDetailAsync(string OrderNumber, OrderDetailDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteShipmentAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> FulfillOrderAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAllOrderDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetAllOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetConsolidatedOrderAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetInvoiceByCustomerIdAsync(string OrderNumber, bool PaymentStatus)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetInvoiceByOrderNumberAsync(string OrderNumber, bool PaymentStatus)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetOrderByNumberAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetOrderDetailsByOrderNumberAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetOrdersByCustomerIdAsync(string CustomerId, OrderDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetShipmentByOrderNumberAsync(string OrderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateInvoiceWithPaymentStatusAsync(string OrderNumber, bool PaymentStatus)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateOrderAsync(string OrderNumber, OrderDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateOrderDetailAsync(string OrderNumber, OrderDetailDto model)
        {
            throw new NotImplementedException();
        }
    }
}