using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class vwHustoresDay
    {
        public int ID { get; set; }
        public int HouseId { get; set; }
        public string UnitName { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Spec { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public string HouseName { get; set; }
        public Nullable<System.DateTime> StockTime { get; set; }
        public Nullable<decimal> StockNum { get; set; }
        public Nullable<decimal> StockAmount { get; set; }
        public Nullable<decimal> RetailAmount { get; set; }
        public Nullable<bool> IsAntiBacterial { get; set; }
        public bool IsSpecSum { get; set; }
        public bool OptionPrice { get; set; }
        public int IsDrug { get; set; }
    }
}
