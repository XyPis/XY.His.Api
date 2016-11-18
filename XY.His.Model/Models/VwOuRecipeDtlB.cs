using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuRecipeDtlB
    {
        public int ID { get; set; }
        public short LsRepType { get; set; }
        public string LsRepTypeName { get; set; }
        public string RecipeNum { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<short> HowMany { get; set; }
        public bool IsPriority { get; set; }
        public string Memo { get; set; }
        public bool IsPend { get; set; }
        public bool IsExecuted { get; set; }
        public Nullable<bool> IsDoctorInput { get; set; }
        public short GroupNum { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public string UnitTakeName { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public string FrequencyName { get; set; }
        public Nullable<int> UsageId { get; set; }
        public string UsageName { get; set; }
        public Nullable<short> Days { get; set; }
        public decimal Totality { get; set; }
        public string UnitDiagName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> FeeTotality { get; set; }
        public int UnitDiagId { get; set; }
        public short LsGfType { get; set; }
        public string LsGfTypeName { get; set; }
        public short LsRpType { get; set; }
        public string LsRpTypeName { get; set; }
        public decimal PriceDiag { get; set; }
        public string F4 { get; set; }
        public string F3 { get; set; }
        public string F2 { get; set; }
        public string F1 { get; set; }
        public bool IsBack { get; set; }
        public bool IsToBack { get; set; }
        public Nullable<int> IssueOperId { get; set; }
        public Nullable<System.DateTime> IssueTime { get; set; }
        public bool IsIssue { get; set; }
        public Nullable<int> PrepareOperId { get; set; }
        public string PrepareTime { get; set; }
        public bool IsPrepared { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public bool IsCancel { get; set; }
        public bool IsCharged { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public bool IsOtherFee { get; set; }
        public bool IsAttach { get; set; }
        public int MzRegId { get; set; }
        public string MzRegNo { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexName { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public int RegTypeId { get; set; }
        public string RegTypeName { get; set; }
        public string DoctorCode { get; set; }
        public string ItemCode { get; set; }
    }
}
