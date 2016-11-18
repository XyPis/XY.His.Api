using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuStore
    {
        public HuStore()
        {
            this.HuAdjustDtls = new List<HuAdjustDtl>();
            this.HuBackDtls = new List<HuBackDtl>();
            this.HuCheckDtls = new List<HuCheckDtl>();
            this.HuLoseDtls = new List<HuLoseDtl>();
            this.HuOtherOutDtls = new List<HuOtherOutDtl>();
            this.HuOutDtls = new List<HuOutDtl>();
            this.HuPkDtls = new List<HuPkDtl>();
            this.HuPydtls = new List<HuPydtl>();
            this.HuSplitIns = new List<HuSplitIn>();
            this.HuSplitOuts = new List<HuSplitOut>();
            this.HuStoreLogs = new List<HuStoreLog>();
        }

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual ICollection<HuAdjustDtl> HuAdjustDtls { get; set; }
        public virtual ICollection<HuBackDtl> HuBackDtls { get; set; }
        public virtual ICollection<HuCheckDtl> HuCheckDtls { get; set; }
        public virtual ICollection<HuLoseDtl> HuLoseDtls { get; set; }
        public virtual ICollection<HuOtherOutDtl> HuOtherOutDtls { get; set; }
        public virtual ICollection<HuOutDtl> HuOutDtls { get; set; }
        public virtual ICollection<HuPkDtl> HuPkDtls { get; set; }
        public virtual ICollection<HuPydtl> HuPydtls { get; set; }
        public virtual ICollection<HuSplitIn> HuSplitIns { get; set; }
        public virtual ICollection<HuSplitOut> HuSplitOuts { get; set; }
        public virtual ICollection<HuStoreLog> HuStoreLogs { get; set; }
    }
}
