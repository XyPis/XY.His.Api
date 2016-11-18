using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuExecuteBack
    {
        public int ID { get; set; }
        public int ExecuteId { get; set; }
        public int ExecuteDtlId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsBack { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> KsBackBillId { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual OuExecute OuExecute { get; set; }
        public virtual OuExecuteDtl OuExecuteDtl { get; set; }
    }
}
