using ITHub.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; } // Unique string
        public string? OrderDate { get; set; }
        public string? CustomerId { get; set; } // matric number

        /// <summary>
        /// Empty by default
        /// </summary>
        public string? MerchantReference { get; set; } //empty by default
        /// <summary>
        /// Empty by default
        /// </summary>
        public string? PaymentGateway { get; set; }
        /// <summary>
        /// Empty by default
        /// </summary>
        public string? PaymentMethod { get; set; }
        /// <summary>
        /// Empty by default
        /// </summary>
        public string? PaymentReference { get; set; }
        /// <summary>
        /// Zero when the order is yet to be paid for (i.e., Whish List)
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Takes the string 'Whish' when OrderStatus = 0 and order is not yet paid for)
        /// </summary>
        public string? Note { get; set; }




    }
}
