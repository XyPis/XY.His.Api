using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuRegInvoice
    {
        public int ID { get; set; }
        public string InvoNo { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public string CancelTimeStr { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public System.DateTime InvoTime { get; set; }
        public string InvoTimeStr { get; set; }
        public decimal RegFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal ZyFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public int MzRegId { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexName { get; set; }
        public int PatId { get; set; }
        public string MzRegNo { get; set; }
        public string MzRegNo2 { get; set; }
        public string CardNo { get; set; }
        public int RegTypeId { get; set; }
        public string RegTypeName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int RegDept { get; set; }
        public string LocationName { get; set; }
        public bool IsPriority { get; set; }
        public string RoomNo { get; set; }
        public bool IsElder { get; set; }
        public bool IsFreeDiag { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsPreReg { get; set; }
        public bool IsFreeReg { get; set; }
        public string RegTimeStr { get; set; }
        public System.DateTime RegTime { get; set; }
        public int OperId { get; set; }
        public Nullable<int> DiagnDept { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public Nullable<decimal> DiscDiag { get; set; }
        public int LineOrder { get; set; }
        public Nullable<bool> IsFirstDiag { get; set; }
    }
}
