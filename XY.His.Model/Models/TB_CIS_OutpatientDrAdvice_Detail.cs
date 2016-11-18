using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TB_CIS_OutpatientDrAdvice_Detail
    {
        public string MedicalInstitutionCode { get; set; }
        public string MedicalInstitutionName { get; set; }
        public int MedicalAdviceID { get; set; }
        public string PrescriptionID { get; set; }
        public int SortNumber { get; set; }
        public short PrescriptionGroupNo { get; set; }
        public string OrderNote { get; set; }
        public string MeidcalAdviceTypeCode { get; set; }
        public string MeidcalAdviceTypeName { get; set; }
        public string ServiceItemName { get; set; }
        public string HospitalServiceItemCode { get; set; }
        public string ServiceItemCodeOfPriceBureau { get; set; }
        public string ServiceItemCodeOfMedicalInsurance { get; set; }
        public string ApplicationFormNo { get; set; }
        public int DrugSign { get; set; }
        public string DrugName { get; set; }
        public string HospitalDrugCode { get; set; }
        public string DrugCodeOfMedicalInsurance { get; set; }
        public string DrugCodeOfFoodAndDrugAdministration { get; set; }
        public string DrugCodeOfProvincialDrugPurchase { get; set; }
        public string DrugType { get; set; }
        public string DrugSpecification { get; set; }
        public string DrugUseMeansCode { get; set; }
        public string DrugUseMeansName { get; set; }
        public string DrugUseDays { get; set; }
        public string DrugUseFrequency { get; set; }
        public string DrugUseFrequencyName { get; set; }
        public string DrugFormCode { get; set; }
        public string DrugFormName { get; set; }
        public string SingleDose { get; set; }
        public string DosageUnit { get; set; }
        public decimal TotalDosage { get; set; }
        public string TotalDosageUnit { get; set; }
    }
}
