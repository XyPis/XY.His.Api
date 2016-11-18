using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class YbPatSeq
    {
        public int ID { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public string YbSeq { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
