using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsExtAgentFlow
    {
        public string ExternalAgentId { get; set; }
        public string ExternalAgentOvid { get; set; }
        public string ExternalAgentName { get; set; }
        public string FlowId { get; set; }
        public string FlowOvid { get; set; }
        public string FlowName { get; set; }
        public string IncomingOutgoingFlag { get; set; }
        public string DesignOvid { get; set; }
    }
}
