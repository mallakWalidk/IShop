using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class OrderProduct
    {
        public decimal? OrderId { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public string State { get; set; }
        public decimal Id { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
