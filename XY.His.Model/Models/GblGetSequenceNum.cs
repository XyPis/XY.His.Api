using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblGetSequenceNum
    {
        public int ID { get; set; }
        public long NextSequenceNum { get; set; }
        public bool IsDayBegin { get; set; }
        public string GetdateStr { get; set; }
        public string NextSequenceStr { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
