using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OpsCharge
    {
        public int ID { get; set; }
        public int ApplyId { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool IsTally { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<decimal> Before { get; set; }
        public Nullable<decimal> Progress { get; set; }
        public Nullable<decimal> After { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual OpsApply OpsApply { get; set; }
    }
}
