using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmstoresDay
    {
        public int ID { get; set; }
        public System.DateTime StockTime { get; set; }
        public int StockID { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public int unitid { get; set; }
        public Nullable<int> CompId { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockNum { get; set; }
        public bool IsBid { get; set; }
        public bool IsInject { get; set; }
        public bool OptionPrice { get; set; }
        public bool IsSpecSum { get; set; }
        public bool IsAntiBacterial { get; set; }
    }
}
