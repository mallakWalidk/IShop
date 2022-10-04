using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsInfoStructure
    {
        public string InfoStructureId { get; set; }
        public string InfoStructureOvid { get; set; }
        public string InfoStructureName { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string GrowthRateUnit { get; set; }
        public int? GrowthRatePercent { get; set; }
        public int? Volume { get; set; }
        public string DesignOvid { get; set; }
    }
}
