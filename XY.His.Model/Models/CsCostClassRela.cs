using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsCostClassRela
    {
        public int ID { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> CostSubjId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CsCostClass CsCostClass { get; set; }
        public virtual CsCostSubj CsCostSubj { get; set; }
    }
}
