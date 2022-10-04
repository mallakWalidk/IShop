using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace First_Project.Models
{
    public partial class Admin
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

    }
}
