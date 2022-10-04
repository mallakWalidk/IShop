using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDomainCheckConstraint
    {
        public string DomainId { get; set; }
        public string DomainOvid { get; set; }
        public decimal Sequence { get; set; }
        public string Text { get; set; }
        public string DatabaseType { get; set; }
        public string DomainName { get; set; }
        public string DesignOvid { get; set; }
    }
}
