using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInInvoice
    {
        public int ID { get; set; }
        public string InvoNo { get; set; }
        public short LsPayType { get; set; }
        public string LsPayTypeName { get; set; }
        public System.DateTime ToDate { get; set; }
        public short ChargeDays { get; set; }
        public decimal Beprice { get; set; }
        public decimal FactGet { get; set; }
        public decimal Insurance { get; set; }
        public decimal PaySelf { get; set; }
        public decimal Deposit { get; set; }
        public decimal Complement { get; set; }
        public decimal Arrearage { get; set; }
        public decimal AmountPay { get; set; }
        public decimal AddFee { get; set; }
        public string TallyNo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime FromDate { get; set; }
        public string OperTime { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public bool IsCancel { get; set; }
        public string CancelOperTime { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public string CancelOperName { get; set; }
        public Nullable<int> InvoLastId { get; set; }
        public Nullable<int> PatID { get; set; }
        public string InPatNo { get; set; }
        public int HospId { get; set; }
        public string HospNo { get; set; }
        public string PatientName { get; set; }
        public string CardNo { get; set; }
        public string Sex { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> BedId { get; set; }
        public string BedName { get; set; }
        public Nullable<bool> IsAdd { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> NTime { get; set; }
        public Nullable<int> InDays { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<short> LsInStatus { get; set; }
        public string LsInStatusName { get; set; }
        public Nullable<decimal> DiscDiag { get; set; }
        public Nullable<decimal> DiscIn { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public string IdCardNo { get; set; }
    }
}
