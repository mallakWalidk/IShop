using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class ContactU
    {
        public decimal Id { get; set; }
        public string Email { get; set; }
        public decimal? Phonenumber { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
    }
}
