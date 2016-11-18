using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsOuWorkLog
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public int OutpNum { get; set; }
        public int OperatedNum { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> InputTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
