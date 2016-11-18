using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwEquipmentRepair
    {
        public int ID { get; set; }
        public int OperID { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public string EqType { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }
        public string BsLocationName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string LsEqType { get; set; }
        public Nullable<System.DateTime> RepairTime { get; set; }
        public string RepairMan { get; set; }
        public Nullable<decimal> RepairFee { get; set; }
        public string Reason { get; set; }
    }
}
