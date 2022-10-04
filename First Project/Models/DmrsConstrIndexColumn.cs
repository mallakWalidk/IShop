using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsConstrIndexColumn
    {
        public string IndexId { get; set; }
        public string IndexOvid { get; set; }
        public string ColumnId { get; set; }
        public string ColumnOvid { get; set; }
        public string TableId { get; set; }
        public string TableOvid { get; set; }
        public string IndexName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public decimal Sequence { get; set; }
        public string SortOrder { get; set; }
        public string DesignOvid { get; set; }
    }
}
