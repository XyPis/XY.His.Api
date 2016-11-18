using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdLiver
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public string Code { get; set; }
        public Nullable<short> LsCardType { get; set; }
        public Nullable<short> LsCensus { get; set; }
        public string JName { get; set; }
        public Nullable<short> LsZone { get; set; }
        public Nullable<short> LsCancelType { get; set; }
        public Nullable<System.DateTime> IllDate { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> DeadDate { get; set; }
        public Nullable<System.DateTime> DiagDate { get; set; }
        public Nullable<short> LsDiagType { get; set; }
        public Nullable<short> LsPreventive { get; set; }
        public Nullable<short> LsClinicType { get; set; }
        public Nullable<short> LsIllSource { get; set; }
        public string ALT { get; set; }
        public string Tbil { get; set; }
        public Nullable<short> LsK_HAVIgM { get; set; }
        public string HAV_RNA { get; set; }
        public Nullable<short> LsHbs_Ag { get; set; }
        public Nullable<short> LsK_HBs { get; set; }
        public Nullable<short> LsHBeAg { get; set; }
        public Nullable<short> LsK_HBe { get; set; }
        public Nullable<short> LsK_HBc { get; set; }
        public Nullable<short> LsK_HBcIgM { get; set; }
        public string HBV_DNA { get; set; }
        public Nullable<short> LsK_HCV { get; set; }
        public string HCV_RNA { get; set; }
        public Nullable<short> LsK_HDVIgM { get; set; }
        public string K_HDV { get; set; }
        public string HDV_RNA { get; set; }
        public Nullable<short> LsK_HEVIgM { get; set; }
        public Nullable<short> LsK_HEV { get; set; }
        public string HEV_RNA { get; set; }
        public Nullable<int> IllIdCor { get; set; }
        public string CancelMemo { get; set; }
        public string ReportUnit { get; set; }
        public Nullable<int> LocId { get; set; }
        public string Phone { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public string ReportPerson { get; set; }
        public Nullable<System.DateTime> JReportDate { get; set; }
        public string JReportPerson { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> ReciOperId { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
