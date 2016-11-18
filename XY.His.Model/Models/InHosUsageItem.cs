using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InHosUsageItem
    {
        public int ID { get; set; }
        public Nullable<int> UsageId { get; set; }
        public int ItemId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public decimal Totality { get; set; }
        public Nullable<int> GroupNum { get; set; }
        public int HospId { get; set; }
        public string UsageMemo { get; set; }
        public string AdviceMemo { get; set; }
        public int UsageItemId { get; set; }
        public decimal Times { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime AdviceTime { get; set; }
        public Nullable<int> FrequencyId { get; set; }
    }
}
