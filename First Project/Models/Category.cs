using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace First_Project.Models
{
    public partial class Category
    {
        public Category()
        {
            Stores = new HashSet<Store>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
