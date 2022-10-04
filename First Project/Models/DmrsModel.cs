using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsModel
    {
        public string DesignId { get; set; }
        public string DesignOvid { get; set; }
        public string DesignName { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string ModelType { get; set; }
        public string RdbmsType { get; set; }
    }
}
