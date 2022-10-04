using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDomain
    {
        public string DomainId { get; set; }
        public string DomainName { get; set; }
        public string Ovid { get; set; }
        public string Synonyms { get; set; }
        public string LogicalTypeId { get; set; }
        public string LogicalTypeOvid { get; set; }
        public decimal? TSize { get; set; }
        public decimal? TPrecision { get; set; }
        public decimal? TScale { get; set; }
        public string NativeType { get; set; }
        public string LtName { get; set; }
        public string DesignId { get; set; }
        public string DesignOvid { get; set; }
        public string DesignName { get; set; }
        public string DefaultValue { get; set; }
        public string UnitOfMeasure { get; set; }
        public string CharUnits { get; set; }
        public string SensitiveTypeOvid { get; set; }
        public string SensitiveDataDescr { get; set; }
    }
}
