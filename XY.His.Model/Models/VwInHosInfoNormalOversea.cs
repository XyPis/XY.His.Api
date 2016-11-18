using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInHosInfoNormalOversea
    {
        public int ID { get; set; }
        public string HospNo { get; set; }
        public int PatID { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int NTime { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public short LsMarriage { get; set; }
        public string BloodGroup { get; set; }
        public string XNo { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Residence { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public bool IsOversea { get; set; }
        public Nullable<System.DateTime> PassTime { get; set; }
        public string IdCardNo { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public int PatTypeId { get; set; }
        public Nullable<int> CertificateId { get; set; }
        public short LsInType { get; set; }
        public short LsInWay { get; set; }
        public short LsInIllness { get; set; }
        public Nullable<int> DocMz { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public int LocIn { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> BedId { get; set; }
        public bool IsYbMt { get; set; }
        public string YbRegNo { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public bool IsBaby { get; set; }
        public Nullable<short> AgeDay { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public string PhoneWork { get; set; }
        public string AddressWork { get; set; }
        public string PostCodeWork { get; set; }
        public string AreaCodeWork { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<int> RelationId { get; set; }
        public string LinkmanPhone { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanArea { get; set; }
        public short LsInStatus { get; set; }
        public Nullable<System.DateTime> LeaveTime { get; set; }
        public string Status { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool IsEndChg { get; set; }
        public Nullable<int> EndChgOperID { get; set; }
        public Nullable<System.DateTime> EndchgoperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
        public Nullable<int> MotherHospId { get; set; }
        public Nullable<int> FromHospitalId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> LocOut { get; set; }
        public string TipsNurse { get; set; }
        public string TipsBalance { get; set; }
        public string TipsOther { get; set; }
        public string OtherRoles { get; set; }
    }
}
