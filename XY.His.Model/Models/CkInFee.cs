using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkInFee
    {
        public int ID { get; set; }
        public int LabId { get; set; }
        public Nullable<int> DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CkLab CkLab { get; set; }
    }
}
