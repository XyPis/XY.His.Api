using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOpsApply
    {
        public string InPatNo { get; set; }
        public string MzRegNo { get; set; }
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string CardNo { get; set; }
        public string ApplyNo { get; set; }
        public Nullable<int> BsLocationId { get; set; }
        public string LocationName { get; set; }
        public string BsOPSName { get; set; }
        public Nullable<int> BsOPSID { get; set; }
        public string BsDoctorName { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public Nullable<bool> IsFinish { get; set; }
        public Nullable<int> BsDoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
    }
}
