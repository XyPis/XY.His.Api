using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsManufacturer
    {
        public BsManufacturer()
        {
            this.BsItemDrugs = new List<BsItemDrug>();
            this.DhStores = new List<DhStore>();
            this.Equipments = new List<Equipment>();
            this.HuStockDtls = new List<HuStockDtl>();
        }

        public int ID { get; set; }
        public string CODE { get; set; }
        public string Name { get; set; }
        public Nullable<short> LsKind { get; set; }
        public string AreaCode { get; set; }
        public string Address { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<DhStore> DhStores { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<HuStockDtl> HuStockDtls { get; set; }
    }
}
