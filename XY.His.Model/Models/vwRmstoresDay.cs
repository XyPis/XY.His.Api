using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class vwRmstoresDay
    {
        public int ID { get; set; }
        public int RoomId { get; set; }
        public string UnitName { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public string Spec { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public string RoomName { get; set; }
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
