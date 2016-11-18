using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuOtherOutDtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Reason { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual HuOtherOut HuOtherOut { get; set; }
        public virtual HuStore HuStore { get; set; }
    }
}
