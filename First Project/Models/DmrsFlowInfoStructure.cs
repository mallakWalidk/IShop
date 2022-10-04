using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsFlowInfoStructure
    {
        public string FlowId { get; set; }
        public string FlowOvid { get; set; }
        public string FlowName { get; set; }
        public string InfoStructureId { get; set; }
        public string InfoStructureOvid { get; set; }
        public string InfoStructureName { get; set; }
        public string DesignOvid { get; set; }
    }
}
