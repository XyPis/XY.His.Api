using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsStLogisticServe
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public int LogisticServeId { get; set; }
        public int BenefitLocId { get; set; }
        public int ServeLocId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Money { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> InputTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CsLogisticServe CsLogisticServe { get; set; }
    }
}
