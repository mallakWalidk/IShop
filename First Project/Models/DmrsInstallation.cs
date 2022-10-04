using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsInstallation
    {
        public decimal? DmrsPersistenceVersion { get; set; }
        public decimal? DmrsReportsVersion { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
