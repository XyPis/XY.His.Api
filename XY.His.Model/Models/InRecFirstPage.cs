using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InRecFirstPage
    {
        public int ID { get; set; }
        public string RecNo { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public Nullable<System.DateTime> ModifyOperTime { get; set; }
        public Nullable<int> ModifyOperID { get; set; }
        public bool IsAuth { get; set; }
        public Nullable<System.DateTime> AuthOperTime { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<System.DateTime> ConfirmIllDate { get; set; }
        public bool IsOPS { get; set; }
        public bool IsBabyCard { get; set; }
        public bool IsMutiIll { get; set; }
        public int InfectTimes { get; set; }
        public bool IsSalvage { get; set; }
        public int SalvageTimes { get; set; }
        public bool IsSalvSucess { get; set; }
        public int SalvSucessTimes { get; set; }
        public bool IsFollow { get; set; }
        public Nullable<System.DateTime> FollowEndDate { get; set; }
        public bool IsDeadBodyCheck { get; set; }
        public bool IsStudyCase { get; set; }
        public short LsQuality { get; set; }
        public Nullable<int> ZrDoctorId { get; set; }
        public Nullable<int> ZzDoctorId { get; set; }
        public Nullable<int> ZyDoctorId { get; set; }
        public Nullable<int> SxDoctorId { get; set; }
        public Nullable<int> JxDoctorId { get; set; }
        public Nullable<int> YjsDoctorId { get; set; }
        public Nullable<int> ZkDoctorId { get; set; }
        public short LsAccMzIll { get; set; }
        public short LsAccZyIll { get; set; }
        public short LsAccOPSIll1 { get; set; }
        public short LsAccOPSIll2 { get; set; }
        public short LsAccOPSIll3 { get; set; }
        public short LsAccOPSIll4 { get; set; }
        public bool IsTjIll { get; set; }
        public bool IsConfirm3D { get; set; }
        public int BabyNum { get; set; }
        public bool IsTranNeact { get; set; }
        public bool IsOxygenNeact { get; set; }
        public bool IsMidFireBurn { get; set; }
        public bool IsSingleIll { get; set; }
        public bool IsHbsAg { get; set; }
        public bool IsHCVAb { get; set; }
        public bool IsHIVAb { get; set; }
        public bool IsHbsAg3 { get; set; }
        public Nullable<int> HeadOperId { get; set; }
        public Nullable<int> ZkOperId { get; set; }
        public Nullable<System.DateTime> ZkDate { get; set; }
        public bool IsRH { get; set; }
        public bool IsOpsFirst { get; set; }
        public bool IsCureFirst { get; set; }
        public bool IsCheckFirst { get; set; }
        public bool IsDiagFirst { get; set; }
        public Nullable<int> RedCellNum { get; set; }
        public Nullable<int> PlaqueNum { get; set; }
        public Nullable<int> SerousNum { get; set; }
        public Nullable<int> AllBloodNum { get; set; }
        public Nullable<int> OtherBloodNum { get; set; }
        public Nullable<int> ConsultHosputal { get; set; }
        public Nullable<int> ConsultRemote { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsDoctor BsDoctor1 { get; set; }
        public virtual BsDoctor BsDoctor2 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual BsUser BsUser2 { get; set; }
        public virtual BsUser BsUser3 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InHosInfo InHosInfo1 { get; set; }
    }
}
