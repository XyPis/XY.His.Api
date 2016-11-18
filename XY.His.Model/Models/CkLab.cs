using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkLab
    {
        public CkLab()
        {
            this.CkBldReactions = new List<CkBldReaction>();
            this.CkBloodBacks = new List<CkBloodBack>();
            this.CkBloodSends = new List<CkBloodSend>();
            this.CkInFees = new List<CkInFee>();
            this.CkLabDtls = new List<CkLabDtl>();
            this.CkLabMics = new List<CkLabMic>();
            this.CKMachineSamples = new List<CKMachineSample>();
            this.CkLabResults = new List<CkLabResult>();
            this.CkReports = new List<CkReport>();
        }

        public int ID { get; set; }
        public string LabNum { get; set; }
        public int PatId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public short LsSource { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string RefLocation { get; set; }
        public string IllHistory { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPriority { get; set; }
        public Nullable<System.DateTime> CollectTime { get; set; }
        public Nullable<int> CollectOperId { get; set; }
        public string Memo { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<bool> IsPass { get; set; }
        public string ReportMemo { get; set; }
        public string TechMemo { get; set; }
        public string OtherMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<System.DateTime> RecieveTime { get; set; }
        public Nullable<int> RecieveOperId { get; set; }
        public Nullable<System.DateTime> ResultTime { get; set; }
        public Nullable<int> ResultOperId { get; set; }
        public Nullable<System.DateTime> AuthTime { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public Nullable<int> ReportOperId { get; set; }
        public short LsStatus { get; set; }
        public Nullable<int> TestTypeId { get; set; }
        public Nullable<int> CollectLocId { get; set; }
        public Nullable<int> TogetherNum { get; set; }
        public Nullable<int> SJOperId { get; set; }
        public Nullable<System.DateTime> SJOperTime { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual ICollection<CkBldReaction> CkBldReactions { get; set; }
        public virtual ICollection<CkBloodBack> CkBloodBacks { get; set; }
        public virtual ICollection<CkBloodSend> CkBloodSends { get; set; }
        public virtual ICollection<CkInFee> CkInFees { get; set; }
        public virtual CkTestType CkTestType { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
        public virtual ICollection<CkLabDtl> CkLabDtls { get; set; }
        public virtual ICollection<CkLabMic> CkLabMics { get; set; }
        public virtual ICollection<CKMachineSample> CKMachineSamples { get; set; }
        public virtual ICollection<CkLabResult> CkLabResults { get; set; }
        public virtual ICollection<CkReport> CkReports { get; set; }
    }
}
