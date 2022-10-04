using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Supports = new HashSet<Support>();
            Visacards = new HashSet<Visacard>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? Phonenumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Support> Supports { get; set; }
        public virtual ICollection<Visacard> Visacards { get; set; }
    }
}
