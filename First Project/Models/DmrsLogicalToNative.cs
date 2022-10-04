using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsLogicalToNative
    {
        public string DesignId { get; set; }
        public string DesignOvid { get; set; }
        public string DesignName { get; set; }
        public string LogicalTypeId { get; set; }
        public string LogicalTypeOvid { get; set; }
        public string LtName { get; set; }
        public string NativeType { get; set; }
        public string RdbmsType { get; set; }
        public string RdbmsVersion { get; set; }
        public string HasSize { get; set; }
        public string HasPrecision { get; set; }
        public string HasScale { get; set; }
    }
}
