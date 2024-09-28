﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ITHub.Models.Dto
{
    public class DocumentDto
    { 
            public string? Item { get; set; }

            
            [Column(TypeName = "decimal(18,4)")]
            public decimal Price { get; set; }

            public string? Address { get; set; }

        
    }
}