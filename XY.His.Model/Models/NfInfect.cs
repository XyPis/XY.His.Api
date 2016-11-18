using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NfInfect
    {
        public NfInfect()
        {
            this.NfInfectDrugs = new List<NfInfectDrug>();
            this.NfInfectIlls = new List<NfInfectIll>();
            this.NfInfectReasons = new List<NfInfectReason>();
            this.NfInfectTests = new List<NfInfectTest>();
        }

        public int ID { get; set; }
        public short LsInfectType { get; set; }
        public string Code { get; set; }
        public int HospId { get; set; }
        public short LsEffect { get; set; }
        public short LsCutType { get; set; }
        public System.DateTime InfectTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public int PositionId { get; set; }
        public int LocationId { get; set; }
        public int SpecialityId { get; set; }
        public Nullable<short> LsInfluence { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
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
        public Nullable<int> DoctorId { get; set; }
        public virtual BsAnae BsAnae { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsOP BsOP { get; set; }
        public virtual BsPosition BsPosition { get; set; }
        public virtual BsSpeciality BsSpeciality { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual ICollection<NfInfectDrug> NfInfectDrugs { get; set; }
        public virtual ICollection<NfInfectIll> NfInfectIlls { get; set; }
        public virtual ICollection<NfInfectReason> NfInfectReasons { get; set; }
        public virtual ICollection<NfInfectTest> NfInfectTests { get; set; }
    }
}
