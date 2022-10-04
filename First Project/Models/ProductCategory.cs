using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
