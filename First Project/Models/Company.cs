using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Company
    {
        public Company()
        {
            Items = new HashSet<Item>();
        }

        public decimal ComId { get; set; }
        public string ComName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
