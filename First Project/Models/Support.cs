using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Support
    {
        public decimal Id { get; set; }
        public decimal? Customerid { get; set; }
        public string Message { get; set; }
    }
}
