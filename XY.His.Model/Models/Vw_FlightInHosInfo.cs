using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightInHosInfo
    {
        public string HospNo { get; set; }
        public string InPatNo { get; set; }
        public int PatID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public System.DateTime InTime { get; set; }
        public string 职业 { get; set; }
        public short LsMarriage { get; set; }
        public short LsInType { get; set; }
        public string 入院目的 { get; set; }
        public short LsInIllness { get; set; }
        public string Sensitive { get; set; }
        public string 不良反应 { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string BedName { get; set; }
        public string IllDesc { get; set; }
    }
}
