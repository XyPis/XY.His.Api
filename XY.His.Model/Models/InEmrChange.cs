using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InEmrChange
    {
        public int ID { get; set; }
        public Nullable<int> EmrId { get; set; }
        public byte[] Content { get; set; }
        public string Modified { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<int> IsUse { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
