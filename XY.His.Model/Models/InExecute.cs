using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InExecute
    {
        public int ID { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int LocationId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public string Memo { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<System.DateTime> PrintOperTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<System.DateTime> AdviceTime { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<int> UnitInId { get; set; }
        public Nullable<bool> IsUrgent { get; set; }
        public Nullable<bool> IsAttach { get; set; }
        public Nullable<bool> IsSelf { get; set; }
        public Nullable<short> LsSpecialUsage { get; set; }
        public Nullable<short> LsExecLoc { get; set; }
        public Nullable<bool> IsSkin { get; set; }
        public Nullable<System.DateTime> SkinTime { get; set; }
        public string SkinTest { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public Nullable<bool> IsExecuted { get; set; }
        public Nullable<System.DateTime> ExecutedTime { get; set; }
        public Nullable<int> ExecutedOperId { get; set; }
        public Nullable<bool> IsMinus { get; set; }
        public string NurseMemo { get; set; }
        public Nullable<System.DateTime> MemoTime { get; set; }
        public Nullable<int> MemoOperId { get; set; }
        public Nullable<short> FirstDay { get; set; }
        public Nullable<short> LastDay { get; set; }
        public Nullable<bool> IsLastLong { get; set; }
        public Nullable<bool> IsArrearage { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsLocation BsLocation2 { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUnit BsUnit1 { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
