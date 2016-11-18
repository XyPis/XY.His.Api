using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsDeptIncome
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public Nullable<int> FeeHsId { get; set; }
        public int OperLocId { get; set; }
        public int ExcLocId { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string Abstract { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHsFeety BsHsFeety { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
