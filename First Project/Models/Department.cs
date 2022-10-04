using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public decimal Depid { get; set; }
        public string Deptname { get; set; }
        public string Deplocation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
