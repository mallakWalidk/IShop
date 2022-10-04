using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsEvent
    {
        public string EventId { get; set; }
        public string EventOvid { get; set; }
        public string EventName { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string FlowId { get; set; }
        public string FlowOvid { get; set; }
        public string FlowName { get; set; }
        public string EventType { get; set; }
        public string TimesWhenRun { get; set; }
        public string DayOfWeek { get; set; }
        public string Months { get; set; }
        public int? Frequency { get; set; }
        public int? TimeFrequency { get; set; }
        public byte? Minute { get; set; }
        public byte? Hour { get; set; }
        public byte? DayOfMonth { get; set; }
        public bool? Quarter { get; set; }
        public byte? Year { get; set; }
        public string OnDay { get; set; }
        public string AtTime { get; set; }
        public string Fiscal { get; set; }
        public string Text { get; set; }
        public string DesignOvid { get; set; }
    }
}
