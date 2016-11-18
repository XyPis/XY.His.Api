using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmCheckDtl
    {
        public int ID { get; set; }
        public int CheckId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> CompId { get; set; }
        public int UnitId { get; set; }
        public decimal BalanceNum { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public decimal CheckNum { get; set; }
        public Nullable<int> OperId { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string compare { get; set; }
        public bool balance { get; set; }
        public bool isAdjust { get; set; }
        public decimal ApplyIn { get; set; }
        public decimal MzBackIn { get; set; }
        public decimal ZyBackIn { get; set; }
        public decimal MoveIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal MoveOut { get; set; }
        public decimal MzOut { get; set; }
        public decimal ZyOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal OtherOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public decimal RecipeOut { get; set; }
        public decimal KsBackIn { get; set; }
        public decimal KsOut { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual RmCheck RmCheck { get; set; }
        public virtual Rmstore Rmstore { get; set; }
    }
}
