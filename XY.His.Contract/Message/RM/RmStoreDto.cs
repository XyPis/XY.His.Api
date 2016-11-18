using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.RM
{
    [Serializable]
    public partial class RmStoreDto : DtoBase
    {
        public string InBatchNo { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> CompId { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public Nullable<System.DateTime> StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public bool IsBalance { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }      
    }
}
