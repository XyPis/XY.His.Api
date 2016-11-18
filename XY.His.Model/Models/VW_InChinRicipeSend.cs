using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VW_InChinRicipeSend
    {
        public int ID { get; set; }
        public int RecipeId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal Dosage { get; set; }
        public int UnitTakeId { get; set; }
        public int ItemId { get; set; }
        public short LsDecoctWay { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> DetailId { get; set; }
        public int DoctorId { get; set; }
        public decimal PriceIn { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string HospNo { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public short DrugNum { get; set; }
        public short DecoctNum { get; set; }
        public string RecipeNo { get; set; }
        public string PatTypeName { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string IllDesc { get; set; }
        public short LsCookSelf { get; set; }
        public string BedName { get; set; }
        public string PatientName { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsBack { get; set; }
        public string RicipeMemo { get; set; }
        public Nullable<System.DateTime> ConfirmOperTime { get; set; }
    }
}
