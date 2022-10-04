using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace First_Project.Models
{
    public partial class Store
    {
        public Store()
        {
            Products = new HashSet<Product>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal? CategoryId { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
