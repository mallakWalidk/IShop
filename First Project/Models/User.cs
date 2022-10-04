using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

#nullable disable

namespace First_Project.Models
{
    public partial class User
    {
        public User()
        {
            Logins = new HashSet<Login>();
            Orders = new HashSet<Order>();
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime? Birthdate { get; set; }
        public string ImagePath { get; set; }
        public decimal? PhoneNumber { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
