using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InDrugReqBack
    {
        public int ID { get; set; }
        public int ReqDtlId { get; set; }
        public short ListNum { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsBack { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public Nullable<int> AdviceId { get; set; }
        public Nullable<short> LsMarkType { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> RequestId { get; set; }
        public virtual BsUnit BsUnit { get; set; }
    }
}
