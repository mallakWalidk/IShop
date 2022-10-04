using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class RProductCustomer
    {
        public decimal Id { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public virtual RCustomer Customer { get; set; }
        public virtual RProduct Product { get; set; }
    }
}
