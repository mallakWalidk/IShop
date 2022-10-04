using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace First_Project.Models
{
    public partial class Home
    {
        public decimal Id { get; set; }
        public string FirstDescreption { get; set; }
        public string SecondDescreption { get; set; }
        public string FirstImgPath { get; set; }
        public string SecondImgPath { get; set; }

        [NotMapped]
        public virtual IFormFile FirstImgFile { get; set; }
        [NotMapped]
        public virtual IFormFile SecondImgFile { get; set; }

    }
}
