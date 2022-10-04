using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Deptemployee
    {
        public decimal Deptid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? Salary { get; set; }
    }
}
