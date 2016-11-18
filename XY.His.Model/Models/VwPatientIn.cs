using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwPatientIn
    {
        public Nullable<int> ID { get; set; }
        public string InPatNo { get; set; }
        public string HospNo { get; set; }
        public int PatID { get; set; }
        public int HospId { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public short LsInIllness { get; set; }
        public int NTime { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public bool IsBaby { get; set; }
        public Nullable<int> BedId { get; set; }
        public Nullable<int> MainBedId { get; set; }
        public int CaptionIcon { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> Age { get; set; }
        public string AgeString { get; set; }
        public string SexName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public short LsInStatus { get; set; }
        public bool IsYbMt { get; set; }
        public int PatTypeId { get; set; }
        public Nullable<bool> IsUrgen { get; set; }
        public Nullable<bool> IsNewIn { get; set; }
    }
}
