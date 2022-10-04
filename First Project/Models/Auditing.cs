using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Auditing
    {
        public decimal AuditId { get; set; }
        public string TableName { get; set; }
        public string TarnsactionName { get; set; }
        public DateTime? TarnsactionDate { get; set; }
    }
}
