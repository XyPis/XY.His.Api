using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkCompGroupPsApply
    {
        public int ID { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public short XType { get; set; }
        public bool IsPre { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string ApplyMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string Diagnose { get; set; }
        public Nullable<int> CompGroupId { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual CkCompanyGroup CkCompanyGroup { get; set; }
    }
}
