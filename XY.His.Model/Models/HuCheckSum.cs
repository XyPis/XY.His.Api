using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuCheckSum
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public string SumFor { get; set; }
        public decimal BuyIn { get; set; }
        public decimal BackIn { get; set; }
        public decimal PyIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal DeptOut { get; set; }
        public decimal SaleOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal PkOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public decimal CheckAmou { get; set; }
        public decimal BalanceAmou { get; set; }
        public decimal TotalPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual HuCheck HuCheck { get; set; }
    }
}
