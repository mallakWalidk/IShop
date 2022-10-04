using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsContact
    {
        public string ContactId { get; set; }
        public string ContactOvid { get; set; }
        public string ContactName { get; set; }
        public string BusinessInfoId { get; set; }
        public string BusinessInfoOvid { get; set; }
        public string BusinessInfoName { get; set; }
        public string DesignOvid { get; set; }
    }
}
