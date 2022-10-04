using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Testimonial
    {
        public decimal Id { get; set; }
        public string Text { get; set; }
        public DateTime? PostTime { get; set; }
        public decimal? UserId { get; set; }
        public bool? State { get; set; }

        public virtual User User { get; set; }
    }
}
