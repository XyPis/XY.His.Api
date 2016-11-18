using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class PsDiagMeeting
    {
        public PsDiagMeeting()
        {
            this.PsDiagDoctors = new List<PsDiagDoctor>();
        }

        public int ID { get; set; }
        public string ApplyNo { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Clinic { get; set; }
        public bool IsUrgent { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual ICollection<PsDiagDoctor> PsDiagDoctors { get; set; }
    }
}
