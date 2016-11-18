using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class PsDiagDoctor
    {
        public int ID { get; set; }
        public Nullable<int> ApplyId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<bool> IsConfirm { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public string Answer { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual PsDiagMeeting PsDiagMeeting { get; set; }
    }
}
