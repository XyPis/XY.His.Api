using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwHustoresRemain
    {
        public int ID { get; set; }
        public string InBatchNo { get; set; }
        public int ItemId { get; set; }
        public int HouseId { get; set; }
        public string RoomName { get; set; }
        public string PNo { get; set; }
        public string UnitName { get; set; }
        public string CompanyName { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public System.DateTime StoreDate { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> RemainNum { get; set; }
        public Nullable<decimal> RemainPercent { get; set; }
        public Nullable<int> StoreDays { get; set; }
        public Nullable<int> LimitDays { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public string Spec { get; set; }
    }
}
