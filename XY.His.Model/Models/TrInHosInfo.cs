using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TrInHosInfo
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> BedId { get; set; }
        public Nullable<short> LsInStatus { get; set; }
        public Nullable<int> LocIn { get; set; }
        public string Residence { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string IdCardNo { get; set; }
        public Nullable<short> LsMarriage { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
