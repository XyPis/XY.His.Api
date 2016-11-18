using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Rmstore
    {
        public Rmstore()
        {
            this.RmAdjustDtls = new List<RmAdjustDtl>();
            this.RmBackDetails = new List<RmBackDetail>();
            this.RmCheckDtls = new List<RmCheckDtl>();
            this.RmCheckGroupDtls = new List<RmCheckGroupDtl>();
            this.RmKOutDtls = new List<RmKOutDtl>();
            this.RmKsBackDtls = new List<RmKsBackDtl>();
            this.RmLoseDtls = new List<RmLoseDtl>();
            this.RmMoveDtls = new List<RmMoveDtl>();
            this.RmOutDtls = new List<RmOutDtl>();
            this.RmPkDtls = new List<RmPkDtl>();
            this.RmPyDtls = new List<RmPyDtl>();
            this.RmSplitIns = new List<RmSplitIn>();
            this.RmSplitOuts = new List<RmSplitOut>();
            this.RmStoreLogs = new List<RmStoreLog>();
            this.RmZyBackDtls = new List<RmZyBackDtl>();
            this.RmZyOutDtls = new List<RmZyOutDtl>();
        }

        public int ID { get; set; }
        public string InBatchNo { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> CompId { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public decimal StockNum { get; set; }
        public decimal InstoreNum { get; set; }
        public Nullable<System.DateTime> StoreDate { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public bool IsBalance { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual ICollection<RmAdjustDtl> RmAdjustDtls { get; set; }
        public virtual ICollection<RmBackDetail> RmBackDetails { get; set; }
        public virtual ICollection<RmCheckDtl> RmCheckDtls { get; set; }
        public virtual ICollection<RmCheckGroupDtl> RmCheckGroupDtls { get; set; }
        public virtual ICollection<RmKOutDtl> RmKOutDtls { get; set; }
        public virtual ICollection<RmKsBackDtl> RmKsBackDtls { get; set; }
        public virtual ICollection<RmLoseDtl> RmLoseDtls { get; set; }
        public virtual ICollection<RmMoveDtl> RmMoveDtls { get; set; }
        public virtual ICollection<RmOutDtl> RmOutDtls { get; set; }
        public virtual ICollection<RmPkDtl> RmPkDtls { get; set; }
        public virtual ICollection<RmPyDtl> RmPyDtls { get; set; }
        public virtual ICollection<RmSplitIn> RmSplitIns { get; set; }
        public virtual ICollection<RmSplitOut> RmSplitOuts { get; set; }
        public virtual ICollection<RmStoreLog> RmStoreLogs { get; set; }
        public virtual ICollection<RmZyBackDtl> RmZyBackDtls { get; set; }
        public virtual ICollection<RmZyOutDtl> RmZyOutDtls { get; set; }
    }
}
