using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsEmail
    {
        public string EmailId { get; set; }
        public string EmailOvid { get; set; }
        public string EmailName { get; set; }
        public string BusinessInfoId { get; set; }
        public string BusinessInfoOvid { get; set; }
        public string BusinessInfoName { get; set; }
        public string EmailAddress { get; set; }
        public string EmailType { get; set; }
        public string DesignOvid { get; set; }
    }
}
