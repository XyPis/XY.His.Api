using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class PatCardFee
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<int> PaywayId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsPayWay BsPayWay { get; set; }
    }
}
