using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuStockDtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public string InBatchNo { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public bool IsBid { get; set; }
        public string VoucherNo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ProAreaId { get; set; }
        public Nullable<int> ManuId { get; set; }
        public string PassNo { get; set; }
        public Nullable<decimal> PriceHighLine { get; set; }
        public virtual BsArea BsArea { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsManufacturer BsManufacturer { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual HuStock HuStock { get; set; }
    }
}
