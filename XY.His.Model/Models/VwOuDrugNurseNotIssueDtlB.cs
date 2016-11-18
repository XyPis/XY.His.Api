using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuDrugNurseNotIssueDtlB
    {
        public int ID { get; set; }
        public Nullable<bool> IsSelected { get; set; }
        public Nullable<bool> IsDoctorInput { get; set; }
        public bool IsToBack { get; set; }
        public Nullable<int> IssueOperId { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public bool IsPrepared { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public bool IsCancel { get; set; }
        public bool IsCharged { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public string Memo { get; set; }
        public bool IsOtherFee { get; set; }
        public bool IsAttach { get; set; }
        public int UnitDiagId { get; set; }
        public decimal Totality { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public decimal Dosage { get; set; }
        public short GroupNum { get; set; }
        public int ItemId { get; set; }
        public int ListNum { get; set; }
        public int RecipeId { get; set; }
        public string UsageName { get; set; }
        public bool IsBack { get; set; }
        public string UnitTakeName { get; set; }
        public string UnitDiagName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal PriceDiag { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> FormId { get; set; }
        public string FormName { get; set; }
        public string FrequencyName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
