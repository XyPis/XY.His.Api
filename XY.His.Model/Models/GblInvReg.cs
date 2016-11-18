using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblInvReg
    {
        public int ID { get; set; }
        public string InvType { get; set; }
        public string Name { get; set; }
        public string StartInvoNo { get; set; }
        public string EndInvoNo { get; set; }
        public bool IsEnd { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
