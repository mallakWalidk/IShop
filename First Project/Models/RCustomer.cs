using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class RCustomer
    {
        public RCustomer()
        {
            RProductCustomers = new HashSet<RProductCustomer>();
        }

        public decimal Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<RProductCustomer> RProductCustomers { get; set; }
    }
}
