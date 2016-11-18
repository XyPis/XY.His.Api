using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class AdviceAuthDtl
    {
        public int ID { get; set; }
        public Nullable<int> LsMarkType { get; set; }
        public Nullable<System.DateTime> AdviceTime { get; set; }
        public Nullable<int> AdviceId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> GroupNum { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> FormId { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<decimal> ToTalityAll { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> UnitInId { get; set; }
        public Nullable<bool> IsAttach { get; set; }
        public Nullable<bool> IsSelf { get; set; }
        public Nullable<int> LsSpecialUsage { get; set; }
        public Nullable<int> LsExecLoc { get; set; }
        public Nullable<System.DateTime> SkinTime { get; set; }
        public Nullable<bool> IsSkin { get; set; }
        public string SkinTest { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<bool> IsPrinted { get; set; }
        public Nullable<bool> IsChk { get; set; }
        public Nullable<System.DateTime> ChkOperTime { get; set; }
        public Nullable<int> ChkOperID { get; set; }
        public Nullable<bool> IsEnd { get; set; }
        public Nullable<System.DateTime> EndOperTime { get; set; }
        public Nullable<int> EndOperID { get; set; }
        public Nullable<int> EndDoctorID { get; set; }
        public Nullable<bool> IsAuth { get; set; }
        public Nullable<System.DateTime> AuthOperTime { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public string Memo { get; set; }
        public Nullable<bool> IsOtherFee { get; set; }
        public Nullable<bool> IsBeforeops { get; set; }
        public Nullable<int> LsRpType { get; set; }
        public Nullable<bool> IsInject { get; set; }
        public string SN { get; set; }
        public Nullable<int> FirstDay { get; set; }
        public Nullable<int> LastDay { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public Nullable<int> OriAdviceId { get; set; }
        public Nullable<int> InfeeCheck { get; set; }
        public Nullable<int> Adcolor { get; set; }
        public bool IsManual { get; set; }
        public Nullable<bool> IsArrearage { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<bool> IsTodayIn { get; set; }
        public Nullable<int> DrugReqId1 { get; set; }
        public Nullable<int> DrugReqId2 { get; set; }
        public Nullable<int> DetailId1 { get; set; }
        public Nullable<int> DetailId2 { get; set; }
        public string AdviceName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Spec { get; set; }
        public Nullable<int> ExecuteId { get; set; }
        public Nullable<int> ExecuteId2 { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> ExecDoctorId { get; set; }
        public virtual BsItem BsItem { get; set; }
    }
}
