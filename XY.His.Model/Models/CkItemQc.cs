using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkItemQc
    {
        public int ID { get; set; }
        public int TestId { get; set; }
        public string QcName { get; set; }
        public Nullable<decimal> Dev3 { get; set; }
        public Nullable<decimal> Dev2 { get; set; }
        public Nullable<decimal> Dev1 { get; set; }
        public Nullable<decimal> DevM1 { get; set; }
        public Nullable<decimal> DevM2 { get; set; }
        public Nullable<decimal> DevM3 { get; set; }
        public Nullable<decimal> AvgValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> CtrlId { get; set; }
        public virtual CkQcControl CkQcControl { get; set; }
    }
}
