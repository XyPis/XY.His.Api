using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdInfectStd
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public Nullable<short> LsCardType { get; set; }
        public Nullable<int> Gestation { get; set; }
        public Nullable<short> LsZone { get; set; }
        public Nullable<short> LsCancelType { get; set; }
        public Nullable<System.DateTime> IllDate { get; set; }
        public Nullable<System.DateTime> DiagDate { get; set; }
        public Nullable<System.DateTime> DeadDate { get; set; }
        public Nullable<int> IllId { get; set; }
        public string LsClincSymptom { get; set; }
        public string ReportUnit { get; set; }
        public Nullable<int> IllIdCor { get; set; }
        public string Memo { get; set; }
        public Nullable<short> LsCTrust { get; set; }
        public Nullable<short> LsCTiter { get; set; }
        public Nullable<short> LsCTPPA { get; set; }
        public Nullable<short> LsCOther { get; set; }
        public Nullable<short> LsETrust { get; set; }
        public Nullable<short> LsETiter { get; set; }
        public Nullable<short> LsETPPA { get; set; }
        public Nullable<short> LsEIgM { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string JName { get; set; }
        public Nullable<int> LocId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> ReciOperId { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
