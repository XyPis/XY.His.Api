using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwHuStoresHasNum
    {
        public string PNo { get; set; }
        public Nullable<int> CompId { get; set; }
        public System.DateTime StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public decimal PriceIn { get; set; }
        public decimal PriceDiag { get; set; }
        public int ItemId { get; set; }
        public string InBatchNo { get; set; }
    }
}
