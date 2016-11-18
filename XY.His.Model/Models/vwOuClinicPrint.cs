using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class vwOuClinicPrint
    {
        public Nullable<int> ID { get; set; }
        public int MzRegId { get; set; }
        public string MzRegNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Company { get; set; }
        public string AddressHome { get; set; }
        public string Native { get; set; }
        public string PhoneHome { get; set; }
        public string Sensitive { get; set; }
        public System.DateTime RegTime { get; set; }
        public string IllDesc { get; set; }
        public Nullable<decimal> ListNum { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<short> Days { get; set; }
        public string ItemName { get; set; }
        public string DrugFormName { get; set; }
        public string UsageName { get; set; }
        public string UnitTakeName { get; set; }
        public Nullable<short> LsRepType { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Spec { get; set; }
        public string UnitDiagName { get; set; }
        public string Memo { get; set; }
        public string NationName { get; set; }
        public short LsMarriage { get; set; }
        public string Occupation { get; set; }
        public string PatTypeName { get; set; }
        public string DoctorName { get; set; }
        public string LocationName { get; set; }
        public string FrequencyName { get; set; }
        public string MainInform { get; set; }
        public string CheckUp { get; set; }
        public Nullable<decimal> ExamT { get; set; }
        public Nullable<decimal> ExamP { get; set; }
        public Nullable<decimal> ExamR { get; set; }
        public Nullable<decimal> ExamBp { get; set; }
        public Nullable<decimal> ExamBp2 { get; set; }
        public string CheckCT { get; set; }
        public string Disposal { get; set; }
        public string SickHist { get; set; }
        public string Impression { get; set; }
        public string Analys { get; set; }
        public string Others { get; set; }
        public string RecipeNum { get; set; }
        public string AgeString { get; set; }
        public string Residence { get; set; }
        public string Tongue { get; set; }
        public string Pulse { get; set; }
        public string Moss { get; set; }
        public Nullable<bool> IsDoctorInput { get; set; }
    }
}
