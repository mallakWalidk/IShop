﻿using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class TAuditing
    {
        public decimal AuditId { get; set; }
        public string TableName { get; set; }
        public string TarnsactionName { get; set; }
        public string ByUser { get; set; }
        public DateTime? TarnsactionDate { get; set; }
    }
}
