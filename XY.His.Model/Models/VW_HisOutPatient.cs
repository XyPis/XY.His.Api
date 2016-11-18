using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VW_HisOutPatient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string LocationName { get; set; }
        public string MzRegNo { get; set; }
        public System.DateTime RegTime { get; set; }
        public int RegDept { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexName { get; set; }
        public string CardNo { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public bool IsBaby { get; set; }
        public int RegTypeId { get; set; }
        public string RoomNo { get; set; }
        public string RegTypeName { get; set; }
        public bool IsPriority { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public bool IsElder { get; set; }
        public bool IsFreeReg { get; set; }
        public bool IsFreeDiag { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsPreReg { get; set; }
        public int PatId { get; set; }
        public string MedicareNo { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public string WorkTypeName { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<decimal> DiscDiag { get; set; }
        public Nullable<decimal> DiscIn { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string LsGFPatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public Nullable<int> FamilyId { get; set; }
        public Nullable<int> CommitteeId { get; set; }
        public int OperId { get; set; }
        public int LineOrder { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> DiagnDept { get; set; }
        public string F5 { get; set; }
    }
}
