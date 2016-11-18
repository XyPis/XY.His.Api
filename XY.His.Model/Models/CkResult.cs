using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkResult
    {
        public int ID { get; set; }
        public int CheckId { get; set; }
        public int TestId { get; set; }
        public string LastResult { get; set; }
        public string Result { get; set; }
        public Nullable<short> LsRefFlag { get; set; }
        public Nullable<bool> IsPanic { get; set; }
        public Nullable<bool> IsDalta { get; set; }
        public Nullable<double> DalAbsolute { get; set; }
        public Nullable<double> DalPercent { get; set; }
        public Nullable<decimal> LowValue { get; set; }
        public Nullable<decimal> HighValue { get; set; }
        public Nullable<decimal> PanicLow { get; set; }
        public Nullable<decimal> PanicHigh { get; set; }
        public Nullable<bool> IsPass { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public string ReportBy { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public string Memo { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string TextRange { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> TestGroupId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public virtual CkMain CkMain { get; set; }
        public virtual CkTestGroup CkTestGroup { get; set; }
    }
}
