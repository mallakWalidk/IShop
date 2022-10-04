using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Employeet
    {
        public decimal Empid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Phonenumber { get; set; }
        public string Address { get; set; }
        public decimal? Depid { get; set; }

        public virtual Departmentt Dep { get; set; }
    }
}
