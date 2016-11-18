using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsLogisticServeDetail
    {
        public int ID { get; set; }
        public System.DateTime ServeDate { get; set; }
        public string Abstract { get; set; }
        public int LogisticServeId { get; set; }
        public int BenefitLocId { get; set; }
        public int ServeLocId { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<decimal> Equivalent { get; set; }
        public string ServeNo { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<bool> IsAcctMark { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
