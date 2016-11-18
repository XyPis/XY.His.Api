using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsDeptCostPara
    {
        public int ID { get; set; }
        public int LocId { get; set; }
        public int CostSubjId { get; set; }
        public Nullable<short> LsAppPara { get; set; }
        public string ToLocIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual CsCostSubj CsCostSubj { get; set; }
    }
}
