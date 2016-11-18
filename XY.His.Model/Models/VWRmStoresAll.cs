using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VWRmStoresAll
    {
        public int ID { get; set; }
        public string InBatchNo { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> CompId { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public Nullable<System.DateTime> StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public bool IsBalance { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public Nullable<decimal> UnderLineKc { get; set; }
        public Nullable<decimal> UperLineKc { get; set; }
        public Nullable<decimal> NormalLineKc { get; set; }
        public Nullable<int> ProAreaId { get; set; }
        public Nullable<int> FormId { get; set; }
        public Nullable<int> ManuId { get; set; }
        public Nullable<short> LsImport { get; set; }
        public Nullable<bool> IsInject { get; set; }
        public Nullable<int> HouseId { get; set; }
        public Nullable<decimal> RetailTotal { get; set; }
        public Nullable<decimal> PriceTotal { get; set; }
    }
}
