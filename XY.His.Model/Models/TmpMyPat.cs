using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TmpMyPat
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public int DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public bool IsAlert { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsPatient BsPatient { get; set; }
    }
}
