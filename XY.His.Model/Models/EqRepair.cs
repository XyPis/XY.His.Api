using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class EqRepair
    {
        public int ID { get; set; }
        public int EquipmentId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> RepairTime { get; set; }
        public string Reason { get; set; }
        public string RepairWay { get; set; }
        public string RepairUnit { get; set; }
        public string RepairMan { get; set; }
        public Nullable<decimal> RepairFee { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
