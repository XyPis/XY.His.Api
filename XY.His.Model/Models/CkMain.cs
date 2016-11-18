using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkMain
    {
        public CkMain()
        {
            this.CkMainIlls = new List<CkMainIll>();
            this.CkPsApplies = new List<CkPsApply>();
            this.CkResults = new List<CkResult>();
            this.CkResultGroups = new List<CkResultGroup>();
            this.PsApplyReports = new List<PsApplyReport>();
        }

        public int ID { get; set; }
        public string CheckNo { get; set; }
        public int PatId { get; set; }
        public System.DateTime CheckTime { get; set; }
        public Nullable<int> CompanyCkeckId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public Nullable<System.DateTime> RecieveTime { get; set; }
        public Nullable<int> RecieveOperId { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public Nullable<int> ReportOperId { get; set; }
        public Nullable<short> LsStatus { get; set; }
        public string ReportMemo { get; set; }
        public string TechMemo { get; set; }
        public string OtherMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> CompanyGroupId { get; set; }
        public string RptFileName { get; set; }
        public Nullable<bool> IsPay { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual CkCompany CkCompany { get; set; }
        public virtual CkCompanyCkeck CkCompanyCkeck { get; set; }
        public virtual CkCompanyGroup CkCompanyGroup { get; set; }
        public virtual ICollection<CkMainIll> CkMainIlls { get; set; }
        public virtual ICollection<CkPsApply> CkPsApplies { get; set; }
        public virtual ICollection<CkResult> CkResults { get; set; }
        public virtual ICollection<CkResultGroup> CkResultGroups { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
    }
}
