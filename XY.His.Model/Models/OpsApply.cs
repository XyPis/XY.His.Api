using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OpsApply
    {
        public OpsApply()
        {
            this.OpsCharges = new List<OpsCharge>();
            this.OpsMen = new List<OpsMan>();
        }

        public int ID { get; set; }
        public string ApplyNo { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> OpsId { get; set; }
        public Nullable<int> OpsOtherId { get; set; }
        public Nullable<int> AnaeId { get; set; }
        public string Assistant { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string BedNo { get; set; }
        public Nullable<short> LsHbsAg { get; set; }
        public Nullable<short> LsAsepsis { get; set; }
        public string BloodGroup { get; set; }
        public string Blood { get; set; }
        public string OpsBody { get; set; }
        public string OpsPos { get; set; }
        public string OtherTools { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsCalled { get; set; }
        public string Memo { get; set; }
        public Nullable<int> PlanOperId { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public string PlanMemo { get; set; }
        public Nullable<bool> IsFinish { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public Nullable<int> FinishOperId { get; set; }
        public string FinishMemo { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string BloodSum { get; set; }
        public Nullable<short> LsCutClass { get; set; }
        public Nullable<short> LsCure { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string BloodRpt { get; set; }
        public string Sensitive { get; set; }
        public Nullable<int> OpsRoomId { get; set; }
        public string SeqNum { get; set; }
        public virtual BsAnae BsAnae { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsOP BsOP { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
        public virtual ICollection<OpsCharge> OpsCharges { get; set; }
        public virtual ICollection<OpsMan> OpsMen { get; set; }
    }
}
