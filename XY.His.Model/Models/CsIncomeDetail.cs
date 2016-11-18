using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsIncomeDetail
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public System.DateTime PayDate { get; set; }
        public string Summary { get; set; }
        public Nullable<int> LocId { get; set; }
        public Nullable<int> ExcLocId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> FeeHsId { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<bool> IsAcct { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHsFeety BsHsFeety { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsLocation BsLocation { get; set; }
    }
}
