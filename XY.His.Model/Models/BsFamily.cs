using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsFamily
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public int CommitteeId { get; set; }
        public string Name { get; set; }
        public string AddressHome { get; set; }
        public string PhoneHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public short TotalPersons { get; set; }
        public short HousePersons { get; set; }
        public short WorkingPersons { get; set; }
        public short LsFamilyType { get; set; }
        public short LsPeriod { get; set; }
        public short LsHouseType { get; set; }
        public short Acreage { get; set; }
        public short LsFuel { get; set; }
        public short LsWarm { get; set; }
        public short LsCold { get; set; }
        public short LsWater { get; set; }
        public short LsSaniFamily { get; set; }
        public short LsSaniPerson { get; set; }
        public short LsSaniHabit { get; set; }
        public short LsNeighbourhood { get; set; }
        public short LsWC { get; set; }
        public bool IsHealthBin { get; set; }
        public short LsIncome { get; set; }
        public string Memo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
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
        public Nullable<int> RoadId { get; set; }
        public Nullable<bool> IsSign { get; set; }
        public Nullable<short> IsCareMan { get; set; }
        public Nullable<int> SignDoctorId { get; set; }
        public Nullable<int> SignGroupId { get; set; }
        public virtual BsAreaCommittee BsAreaCommittee { get; set; }
    }
}
