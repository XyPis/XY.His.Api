using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuCheckDtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> CompId { get; set; }
        public int UnitId { get; set; }
        public decimal BalanceNum { get; set; }
        public decimal StcokNum { get; set; }
        public decimal InstoreNum { get; set; }
        public decimal CheckNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string compare { get; set; }
        public bool IsBalance { get; set; }
        public bool IsAdjust { get; set; }
        public decimal BuyIn { get; set; }
        public decimal BackIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal DeptOut { get; set; }
        public decimal SaleOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual HuCheck HuCheck { get; set; }
        public virtual HuStore HuStore { get; set; }
    }
}
