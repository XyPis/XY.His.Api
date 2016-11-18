using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdNewBirth
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public Nullable<int> AreaId { get; set; }
        public Nullable<int> CommitteeId { get; set; }
        public Nullable<int> FamilyId { get; set; }
        public Nullable<short> LsStatus { get; set; }
        public Nullable<short> Weight { get; set; }
        public Nullable<short> Height { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public Nullable<short> LsBornPlace { get; set; }
        public string OtherPlace { get; set; }
        public string DeliverOrgan { get; set; }
        public string SignOrgan { get; set; }
        public Nullable<System.DateTime> SignDate { get; set; }
        public string Midwife { get; set; }
        public Nullable<bool> IsDanger { get; set; }
        public Nullable<bool> IsCure { get; set; }
        public Nullable<bool> IsFilter { get; set; }
        public Nullable<int> ChildBirthId { get; set; }
        public string MotherAge { get; set; }
        public string MotherIdCard { get; set; }
        public string MotherNation { get; set; }
        public string MotherCountry { get; set; }
        public string FatherIdCard { get; set; }
        public string Weeks { get; set; }
        public string FatherAge { get; set; }
        public Nullable<int> Fathercountryid { get; set; }
        public Nullable<int> Fathernationid { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> BirthResult { get; set; }
        public Nullable<int> BirthStyle { get; set; }
        public Nullable<int> BirthStifle { get; set; }
        public virtual BsArea BsArea { get; set; }
        public virtual BsAreaCommittee BsAreaCommittee { get; set; }
        public virtual BsAreaProvince BsAreaProvince { get; set; }
        public virtual BsAreaRegion BsAreaRegion { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
