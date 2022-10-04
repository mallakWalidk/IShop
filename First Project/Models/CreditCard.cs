using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class CreditCard
    {
        public decimal Id { get; set; }
        public string SerialNumber { get; set; }
        public decimal? Balance { get; set; }
        public decimal? ExpMonth { get; set; }
        public decimal? ExpYear { get; set; }
        public decimal? Cvv { get; set; }
        public string CustomerName { get; set; }
    }
}
