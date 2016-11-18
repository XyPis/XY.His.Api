using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VW_HisInPatient
    {
        public int ID { get; set; }
        public int PatID { get; set; }
        public string CardNo { get; set; }
        public string InPatNo { get; set; }
        public string HospNo { get; set; }
        public string PatientName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Mobile { get; set; }
        public string Sex { get; set; }
        public string SexName { get; set; }
        public string AddressHome { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string YbRegNo { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> BedId { get; set; }
        public string RoomNo { get; set; }
        public string BedName { get; set; }
        public Nullable<bool> IsAdd { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public int LocIn { get; set; }
        public string LocInName { get; set; }
        public int NTime { get; set; }
        public string InDate { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<int> InDays { get; set; }
        public short LsInStatus { get; set; }
        public string LsInStatusName { get; set; }
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
        public Nullable<int> WorktypeId { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public Nullable<int> MotherHospId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public string Illness { get; set; }
        public bool IsEndChg { get; set; }
        public string IdCardNo { get; set; }
        public string LinkmanName { get; set; }
        public string LinkmanPhone { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public string LocSource { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string InvoiceStuts { get; set; }
        public string InvoiceTime { get; set; }
        public int IsBB { get; set; }
    }
}
