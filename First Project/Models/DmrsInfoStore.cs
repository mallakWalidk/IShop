using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsInfoStore
    {
        public string InfoStoreId { get; set; }
        public string InfoStoreOvid { get; set; }
        public string InfoStoreName { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string InfoStoreType { get; set; }
        public string ObjectType { get; set; }
        public string ImplementationName { get; set; }
        public string Location { get; set; }
        public string Source { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Owner { get; set; }
        public string RdbmsSite { get; set; }
        public string Scope { get; set; }
        public string TransferType { get; set; }
        public string FieldSeparator { get; set; }
        public string TextDelimiter { get; set; }
        public int? SkipRecords { get; set; }
        public string SelfDescribing { get; set; }
        public string SystemObjective { get; set; }
        public string DesignOvid { get; set; }
    }
}
