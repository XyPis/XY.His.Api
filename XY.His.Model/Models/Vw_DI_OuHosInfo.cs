using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_DI_OuHosInfo
    {
        public int ID { get; set; }
        public string MzRegNo { get; set; }
        public int HasDiag { get; set; }
        public int HasRecipe { get; set; }
        public string PatientName { get; set; }
        public string CardNo { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> BabyMonth { get; set; }
        public System.DateTime RegTime { get; set; }
        public string RegTypeName { get; set; }
        public string LocationName { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public string DoctorName { get; set; }
        public string PatTypeName { get; set; }
        public string TallyTypeName { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public string GetTallyType { get; set; }
        public string GetTallyTypeName { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public bool IsInPatient { get; set; }
        public string F1 { get; set; }
        public Nullable<bool> IsDiagnosed { get; set; }
    }
}
