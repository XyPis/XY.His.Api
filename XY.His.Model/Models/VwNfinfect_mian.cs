using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwNfinfect_mian
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public string LsInfectTypeName { get; set; }
        public string Code { get; set; }
        public string LsEffectName { get; set; }
        public string LsCutTypeName { get; set; }
        public System.DateTime InfectTime { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public string Speciality { get; set; }
        public string LsInfluenceName { get; set; }
        public Nullable<int> OPSId { get; set; }
        public string BsOPSName { get; set; }
        public Nullable<System.DateTime> OPSTime { get; set; }
        public string LsClassName { get; set; }
        public string LsASAName { get; set; }
        public Nullable<bool> IsEmergency { get; set; }
        public Nullable<int> AnaesId { get; set; }
        public string AnaesName { get; set; }
        public Nullable<int> Minutes { get; set; }
        public Nullable<bool> IsImplant { get; set; }
        public Nullable<bool> IsImglass { get; set; }
        public Nullable<bool> IsOPSDrug { get; set; }
        public Nullable<bool> IsUseDrug { get; set; }
        public string LsInfectRangeName { get; set; }
        public string LsUseTypeName { get; set; }
        public string LsUnionDrugName { get; set; }
        public string LsUsePurposeName { get; set; }
        public System.DateTime OperTime { get; set; }
        public string PositionSystem { get; set; }
        public int OperID { get; set; }
        public string OpDoctor { get; set; }
    }
}
