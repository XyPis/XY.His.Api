using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsHouse
    {
        public BsHouse()
        {
            this.HuAdjusts = new List<HuAdjust>();
            this.HuAdjustPlans = new List<HuAdjustPlan>();
            this.HuBacks = new List<HuBack>();
            this.HuLoses = new List<HuLose>();
            this.HuOtherIns = new List<HuOtherIn>();
            this.HuOtherOuts = new List<HuOtherOut>();
            this.HuOuts = new List<HuOut>();
            this.HuPks = new List<HuPk>();
            this.HuPies = new List<HuPy>();
            this.HuSplits = new List<HuSplit>();
            this.HuChecks = new List<HuCheck>();
            this.HuStoreLogs = new List<HuStoreLog>();
            this.HuStocks = new List<HuStock>();
            this.HuStockReqs = new List<HuStockReq>();
            this.HuStores = new List<HuStore>();
            this.RmAppDrugs = new List<RmAppDrug>();
            this.RmApplbacks = new List<RmApplback>();
            this.BsItemDrugs = new List<BsItemDrug>();
            this.BsUserHouses = new List<BsUserHouse>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<HuAdjust> HuAdjusts { get; set; }
        public virtual ICollection<HuAdjustPlan> HuAdjustPlans { get; set; }
        public virtual ICollection<HuBack> HuBacks { get; set; }
        public virtual ICollection<HuLose> HuLoses { get; set; }
        public virtual ICollection<HuOtherIn> HuOtherIns { get; set; }
        public virtual ICollection<HuOtherOut> HuOtherOuts { get; set; }
        public virtual ICollection<HuOut> HuOuts { get; set; }
        public virtual ICollection<HuPk> HuPks { get; set; }
        public virtual ICollection<HuPy> HuPies { get; set; }
        public virtual ICollection<HuSplit> HuSplits { get; set; }
        public virtual ICollection<HuCheck> HuChecks { get; set; }
        public virtual ICollection<HuStoreLog> HuStoreLogs { get; set; }
        public virtual ICollection<HuStock> HuStocks { get; set; }
        public virtual ICollection<HuStockReq> HuStockReqs { get; set; }
        public virtual ICollection<HuStore> HuStores { get; set; }
        public virtual ICollection<RmAppDrug> RmAppDrugs { get; set; }
        public virtual ICollection<RmApplback> RmApplbacks { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<BsUserHouse> BsUserHouses { get; set; }
    }
}
