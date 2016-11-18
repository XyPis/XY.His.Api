using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InHosMzIll
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int ListNum { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> LsInOut { get; set; }
        public Nullable<short> LsWestChin { get; set; }
        public Nullable<bool> IsInfect { get; set; }
        public Nullable<bool> IsCoincidence { get; set; }
        public Nullable<int> CheckOperId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InHosInfo InHosInfo1 { get; set; }
    }
}
