using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TB_HIS_Fee_Detail
    {
        public string MedicalInstitutionCode { get; set; }
        public string MedicalInstitutionName { get; set; }
        public int FeeDetailID { get; set; }
        public int FeeRecordID { get; set; }
        public string MedicalFeeTypeName { get; set; }
        public string DetailedFeeType { get; set; }
        public string RelatedMedicalAdviceID { get; set; }
        public string DrugName { get; set; }
        public string HospitalDrugCode { get; set; }
        public string ServiceItemName { get; set; }
        public string HospitalServiceItemCode { get; set; }
        public string MedicalInsuranceCode { get; set; }
        public string DetailItemUnit { get; set; }
        public decimal DetailItemUnitPrice { get; set; }
        public decimal DetailItemQuantity { get; set; }
        public decimal DetailItemPrice { get; set; }
        public Nullable<decimal> DeductibleFee { get; set; }
        public decimal DetailedItemValueWithMeidcalInsuranceExcepted { get; set; }
        public decimal DeductibleOfDetailedItemCoveredByMedicalInsurance { get; set; }
    }
}
