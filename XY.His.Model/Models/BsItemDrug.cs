using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemDrug
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public string ChemName { get; set; }
        public bool IsRecipe { get; set; }
        public bool IsPoison { get; set; }
        public bool IsMental { get; set; }
        public bool IsExpen { get; set; }
        public bool IsSelf { get; set; }
        public Nullable<int> ProAreaId { get; set; }
        public int AheadAlert { get; set; }
        public decimal UnderLineKc { get; set; }
        public decimal UperLineKc { get; set; }
        public decimal NormalLineKc { get; set; }
        public int FormId { get; set; }
        public Nullable<int> ManuId { get; set; }
        public string PassNo { get; set; }
        public string AreaKc { get; set; }
        public short LsImport { get; set; }
        public bool IsInject { get; set; }
        public bool IsSpecial { get; set; }
        public int HouseId { get; set; }
        public int RoomIdOut { get; set; }
        public int RoomIdIn { get; set; }
        public int UnitKc { get; set; }
        public decimal RetailPriceKc { get; set; }
        public decimal StockPriceKc { get; set; }
        public bool IsBid { get; set; }
        public bool IsLocDrug { get; set; }
        public Nullable<int> CompId { get; set; }
        public bool IsBatch { get; set; }
        public bool IsSave { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> DrugID { get; set; }
        public string BuyInCode { get; set; }
        public Nullable<bool> IsSecMental { get; set; }
        public Nullable<bool> IsSkin { get; set; }
        public Nullable<bool> IsAntiBacterial { get; set; }
        public Nullable<bool> IsHighDanger { get; set; }
        public Nullable<bool> IsDanger { get; set; }
        public Nullable<bool> IsVaccine { get; set; }
        public Nullable<bool> IsTestReport { get; set; }
        public Nullable<bool> IsAnaes { get; set; }
        public Nullable<bool> IsMeetingUse { get; set; }
        public string RegNo { get; set; }
        public string ImpotTestBy { get; set; }
        public string TestReportNo { get; set; }
        public Nullable<bool> IsParity { get; set; }
        public string DDDMinValue { get; set; }
        public string DDDValue { get; set; }
        public string DrugsTypes { get; set; }
        public Nullable<bool> NotXZjDrug { get; set; }
        public Nullable<bool> XZjDrug { get; set; }
        public Nullable<bool> TSjDrug { get; set; }
        public Nullable<bool> IsAz { get; set; }
        public Nullable<bool> IsJH { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsDrugForm BsDrugForm { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsManufacturer BsManufacturer { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual BsRoom BsRoom1 { get; set; }
    }
}
