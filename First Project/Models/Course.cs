using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Course
    {
        public string Name { get; set; }
        public decimal Id { get; set; }
        public string Description { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
