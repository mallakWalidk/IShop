using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsKey
    {
        public string KeyName { get; set; }
        public string ObjectId { get; set; }
        public string Ovid { get; set; }
        public string ImportId { get; set; }
        public string ContainerId { get; set; }
        public string ContainerOvid { get; set; }
        public string State { get; set; }
        public string Synonyms { get; set; }
        public string EntityName { get; set; }
        public string DesignOvid { get; set; }
    }
}
