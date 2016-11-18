using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsCompany
    {
        public BsCompany()
        {
            this.DhStores = new List<DhStore>();
            this.Equipments = new List<Equipment>();
            this.HuStockReqs = new List<HuStockReq>();
            this.HuBacks = new List<HuBack>();
            this.HuOtherInDtls = new List<HuOtherInDtl>();
            this.HuStocks = new List<HuStock>();
            this.HuCheckDtls = new List<HuCheckDtl>();
            this.HuStores = new List<HuStore>();
            this.RmCheckDtls = new List<RmCheckDtl>();
            this.Rmstores = new List<Rmstore>();
            this.BsItemDrugs = new List<BsItemDrug>();
            this.RmOtherInDtls = new List<RmOtherInDtl>();
        }

        public int ID { get; set; }
        public string CODE { get; set; }
        public string Name { get; set; }
        public string CompAddre { get; set; }
        public string CompCorpo { get; set; }
        public string CompPhone { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<DhStore> DhStores { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<HuStockReq> HuStockReqs { get; set; }
        public virtual ICollection<HuBack> HuBacks { get; set; }
        public virtual ICollection<HuOtherInDtl> HuOtherInDtls { get; set; }
        public virtual ICollection<HuStock> HuStocks { get; set; }
        public virtual ICollection<HuCheckDtl> HuCheckDtls { get; set; }
        public virtual ICollection<HuStore> HuStores { get; set; }
        public virtual ICollection<RmCheckDtl> RmCheckDtls { get; set; }
        public virtual ICollection<Rmstore> Rmstores { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<RmOtherInDtl> RmOtherInDtls { get; set; }
    }
}
