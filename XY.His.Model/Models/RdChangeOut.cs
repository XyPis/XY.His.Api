using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdChangeOut
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> ChangeTime { get; set; }
        public string Reason { get; set; }
        public string ToHospital { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public string BackDiagnose { get; set; }
        public string Disposal { get; set; }
        public string Memo { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
