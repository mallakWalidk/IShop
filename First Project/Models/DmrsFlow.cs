using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsFlow
    {
        public string FlowId { get; set; }
        public string FlowOvid { get; set; }
        public string FlowName { get; set; }
        public string DiagramId { get; set; }
        public string DiagramOvid { get; set; }
        public string DiagramName { get; set; }
        public string EventId { get; set; }
        public string EventOvid { get; set; }
        public string EventName { get; set; }
        public string SourceId { get; set; }
        public string SourceOvid { get; set; }
        public string SourceName { get; set; }
        public string DestinationId { get; set; }
        public string DestinationOvid { get; set; }
        public string DestinationName { get; set; }
        public string ParentId { get; set; }
        public string ParentOvid { get; set; }
        public string ParentName { get; set; }
        public string SourceType { get; set; }
        public string DestinationType { get; set; }
        public string SystemObjective { get; set; }
        public string Logging { get; set; }
        public string OpCreate { get; set; }
        public string OpRead { get; set; }
        public string OpUpdate { get; set; }
        public string OpDelete { get; set; }
        public string CrudCode { get; set; }
        public string DesignOvid { get; set; }
    }
}
