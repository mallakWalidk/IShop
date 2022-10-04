using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDiagramElement
    {
        public string Name { get; set; }
        public string LongName { get; set; }
        public string Type { get; set; }
        public string GeometryType { get; set; }
        public string ObjectId { get; set; }
        public string Ovid { get; set; }
        public string ViewId { get; set; }
        public string SourceId { get; set; }
        public string SourceOvid { get; set; }
        public string SourceViewId { get; set; }
        public string TargetId { get; set; }
        public string TargetOvid { get; set; }
        public string TargetViewId { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public decimal? LocationX { get; set; }
        public decimal? LocationY { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public int? BgColor { get; set; }
        public int? FgColor { get; set; }
        public string UseDefaultColor { get; set; }
        public string Formatting { get; set; }
        public string Points { get; set; }
        public string DiagramOvid { get; set; }
        public string DiagramId { get; set; }
        public string DiagramName { get; set; }
        public string SourceName { get; set; }
        public string TargetName { get; set; }
        public string ModelName { get; set; }
        public string DesignOvid { get; set; }
    }
}
