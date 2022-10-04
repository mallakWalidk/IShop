using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDesign
    {
        public string DesignId { get; set; }
        public string DesignOvid { get; set; }
        public string DesignName { get; set; }
        public DateTime? DatePublished { get; set; }
        public string PublishedBy { get; set; }
        public decimal PersistenceVersion { get; set; }
        public string VersionComments { get; set; }
    }
}
