using System;
using System.Collections.Generic;

namespace XY.His.Domain.IN
{
    public partial class InAdviceGroup : EntityBase
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int UsageId { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public Nullable<short> LsMarkType { get; set; }
        public Nullable<int> MaxFrequency { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> LocationId { get; set; }
    }
}
