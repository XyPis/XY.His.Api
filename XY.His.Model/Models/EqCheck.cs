using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class EqCheck
    {
        public int ID { get; set; }
        public int EquipmentId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public string CheckMan { get; set; }
        public string Result { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
