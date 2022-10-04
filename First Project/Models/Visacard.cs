using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Visacard
    {
        public decimal Id { get; set; }
        public decimal? Cardnumber { get; set; }
        public DateTime? Expdate { get; set; }
        public decimal? Customerid { get; set; }
    }
}
