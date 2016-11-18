using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VW_RKBillInfo
    {
        public Nullable<int> ID { get; set; }
        public string VoucherNo { get; set; }
        public string PNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string ManufactureryName { get; set; }
        public Nullable<decimal> DrugNum { get; set; }
        public string UnitName { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<decimal> TotalRetail { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public string BillNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public bool IsSign { get; set; }
        public string InBatchNo { get; set; }
        public int BillId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public int HouseId { get; set; }
        public int CompId { get; set; }
        public int OperId { get; set; }
        public Nullable<int> SignOperId { get; set; }
    }
}
