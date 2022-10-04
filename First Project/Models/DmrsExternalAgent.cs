using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsExternalAgent
    {
        public string ExternalAgentId { get; set; }
        public string ExternalAgentOvid { get; set; }
        public string ExternalAgentName { get; set; }
        public string DiagramId { get; set; }
        public string DiagramOvid { get; set; }
        public string DiagramName { get; set; }
        public string ExternalAgentType { get; set; }
        public string FileLocation { get; set; }
        public string FileSource { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileOwner { get; set; }
        public string DataCaptureType { get; set; }
        public string FieldSeparator { get; set; }
        public string TextDelimiter { get; set; }
        public int? SkipRecords { get; set; }
        public string SelfDescribing { get; set; }
        public string DesignOvid { get; set; }
    }
}
