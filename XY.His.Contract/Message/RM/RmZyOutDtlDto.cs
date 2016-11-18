using System;
using System.Collections.Generic;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Message.IN;

namespace XY.His.Contract.Message.RM
{
    [Serializable]
    public partial class RmZyOutDtlDto : DtoBase
    {        
        public int BillId { get; set; }
        public Nullable<int> InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal BackNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public Nullable<int> ReqItemId { get; set; }
        public Nullable<int> RecipeItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItemDto BsItem { get; set; }
        public virtual BsUnitDto BsUnit { get; set; }
        public virtual InChinRicipeDtlDto InChinRicipeDtl { get; set; }
        public virtual RmStoreDto Rmstore { get; set; }
        public virtual RmZyOutDto RmZyOut { get; set; }
    }
}
