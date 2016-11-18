using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElPatFormVDtl
    {
        public int ID { get; set; }
        public Nullable<int> PatFormId { get; set; }
        public Nullable<int> PatFormValueId { get; set; }
        public Nullable<int> ElId { get; set; }
        public Nullable<int> BsDtlId { get; set; }
        public string ElValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ElBaseDtl ElBaseDtl { get; set; }
        public virtual ElBaseFiled ElBaseFiled { get; set; }
    }
}
