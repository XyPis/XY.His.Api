using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class YBChargeLog
    {
        public int ID { get; set; }
        public string YbReqNo { get; set; }
        public string InvoNo { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
    }
}
