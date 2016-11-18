using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InArrearAmount
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public decimal ArrearAmount { get; set; }
        public string AuthMan { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<short> ExpireHours { get; set; }
        public Nullable<bool> IsMax { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
