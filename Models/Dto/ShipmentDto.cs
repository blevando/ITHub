﻿using ITHub.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Dto
{
    public class ShipmentDto
    {

        public string? OrderNumber { get; set; } //FK
        public ShipmentType ShipmentType { get; set; } // Email, Phone, Location = prices in ShipmentConfig Table

        public string? Destination { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public string? FulfilledBy { get; set; }
        public string? ShippedDate { get; set; }

        public string? DeliveryDate { get; set; }
        public string? POD { get; set; } // Proof of Delivery
        public string? ReceivedBy { get; set; }

        public ShipmentStatus ShipmentStatus { get; set; }

        public string? Remark { get; set; }

    }

    public enum ShipmentType
    {
        ByEmail = 1,
        ByPhone = 2,
        ByLocation = 3,

    }

    public enum ShipmentStatus
    {
        NotYetShipped = 1,
        Shipped = 2,
        OutForDelivery = 3,
        Delivered = 5


    }
}
