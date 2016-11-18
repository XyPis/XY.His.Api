using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_Recipe_Detail_Print1
    {
        public int ID { get; set; }
        public int MzRegId { get; set; }
        public int RecipeID { get; set; }
        public string recipe_Num { get; set; }
        public string Spec { get; set; }
        public string Unit_Take { get; set; }
        public string Unit_Diag { get; set; }
        public string usagename { get; set; }
        public string Hz { get; set; }
        public string Frequency { get; set; }
        public decimal Dosage { get; set; }
        public decimal Totality { get; set; }
        public string Memo { get; set; }
        public string PrepareTime { get; set; }
        public string Form_Name { get; set; }
        public int list_Num { get; set; }
        public int Int_Code { get; set; }
        public bool IsCancel { get; set; }
        public string Item_Desc { get; set; }
        public short Group_Num { get; set; }
        public Nullable<short> Days { get; set; }
        public string Item_Code { get; set; }
        public string F3 { get; set; }
        public string F5 { get; set; }
        public bool IsAttach { get; set; }
        public Nullable<int> Unit_TakeID { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public int Unit_DiagID { get; set; }
        public decimal PubDosage { get; set; }
        public int PubUnit_DiagID { get; set; }
        public Nullable<int> PubUnit_TakeID { get; set; }
        public string PubUnit_Diag { get; set; }
        public string PubUnit_Take { get; set; }
        public Nullable<bool> IsBatch { get; set; }
        public decimal Limit_Dosage { get; set; }
        public bool IsOtherFee { get; set; }
        public bool isNoAttach { get; set; }
        public decimal Price_In { get; set; }
        public bool IsCharge { get; set; }
        public short Drug_Type { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string SequenceNum { get; set; }
        public string PatientName { get; set; }
        public string AgeString { get; set; }
        public string DoctorName { get; set; }
        public string PatTypeName { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> BabyMonth { get; set; }
        public string Sex { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string IllDesc { get; set; }
        public string RecipeMemo { get; set; }
        public string AccountNo { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<int> FormId { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> AllPageNo { get; set; }
        public Nullable<bool> IsNurseExecute { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> LISCode { get; set; }
        public string CertificateName { get; set; }
        public string IdCardNo { get; set; }
        public string MedicareNo { get; set; }
    }
}
