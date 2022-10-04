using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class TDepartment
    {
        public TDepartment()
        {
            TEmployees = new HashSet<TEmployee>();
        }

        public decimal Deptid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<TEmployee> TEmployees { get; set; }
    }
}
