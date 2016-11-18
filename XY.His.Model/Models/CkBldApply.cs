using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkBldApply
    {
        public int ID { get; set; }
        public string RecNo { get; set; }
        public Nullable<int> HospId { get; set; }
        public string PatBloodGroup { get; set; }
        public string PatRHD { get; set; }
        public string Illness { get; set; }
        public string Purpose { get; set; }
        public string HstyBlood { get; set; }
        public string HstyReact { get; set; }
        public string HstyTest { get; set; }
        public string HstyPregnancy { get; set; }
        public string HstyBirth { get; set; }
        public string TestResult { get; set; }
        public Nullable<int> BloodTypeId { get; set; }
        public Nullable<decimal> Vollume { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> PreOps { get; set; }
        public string SpecHandle { get; set; }
        public string BloodGroup { get; set; }
        public string Replace { get; set; }
        public string LabNum { get; set; }
        public Nullable<bool> IsAgree { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CkBloodType CkBloodType { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
