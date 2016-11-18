using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuRecipeDtl_A
    {
        public System.DateTime OperDate { get; set; }
        public int ID { get; set; }
        public int RecipeId { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public short GroupNum { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public decimal Totality { get; set; }
        public int UnitDiagId { get; set; }
        public bool IsAttach { get; set; }
        public bool IsOtherFee { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public string Memo { get; set; }
        public bool IsCharged { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public bool IsPrepared { get; set; }
        public string PrepareTime { get; set; }
        public Nullable<int> PrepareOperId { get; set; }
        public bool IsIssue { get; set; }
        public Nullable<System.DateTime> IssueTime { get; set; }
        public Nullable<int> IssueOperId { get; set; }
        public bool IsToBack { get; set; }
        public bool IsBack { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsDoctorInput { get; set; }
        public Nullable<int> RecNum { get; set; }
        public Nullable<System.DateTime> RecipeTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<int> AllPageNo { get; set; }
        public Nullable<int> PageNo { get; set; }
    }
}
