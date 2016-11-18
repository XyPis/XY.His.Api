using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InChangeBed
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public short LsLocal { get; set; }
        public System.DateTime ChgTime { get; set; }
        public int PreBed { get; set; }
        public int PostBed { get; set; }
        public string Reason { get; set; }
        public int DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBed BsBed { get; set; }
        public virtual BsBed BsBed1 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
