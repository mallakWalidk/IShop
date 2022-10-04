using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsLocation
    {
        public string LocationId { get; set; }
        public string LocationOvid { get; set; }
        public string LocationName { get; set; }
        public string BusinessInfoId { get; set; }
        public string BusinessInfoOvid { get; set; }
        public string BusinessInfoName { get; set; }
        public string LocAddress { get; set; }
        public string LocCity { get; set; }
        public string LocPostCode { get; set; }
        public string LocArea { get; set; }
        public string LocCountry { get; set; }
        public string LocType { get; set; }
        public string DesignOvid { get; set; }
    }
}
