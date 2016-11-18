using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsDeptCost
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public Nullable<int> CostSubjId { get; set; }
        public Nullable<decimal> TotAmount { get; set; }
        public Nullable<decimal> PlanAmount { get; set; }
        public Nullable<decimal> PrimeCost { get; set; }
        public Nullable<decimal> ApportCost1 { get; set; }
        public Nullable<decimal> ApportCost2 { get; set; }
        public Nullable<decimal> ApportCost3 { get; set; }
        public Nullable<decimal> ApportCost4 { get; set; }
        public Nullable<decimal> ApportCostSend { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual CsCostSubj CsCostSubj { get; set; }
    }
}
