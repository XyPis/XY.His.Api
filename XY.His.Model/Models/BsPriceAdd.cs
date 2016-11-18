using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPriceAdd
    {
        public int ID { get; set; }
        public decimal PriceLow { get; set; }
        public Nullable<decimal> PriceHigh { get; set; }
        public Nullable<decimal> AddPercent { get; set; }
        public Nullable<decimal> AddPrice { get; set; }
        public string FeeIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
