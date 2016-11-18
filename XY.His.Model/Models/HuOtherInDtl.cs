using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuOtherInDtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public string InBatchNo { get; set; }
        public int ItemId { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> CompId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public System.DateTime StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual HuOtherIn HuOtherIn { get; set; }
    }
}
