using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsPatient : EntityBase
    { 
        public int ID { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public short LsMarriage { get; set; }
        public string BloodGroup { get; set; }
        public string XNo { get; set; }
        public Nullable<int> NationId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public Nullable<int> AreaId { get; set; }
        public string Native { get; set; }
        public string Residence { get; set; }
        public bool IsOversea { get; set; }
        public Nullable<System.DateTime> PassTime { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public Nullable<int> CertificateId { get; set; }
        public string Sensitive { get; set; }
        public string IdCardNo { get; set; }
        public bool isBaby { get; set; }
        public Nullable<int> MotherPatId { get; set; }
        public string MedicareNo { get; set; }
        public string AccountNo { get; set; }
        public string PhoneWork { get; set; }
        public string AddressWork { get; set; }
        public string PostCodeWork { get; set; }
        public string AreaCodeWork { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<int> RelationId { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanArea { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPhone { get; set; }
        public Nullable<int> FamilyId { get; set; }
        public bool isHouseMaster { get; set; }
        public Nullable<int> RelaMasterId { get; set; }
        public short LsCensus { get; set; }
        public Nullable<int> CommitteeId { get; set; }
        public Nullable<int> PoliceStationId { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public short Circumference { get; set; }
        public short Waistline { get; set; }
        public short Sternline { get; set; }
        public short LsSport { get; set; }
        public short LsSportTime { get; set; }
        public short LsSportType { get; set; }
        public short LsBitHabit { get; set; }
        public short SleepHour { get; set; }
        public short LsSleepTrouble { get; set; }
        public string SmokeHistory { get; set; }
        public string DrinkHistory { get; set; }
        public string OtherHabit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool IsActive { get; set; }
        public string InActiveReason { get; set; }
        public Nullable<System.DateTime> InActiveTime { get; set; }
        public Nullable<int> InActiveOperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public string PhotoFolder { get; set; }
        public Nullable<int> RoadId { get; set; }
        public string PersonHistory { get; set; }
        public string Password { get; set; }
        public string HealthCardNo { get; set; }     
    }
}
