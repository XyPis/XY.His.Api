using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdInfectiou
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public Nullable<short> LsCardType { get; set; }
        public Nullable<short> LsCensus { get; set; }
        public Nullable<short> LsZone { get; set; }
        public string Midwife { get; set; }
        public Nullable<short> LsCancelType { get; set; }
        public Nullable<System.DateTime> IllDate { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> DeadDate { get; set; }
        public Nullable<System.DateTime> DiagDate { get; set; }
        public Nullable<short> LsPreventive { get; set; }
        public string IllIdCor { get; set; }
        public string CancelMemo { get; set; }
        public string ReportUnit { get; set; }
        public Nullable<int> LocId { get; set; }
        public string Phone { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public Nullable<int> JIllId { get; set; }
        public Nullable<int> YIllId { get; set; }
        public Nullable<int> BIllId { get; set; }
        public Nullable<int> QIllId { get; set; }
        public string JName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> ReciOperId { get; set; }
        public Nullable<int> IsWrite { get; set; }
        public Nullable<int> Canceloperid { get; set; }
        public Nullable<int> Chkoperid { get; set; }
        public Nullable<bool> Printstart { get; set; }
        public Nullable<System.DateTime> ChkOperTime { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<short> lscanceltype2 { get; set; }
        public Nullable<int> Hospid { get; set; }
        public Nullable<int> WorkType { get; set; }
        public string QilLness { get; set; }
        public Nullable<int> AfpID { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
