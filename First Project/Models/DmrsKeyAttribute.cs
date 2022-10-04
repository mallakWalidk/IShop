using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsKeyAttribute
    {
        public string KeyId { get; set; }
        public string KeyOvid { get; set; }
        public string AttributeId { get; set; }
        public string AttributeOvid { get; set; }
        public string EntityId { get; set; }
        public string EntityOvid { get; set; }
        public string KeyName { get; set; }
        public string EntityName { get; set; }
        public string AttributeName { get; set; }
        public decimal? Sequence { get; set; }
        public string RelationshipId { get; set; }
        public string RelationshipOvid { get; set; }
        public string RelationshipName { get; set; }
        public string DesignOvid { get; set; }
    }
}
