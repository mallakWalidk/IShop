using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace First_Project.Models
{
    public partial class AboutU
    {
        public decimal Id { get; set; }
        public string FirstDescreption { get; set; }
        public string SecondDescreption { get; set; }
        public string ImgPath { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

    }
}
