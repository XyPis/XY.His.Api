using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuDocRegType
    {
        public int ID { get; set; }
        public System.DateTime RegDate { get; set; }
        public Nullable<int> WeekPlanId { get; set; }
        public int DoctorId { get; set; }
        public int RegTypeId { get; set; }
        public int TimeSpanId { get; set; }
        public int LocationId { get; set; }
        public Nullable<int> DiagRoomId { get; set; }
        public Nullable<short> LimitNum { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDiagRoom BsDiagRoom { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsRegType BsRegType { get; set; }
    }
}
