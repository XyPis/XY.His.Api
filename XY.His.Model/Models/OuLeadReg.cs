using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuLeadReg
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public int RegTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsElder { get; set; }
        public int LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsRegType BsRegType { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
