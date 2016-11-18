using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TB_HIS_Fee_Record
    {
        public string MedicalInstitutionCode { get; set; }
        public string MedicalInstitutionName { get; set; }
        public int FeeRecordID { get; set; }
        public int RefundSign { get; set; }
        public string MedicalSettleModeCode { get; set; }
        public string MedicalSettleModeName { get; set; }
        public System.DateTime MedicalSettleTime { get; set; }
        public string InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
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
        public string VisitingTypeCode { get; set; }
        public string VisitingTypeName { get; set; }
        public string VisitingSerialNumber { get; set; }
        public Nullable<decimal> TotalInvoiceValue { get; set; }
        public decimal DeductibleFee { get; set; }
        public decimal MedicalInsuranceCareBillingAmount { get; set; }
        public string RuralCooperativeBillingAmount { get; set; }
        public string OtherBillingAmount { get; set; }
        public Nullable<decimal> FeeOfWesternMedication { get; set; }
        public Nullable<decimal> FeeOfChinesePatentMedicine { get; set; }
        public Nullable<decimal> FeeOfChineseHerbalMedicine { get; set; }
        public Nullable<decimal> RegistratedFee { get; set; }
        public Nullable<decimal> DiagnosticFee { get; set; }
        public Nullable<decimal> InspectionFee { get; set; }
        public Nullable<decimal> TreatmentFee { get; set; }
        public Nullable<decimal> OperationFee { get; set; }
        public int RadiationTherapyFee { get; set; }
        public Nullable<decimal> LaboratoryFee { get; set; }
        public Nullable<decimal> OtherFee { get; set; }
        public Nullable<int> DetailCount { get; set; }
        public Nullable<decimal> OperationMaterialFee { get; set; }
    }
}
