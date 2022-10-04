using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsContactResLocator
    {
        public string ContactId { get; set; }
        public string ContactOvid { get; set; }
        public string ContactName { get; set; }
        public string ResourceLocatorId { get; set; }
        public string ResourceLocatorOvid { get; set; }
        public string ResourceLocatorName { get; set; }
        public string DesignOvid { get; set; }
    }
}
