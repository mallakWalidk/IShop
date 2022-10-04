using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class TAddress
    {
        public decimal Addressid { get; set; }
        public decimal? Employeeid { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public decimal? Zipcode { get; set; }

        public virtual TEmployee Employee { get; set; }
    }
}
