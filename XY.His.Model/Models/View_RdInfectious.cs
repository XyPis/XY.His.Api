using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class View_RdInfectious
    {
        public System.DateTime OperTime { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
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
        public Nullable<int> IllIdCor { get; set; }
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
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> ReciOperId { get; set; }
        public Nullable<int> AFPID { get; set; }
        public Nullable<int> IsWrite { get; set; }
        public string MzRegNo { get; set; }
        public string Sex { get; set; }
    }
}
