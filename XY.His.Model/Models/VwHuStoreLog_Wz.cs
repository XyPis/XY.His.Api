using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwHuStoreLog_Wz
    {
        public int ID { get; set; }
        public System.DateTime HappenTime { get; set; }
        public int HouseId { get; set; }
        public string HouseName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public int InBatchId { get; set; }
        public string InBatchNo { get; set; }
        public string PNo { get; set; }
        public Nullable<int> UnitKc { get; set; }
        public string UnitKcName { get; set; }
        public decimal BeforeStockNum { get; set; }
        public decimal HappenNum { get; set; }
        public decimal AfterStockNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public Nullable<decimal> StockPriceAmount { get; set; }
        public Nullable<decimal> RetailPriceAmount { get; set; }
        public int UnitId { get; set; }
        public string OperUnitName { get; set; }
        public Nullable<bool> IsSpecial { get; set; }
        public Nullable<bool> IsExpen { get; set; }
        public Nullable<short> LsImport { get; set; }
        public string BsCompanyName { get; set; }
        public string Memo { get; set; }
        public string LsImportName { get; set; }
        public string BillNo { get; set; }
        public string LsActType { get; set; }
        public short ActType { get; set; }
        public string DrugType { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public string ManufacturerName { get; set; }
    }
}
