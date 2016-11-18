using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuInvoice
    {
        public int ID { get; set; }
        public string InvoNo { get; set; }
        public System.DateTime InvoTime { get; set; }
        public int InvoId { get; set; }
        public Nullable<decimal> Beprice { get; set; }
        public decimal FactGet { get; set; }
        public decimal Insurance { get; set; }
        public decimal PaySelf { get; set; }
        public decimal AmountPay { get; set; }
        public decimal AddFee { get; set; }
        public string TallyNo { get; set; }
        public int MzRegId { get; set; }
        public Nullable<int> PatId { get; set; }
        public string CardNo { get; set; }
        public string MedicareNo { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> RegDept { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string LocationName { get; set; }
        public string MzRegNo { get; set; }
        public Nullable<System.DateTime> RegTime { get; set; }
        public string Sex { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<decimal> DiscDiag { get; set; }
        public Nullable<decimal> DiscIn { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string LsGFPatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public string WorkTypeName { get; set; }
        public Nullable<int> RegTypeId { get; set; }
        public string RegTypeName { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public string CancelOperName { get; set; }
        public Nullable<int> InvoLastId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public string InvoLastNo { get; set; }
        public string Remark { get; set; }
    }
}
