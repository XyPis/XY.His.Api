using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InWorkLog
    {
        public int ID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<decimal> BedSum { get; set; }
        public Nullable<decimal> OverBedSum { get; set; }
        public string Standard { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<short> LastNum { get; set; }
        public Nullable<short> StartNum { get; set; }
        public Nullable<short> InHospital { get; set; }
        public Nullable<short> InLocation { get; set; }
        public Nullable<short> OutLocation { get; set; }
        public Nullable<short> OutHospital { get; set; }
        public Nullable<short> Dead { get; set; }
        public Nullable<short> NowNum { get; set; }
        public Nullable<short> OverNum { get; set; }
        public Nullable<short> CompanyNum { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> Days { get; set; }
        public Nullable<int> Danger { get; set; }
        public Nullable<int> Heavy { get; set; }
        public Nullable<int> Acute { get; set; }
    }
}
