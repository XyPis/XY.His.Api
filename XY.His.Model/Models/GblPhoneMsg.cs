using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblPhoneMsg
    {
        public int ID { get; set; }
        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
