using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsInfoStructAttr
    {
        public string InfoStructureId { get; set; }
        public string InfoStructureOvid { get; set; }
        public string InfoStructureName { get; set; }
        public string AttributeId { get; set; }
        public string AttributeOvid { get; set; }
        public string AttributeName { get; set; }
        public string EntityId { get; set; }
        public string EntityOvid { get; set; }
        public string EntityName { get; set; }
        public string DesignOvid { get; set; }
    }
}
