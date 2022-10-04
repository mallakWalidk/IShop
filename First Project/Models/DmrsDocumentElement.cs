using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDocumentElement
    {
        public string DocumentId { get; set; }
        public string DocumentOvid { get; set; }
        public string DocumentName { get; set; }
        public string ElementId { get; set; }
        public string ElementOvid { get; set; }
        public string ElementName { get; set; }
        public string ElementType { get; set; }
        public string DesignOvid { get; set; }
    }
}
