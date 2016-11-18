using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InHosBed
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int BedId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBed BsBed { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
