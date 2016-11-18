using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwNfInfect
    {
        public int ID { get; set; }
        public short LsInfectType { get; set; }
        public string Code { get; set; }
        public int HospId { get; set; }
        public string InPatNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public string Residence { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<short> LsInStatus { get; set; }
        public short LsEffect { get; set; }
        public short LsCutType { get; set; }
        public System.DateTime InfectTime { get; set; }
        public int PositionId { get; set; }
        public int LocationId { get; set; }
        public int SpecialityId { get; set; }
        public Nullable<short> LsInfluence { get; set; }
        public Nullable<int> OPSId { get; set; }
        public Nullable<System.DateTime> OPSTime { get; set; }
        public Nullable<short> LsClass { get; set; }
        public Nullable<short> LsASA { get; set; }
        public Nullable<bool> IsEmergency { get; set; }
        public Nullable<int> AnaesId { get; set; }
        public Nullable<int> Minutes { get; set; }
        public Nullable<bool> IsImplant { get; set; }
        public Nullable<bool> IsImglass { get; set; }
        public Nullable<bool> IsOPSDrug { get; set; }
        public Nullable<bool> IsUseDrug { get; set; }
        public Nullable<short> LsInfectRange { get; set; }
        public Nullable<short> LsUseType { get; set; }
        public Nullable<short> LsUnionDrug { get; set; }
        public Nullable<short> LsUsePurpose { get; set; }
        public Nullable<int> BaseDrugId { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public string IllDesc { get; set; }
        public Nullable<int> InfReasonId { get; set; }
        public Nullable<bool> IsRelated { get; set; }
        public string LabNo { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<int> BacteriaId { get; set; }
        public Nullable<int> BacteriaDrugId { get; set; }
        public Nullable<short> LsResult { get; set; }
    }
}
