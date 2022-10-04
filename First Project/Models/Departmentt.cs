using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Departmentt
    {
        public Departmentt()
        {
            Employeets = new HashSet<Employeet>();
        }

        public decimal Deptid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Employeet> Employeets { get; set; }
    }
}
