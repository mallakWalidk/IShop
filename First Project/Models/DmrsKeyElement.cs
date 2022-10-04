using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsKeyElement
    {
        public string KeyId { get; set; }
        public string KeyOvid { get; set; }
        public string Type { get; set; }
        public string ElementId { get; set; }
        public string ElementOvid { get; set; }
        public string ElementName { get; set; }
        public decimal? Sequence { get; set; }
        public string SourceLabel { get; set; }
        public string TargetLabel { get; set; }
        public string EntityId { get; set; }
        public string KeyName { get; set; }
        public string EntityOvid { get; set; }
        public string EntityName { get; set; }
        public string DesignOvid { get; set; }
    }
}
