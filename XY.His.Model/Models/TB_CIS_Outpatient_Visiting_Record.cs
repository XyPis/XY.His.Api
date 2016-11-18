using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TB_CIS_Outpatient_Visiting_Record
    {
        public string MedicalInstitutionCode { get; set; }
        public string MedicalInstitutionName { get; set; }
        public string VisitingSerialNumber { get; set; }
        public string VisitingTypeCode { get; set; }
        public string VisitingTypeName { get; set; }
        public string OutpatientSerialNumber { get; set; }
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
        public int VisitingSign { get; set; }
        public int ReferralSign { get; set; }
        public string VisitingDepartmentCode { get; set; }
        public string VisitingDepartmentName { get; set; }
        public System.DateTime VisitingDate { get; set; }
        public string ChiefComplaint { get; set; }
        public string PrsentHistory { get; set; }
        public string PastHistory { get; set; }
        public string DrugAllergy { get; set; }
        public string PhysicalSign { get; set; }
        public string OutpatientSymptomName { get; set; }
        public string OutpatientSymptomDiagnosticCode { get; set; }
        public string DateOfOnset { get; set; }
        public string SymptomDuration { get; set; }
        public string NameOfDiseaseDiagnosis { get; set; }
        public string DiseaseDiagnosisCode { get; set; }
        public int DiagnosisCode { get; set; }
        public string Description { get; set; }
        public string DiagnosticianCode { get; set; }
        public string NameOfDiagnostician { get; set; }
        public System.DateTime DiagnosisDate { get; set; }
        public string TreatmentProcess { get; set; }
        public string ConsultProblem { get; set; }
        public string HealthServiceDemand { get; set; }
        public string HealthProblemAccess { get; set; }
        public string HandlePlan { get; set; }
        public string ChineseMedicineUtilizationCategoryCode { get; set; }
    }
}
