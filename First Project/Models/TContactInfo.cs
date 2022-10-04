using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class TContactInfo
    {
        public decimal Contactid { get; set; }
        public decimal? Employeeid { get; set; }
        public string Email { get; set; }
        public decimal? Phonenumber { get; set; }

        public virtual TEmployee Employee { get; set; }
    }
}
