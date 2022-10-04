using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsDiagram
    {
        public string DiagramName { get; set; }
        public string ObjectId { get; set; }
        public string Ovid { get; set; }
        public string DiagramType { get; set; }
        public string IsDisplay { get; set; }
        public string Visible { get; set; }
        public string MasterDiagramId { get; set; }
        public string MasterDiagramOvid { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string ModelName { get; set; }
        public string SubviewId { get; set; }
        public string SubviewOvid { get; set; }
        public string SubviewName { get; set; }
        public string DisplayId { get; set; }
        public string DisplayOvid { get; set; }
        public string DisplayName { get; set; }
        public string Notation { get; set; }
        public string ShowAllDetails { get; set; }
        public string ShowNamesOnly { get; set; }
        public string ShowElements { get; set; }
        public string ShowDatatype { get; set; }
        public string ShowKeys { get; set; }
        public string Autoroute { get; set; }
        public string BoxInBox { get; set; }
        public string MasterDiagramName { get; set; }
        public string DiagramSvg { get; set; }
        public byte[] DiagramPdf { get; set; }
        public string DesignOvid { get; set; }
    }
}
