using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
            Payments = new HashSet<Payment>();
        }

        public decimal Id { get; set; }
        public decimal? UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? Amount { get; set; }
        public string State { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
