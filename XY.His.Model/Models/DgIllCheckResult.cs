using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgIllCheckResult
    {
        public int ID { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string CheckResult { get; set; }
        public Nullable<bool> IsBaby { get; set; }
        public Nullable<bool> IsWomen { get; set; }
        public Nullable<bool> IsMen { get; set; }
        public Nullable<bool> IsOlder { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
