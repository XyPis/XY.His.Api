using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InPatLog
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string ActType { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
