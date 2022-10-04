using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class TEmployee
    {
        public decimal Empid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Depid { get; set; }

        public virtual TDepartment Dep { get; set; }
        public virtual TAddress TAddress { get; set; }
        public virtual TContactInfo TContactInfo { get; set; }
    }
}
