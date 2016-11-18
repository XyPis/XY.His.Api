using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DhStore
    {
        public int ID { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public string InBatchNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int UnitId { get; set; }
        public int UnitKcId { get; set; }
        public Nullable<int> CompId { get; set; }
        public Nullable<int> ManuId { get; set; }
        public int FormId { get; set; }
        public bool IsRecipe { get; set; }
        public bool IsPoison { get; set; }
        public bool IsMental { get; set; }
        public bool IsExpen { get; set; }
        public bool IsSelf { get; set; }
        public short LsImport { get; set; }
        public bool IsCountry { get; set; }
        public bool IsProvince { get; set; }
        public bool IsBid { get; set; }
        public string PassNo { get; set; }
        public decimal StockNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public System.DateTime StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsDrugForm BsDrugForm { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual BsManufacturer BsManufacturer { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUnit BsUnit1 { get; set; }
    }
}
