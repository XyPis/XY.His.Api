using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InCallBack
    {
        public int ID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public int HospId { get; set; }
        public System.DateTime BackTime { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
