using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.OP
{
    [Serializable]
    public partial class PsApplyReportDto : DtoBase
    {
        public string ApplyNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public int PatId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public short XType { get; set; }
        public bool IsPre { get; set; }
        public Nullable<int> ItemId { get; set; }
        public bool IsCharged { get; set; }
        public bool IsConfirm { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public string Equipment { get; set; }
        public string ApplyMemo { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<int> CheckOperId { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public Nullable<int> ReportOperId { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public string CheckBody { get; set; }
        public string CheckParm { get; set; }
        public string CheckDesc { get; set; }
        public string CheckResult { get; set; }
        public string CheckAdvice { get; set; }
        public bool IsAbNormal { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string Diagnose { get; set; }
        public Nullable<int> CheckId { get; set; }     
        public Nullable<int> ExecuteId { get; set; }       
    }
}
