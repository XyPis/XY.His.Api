using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OutMedTableHi
    {
        public string PresNO { get; set; }
        public int MedID { get; set; }
        public string MedOnlyCode { get; set; }
        public int MedAMT { get; set; }
        public string MedPack { get; set; }
        public string MedUnitPack { get; set; }
        public string MedUnit { get; set; }
        public System.DateTime MedOutTime { get; set; }
        public string PresType { get; set; }
        public int WindowNO { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientSex { get; set; }
        public string PatientAge { get; set; }
        public string PatientBirth { get; set; }
        public string Diagnosis { get; set; }
        public string WardNO { get; set; }
        public string WardName { get; set; }
        public string MedPerdos { get; set; }
        public string MedUsage { get; set; }
        public string MedPerday { get; set; }
        public string DoctorName { get; set; }
        public string FPNO { get; set; }
        public string SEndflag { get; set; }
        public Nullable<decimal> MedUnitPrice { get; set; }
        public Nullable<decimal> MedTotalPrice { get; set; }
        public string MedType { get; set; }
        public Nullable<int> MedConvercof { get; set; }
        public string Remark { get; set; }
        public string YFCode { get; set; }
        public string Endflag { get; set; }
        public int ID { get; set; }
        public string YfFinish { get; set; }
    }
}
