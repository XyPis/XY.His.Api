using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TrScheduler
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int LineId { get; set; }
        public System.DateTime ScheTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> IconIndex { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual TrScheLine TrScheLine { get; set; }
    }
}
