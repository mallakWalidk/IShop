using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDomainValueRange
    {
        public string DomainId { get; set; }
        public string DomainOvid { get; set; }
        public decimal Sequence { get; set; }
        public string BeginValue { get; set; }
        public string EndValue { get; set; }
        public string ShortDescription { get; set; }
        public string DomainName { get; set; }
        public string DesignOvid { get; set; }
    }
}
