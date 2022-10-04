using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsMapping
    {
        public string LogicalModelId { get; set; }
        public string LogicalModelOvid { get; set; }
        public string LogicalModelName { get; set; }
        public string LogicalObjectId { get; set; }
        public string LogicalObjectOvid { get; set; }
        public string LogicalObjectName { get; set; }
        public string LogicalObjectType { get; set; }
        public string RelationalModelId { get; set; }
        public string RelationalModelOvid { get; set; }
        public string RelationalModelName { get; set; }
        public string RelationalObjectId { get; set; }
        public string RelationalObjectOvid { get; set; }
        public string RelationalObjectName { get; set; }
        public string RelationalObjectType { get; set; }
        public string EntityId { get; set; }
        public string EntityOvid { get; set; }
        public string EntityName { get; set; }
        public string TableId { get; set; }
        public string TableOvid { get; set; }
        public string TableName { get; set; }
        public string DesignId { get; set; }
        public string DesignOvid { get; set; }
        public string DesignName { get; set; }
    }
}
