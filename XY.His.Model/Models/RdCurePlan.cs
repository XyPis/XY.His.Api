using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdCurePlan
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Illness { get; set; }
        public string CureItem { get; set; }
        public string CurePlan { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
