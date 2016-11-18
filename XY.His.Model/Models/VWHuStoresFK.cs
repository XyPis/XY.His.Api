using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VWHuStoresFK
    {
        public int ID { get; set; }
        public string InBatchNo { get; set; }
        public int HouseId { get; set; }
        public int ItemId { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> CompId { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public System.DateTime StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public bool IsBalance { get; set; }
        public bool IsNewin { get; set; }
        public bool IsBid { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> FormId { get; set; }
        public Nullable<int> ManuId { get; set; }
        public Nullable<int> ProAreaId { get; set; }
        public Nullable<decimal> UnderLineKc { get; set; }
        public Nullable<decimal> UperLineKc { get; set; }
        public Nullable<decimal> NormalLineKc { get; set; }
        public Nullable<short> LsImport { get; set; }
        public Nullable<bool> IsInject { get; set; }
        public Nullable<bool> IsExpen { get; set; }
        public Nullable<short> LsRpType { get; set; }
        public Nullable<decimal> RetailTotal { get; set; }
        public Nullable<decimal> PriceTotal { get; set; }
        public string ItemCode { get; set; }
        public string Spec { get; set; }
        public string AreaKc { get; set; }
        public string UnitName { get; set; }
        public string ManuName { get; set; }
        public string CompName { get; set; }
    }
}
