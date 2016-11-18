using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuInCar
    {
        public int ID { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public int DoctorId { get; set; }
        public int NurseOperId { get; set; }
        public int DriverOperId { get; set; }
        public string CarNumber { get; set; }
        public System.DateTime CarTime { get; set; }
        public decimal Distance { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
