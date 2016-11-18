using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InDaySum
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public System.DateTime RegDate { get; set; }
        public decimal NotPay { get; set; }
        public decimal HasPay { get; set; }
        public decimal DaySum { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<decimal> Remain { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
