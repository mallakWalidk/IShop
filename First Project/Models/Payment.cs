using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Payment
    {
        public decimal Id { get; set; }
        public decimal? Amount { get; set; }
        public decimal? SerialNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? Allowed { get; set; }
        public decimal? OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
