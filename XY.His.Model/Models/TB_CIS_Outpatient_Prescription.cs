using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TB_CIS_Outpatient_Prescription
    {
        public string MedicalInstitutionCode { get; set; }
        public string MedicalInstitutionName { get; set; }
        public int PrescriptionID { get; set; }
        public string PrescriptionNumber { get; set; }
        public int PrescriptionProperty { get; set; }
        public string VisitingTypeCode { get; set; }
        public string VisitingTypeName { get; set; }
        public string VisitingSerialNumber { get; set; }
        public int FileNumber { get; set; }
        public string HealthCardNumber { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string ChinaIDNumber { get; set; }
        public string IDNumber { get; set; }
        public string IDType { get; set; }
        public string IDTypeName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string GenderName { get; set; }
        public string NameOfDiseaseDiagnosis { get; set; }
        public string DiseaseDiagnosisCode { get; set; }
        public int DiagnosisCode { get; set; }
        public string DiseaseDiagnosisDescription { get; set; }
        public string OrderCreateDepartmentCode { get; set; }
        public string OrderCreateDepartment { get; set; }
        public string OrderCreatorCode { get; set; }
        public string OrderCreator { get; set; }
        public System.DateTime OrderCreateTime { get; set; }
        public string PrescriptionNote { get; set; }
        public int PrescriptionDays { get; set; }
        public string TCMTypeCode { get; set; }
        public string TCMSign { get; set; }
        public string TCMPrescriptionDetail { get; set; }
        public string TCMCount { get; set; }
        public string TCMDecoctionMethod { get; set; }
        public string TCMRouteCode { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<decimal> PrescriptionMoney { get; set; }
        public Nullable<int> DetailCount { get; set; }
    }
}
