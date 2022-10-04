using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsIndex
    {
        public string IndexName { get; set; }
        public string ObjectId { get; set; }
        public string Ovid { get; set; }
        public string ImportId { get; set; }
        public string ContainerId { get; set; }
        public string ContainerOvid { get; set; }
        public string State { get; set; }
        public string Functional { get; set; }
        public string Expression { get; set; }
        public string Engineer { get; set; }
        public string TableName { get; set; }
        public string SpatialIndex { get; set; }
        public string SpatialLayerType { get; set; }
        public string GeodeticIndex { get; set; }
        public decimal? NumberOfDimensions { get; set; }
        public string SchemaOvid { get; set; }
        public string SchemaName { get; set; }
        public string DesignOvid { get; set; }
    }
}
