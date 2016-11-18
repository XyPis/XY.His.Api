using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TrAdvice
    {
        public int ID { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public string Type { get; set; }
        public string Before { get; set; }
        public string After { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
