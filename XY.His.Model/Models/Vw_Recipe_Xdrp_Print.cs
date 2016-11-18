using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_Recipe_Xdrp_Print
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
        public int Totality { get; set; }
        public string Memo { get; set; }
        public string PrepareTime { get; set; }
        public string Form_Name { get; set; }
        public int list_Num { get; set; }
        public int Int_Code { get; set; }
        public int IsCancel { get; set; }
        public string Item_Desc { get; set; }
        public int Group_Num { get; set; }
        public int Days { get; set; }
        public string Item_Code { get; set; }
        public bool isNoAttach { get; set; }
        public decimal Price_In { get; set; }
        public string Drug_Type { get; set; }
        public decimal Amount { get; set; }
        public int Rp_Type { get; set; }
        public string SequenceNum { get; set; }
        public string PatientName { get; set; }
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
    }
}
