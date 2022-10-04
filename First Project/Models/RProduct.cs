using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class RProduct
    {
        public RProduct()
        {
            RProductCustomers = new HashSet<RProductCustomer>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? Sale { get; set; }
        public decimal? Price { get; set; }
        public decimal? CategoryId { get; set; }

        public virtual ICollection<RProductCustomer> RProductCustomers { get; set; }
    }
}
