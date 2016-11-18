using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NrPlan
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public string Target { get; set; }
        public string Measure { get; set; }
        public string BasisOf { get; set; }
        public string Evaluate { get; set; }
        public Nullable<int> EvalOperId { get; set; }
        public Nullable<System.DateTime> EvalTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
