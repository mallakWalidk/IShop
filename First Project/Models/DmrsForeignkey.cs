using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsForeignkey
    {
        public string FkName { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ObjectId { get; set; }
        public string Ovid { get; set; }
        public string ImportId { get; set; }
        public string ChildTableName { get; set; }
        public string ReferredTableName { get; set; }
        public string Engineer { get; set; }
        public string DeleteRule { get; set; }
        public string ChildTableId { get; set; }
        public string ChildTableOvid { get; set; }
        public string ReferredTableId { get; set; }
        public string ReferredTableOvid { get; set; }
        public string ReferredKeyId { get; set; }
        public string ReferredKeyOvid { get; set; }
        public decimal NumberOfColumns { get; set; }
        public string Mandatory { get; set; }
        public string Transferable { get; set; }
        public string InArc { get; set; }
        public string ArcId { get; set; }
        public string ModelName { get; set; }
        public string ReferredKeyName { get; set; }
        public string DiscriminatorColumnOvid { get; set; }
        public string DiscriminatorValue { get; set; }
        public string DesignOvid { get; set; }
    }
}
