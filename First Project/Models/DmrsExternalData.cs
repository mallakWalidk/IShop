using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsExternalData
    {
        public string ExternalDataId { get; set; }
        public string ExternalDataOvid { get; set; }
        public string ExternalDataName { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string LogicalTypeId { get; set; }
        public string LogicalTypeOvid { get; set; }
        public string LogicalTypeName { get; set; }
        public string RecordStructureTypeId { get; set; }
        public string RecordStructureTypeOvid { get; set; }
        public string RecordStructureTypeName { get; set; }
        public int? StartingPos { get; set; }
        public string Description { get; set; }
        public string DesignOvid { get; set; }
    }
}
