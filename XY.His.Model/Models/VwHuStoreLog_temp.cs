using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwHuStoreLog_temp
    {
        public System.DateTime HappenTime { get; set; }
        public int HouseId { get; set; }
        public string HouseName { get; set; }
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public int BeforeStockNum { get; set; }
        public int AfterStockNum { get; set; }
        public decimal HappenNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public Nullable<decimal> StockPriceAmount { get; set; }
        public Nullable<decimal> RetailPriceAmount { get; set; }
        public string BillNo { get; set; }
        public string Memo { get; set; }
        public string OperUnitName { get; set; }
        public string LsActType { get; set; }
    }
}
