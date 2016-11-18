using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsDeptCostTrace
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public Nullable<int> CostSubjId { get; set; }
        public Nullable<int> FromLocId { get; set; }
        public decimal Amount { get; set; }
        public short Step { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
    }
}
