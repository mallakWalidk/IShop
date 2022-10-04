using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDistinctType
    {
        public string DesignId { get; set; }
        public string DesignOvid { get; set; }
        public string DesignName { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string DistinctTypeId { get; set; }
        public string DistinctTypeOvid { get; set; }
        public string DistinctTypeName { get; set; }
        public string LogicalTypeId { get; set; }
        public string LogicalTypeOvid { get; set; }
        public string LogicalTypeName { get; set; }
        public string TSize { get; set; }
        public decimal? TPrecision { get; set; }
        public decimal? TScale { get; set; }
    }
}
