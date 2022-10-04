using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Exam
    {
        public string Name { get; set; }
        public decimal Id { get; set; }
        public DateTime? Duration { get; set; }
        public DateTime? Starttime { get; set; }
        public decimal? Courseid { get; set; }
    }
}
