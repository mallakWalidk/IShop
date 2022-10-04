using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Employee
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal? Departmentid { get; set; }
        public decimal? Salary { get; set; }
    }
}
