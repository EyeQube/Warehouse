using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The price can't be less than zero")]
        public int Price { get; set; }

        public string Category { get; set; }

        public int Count { get; set; }

        public string Description { get; set; }

    }
}