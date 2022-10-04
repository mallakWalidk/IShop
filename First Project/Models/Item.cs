using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class Item
    {
        public decimal ProId { get; set; }
        public string ProName { get; set; }
        public decimal? ProPrice { get; set; }
        public decimal? ProCom { get; set; }
    }
}
