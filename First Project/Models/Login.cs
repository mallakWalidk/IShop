using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Login
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? UserId { get; set; }
        public decimal? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
