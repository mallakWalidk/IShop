using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace First_Project.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? StoreId { get; set; }
        public decimal? CategoryId { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
