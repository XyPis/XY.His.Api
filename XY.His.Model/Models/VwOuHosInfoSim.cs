using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuHosInfoSim
    {
        public int ID { get; set; }
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public int PatId { get; set; }
        public string CardNo { get; set; }
        public string Sex { get; set; }
        public System.DateTime BirthDate { get; set; }
        public Nullable<byte> Age { get; set; }
        public int BabyMonth { get; set; }
        public string AgeString { get; set; }
        public System.DateTime RegTime { get; set; }
        public string RegLocation { get; set; }
        public bool IsPriority { get; set; }
        public int RegTypeId { get; set; }
        public string RegTypeName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public int RegDept { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> DiagnDept { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public string DoctorName { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public string GetTallyType { get; set; }
        public string GetTallyTypeName { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public bool IsInPatient { get; set; }
        public string F1 { get; set; }
        public string F3 { get; set; }
        public string F7 { get; set; }
        public Nullable<bool> IsOuChargeInput { get; set; }
        public Nullable<bool> IsLocationSee { get; set; }
        public int IsLocationDiagSee { get; set; }
        public Nullable<bool> IsDiagnosed { get; set; }
        public string DiagStatus { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> TimeSpanId { get; set; }
        public int LineOrder { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public string MedicareNo { get; set; }
        public Nullable<int> SpecialityId { get; set; }
    }
}
