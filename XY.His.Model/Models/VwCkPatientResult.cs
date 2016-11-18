using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkPatientResult
    {
        public int ID { get; set; }
        public string CardNo { get; set; }
        public string Sex { get; set; }
        public int TestId { get; set; }
        public string PatientName { get; set; }
        public string TestName { get; set; }
        public string Code { get; set; }
        public string LabNum { get; set; }
        public int PatId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string Result { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public bool IsPass { get; set; }
        public string LastResult { get; set; }
        public Nullable<int> TestTypeId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string TestGroup { get; set; }
        public string HighLow { get; set; }
        public string IsDangerous { get; set; }
        public string Compare { get; set; }
        public string Unit { get; set; }
        public string NormalRange { get; set; }
        public string Age { get; set; }
    }
}
