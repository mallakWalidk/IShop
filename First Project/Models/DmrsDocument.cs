using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDocument
    {
        public string DocumentId { get; set; }
        public string DocumentOvid { get; set; }
        public string DocumentName { get; set; }
        public string BusinessInfoId { get; set; }
        public string BusinessInfoOvid { get; set; }
        public string BusinessInfoName { get; set; }
        public string ParentId { get; set; }
        public string ParentOvid { get; set; }
        public string ParentName { get; set; }
        public string DocReference { get; set; }
        public string DocType { get; set; }
        public string DesignOvid { get; set; }
    }
}
