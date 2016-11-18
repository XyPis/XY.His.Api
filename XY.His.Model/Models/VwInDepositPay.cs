using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInDepositPay
    {
        public int ID { get; set; }
        public string BillNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public decimal Amount { get; set; }
        public decimal Remain { get; set; }
        public bool IsFirst { get; set; }
        public string Remark { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<short> LsCancelType { get; set; }
        public string LsCancelTypeName { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<int> InvoId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int HospId { get; set; }
        public string InPatNo { get; set; }
        public string PatientName { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public string BedName { get; set; }
        public int NTime { get; set; }
        public Nullable<int> InDays { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int LocIn { get; set; }
        public string LocInName { get; set; }
        public short LsInStatus { get; set; }
        public string LsInStatusName { get; set; }
        public string CardNo { get; set; }
        public string OperName { get; set; }
        public string CancelOperName { get; set; }
        public int paywayid { get; set; }
        public decimal PayAmount { get; set; }
        public string PayWayName { get; set; }
    }
}
