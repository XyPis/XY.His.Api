using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkBldReaction
    {
        public int ID { get; set; }
        public string RecNo { get; set; }
        public int LabId { get; set; }
        public Nullable<int> HospId { get; set; }
        public int BloodId { get; set; }
        public Nullable<System.DateTime> TransTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string TransType { get; set; }
        public Nullable<decimal> TotalVollume { get; set; }
        public Nullable<System.DateTime> ReactTime { get; set; }
        public Nullable<short> LsTransType { get; set; }
        public string ClincHandle { get; set; }
        public string TransHandle { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual CkBdBank CkBdBank { get; set; }
        public virtual CkLab CkLab { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
