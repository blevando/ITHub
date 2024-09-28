﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Dto
{
    public class OrderDetailDto
    {
        public string? OrderNumber { get; set; } // Order FK
        public string? ProductName { get; set; } // Commodity FK
        public string? ProductNumber { get; set; }

        public int Qty { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }


    }
}