using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuStoreLog
    {
        public int ID { get; set; }
        public System.DateTime HappenTime { get; set; }
        public int HouseId { get; set; }
        public int ItemId { get; set; }
        public int InBatchId { get; set; }
        public decimal BeforeStockNum { get; set; }
        public decimal HappenNum { get; set; }
        public decimal AfterStockNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public int UnitId { get; set; }
        public string BillNo { get; set; }
        public short LsActType { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual HuStore HuStore { get; set; }
    }
}
