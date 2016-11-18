using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsDrugForm
    {
        public BsDrugForm()
        {
            this.DhStores = new List<DhStore>();
            this.BsDrugFormUnits = new List<BsDrugFormUnit>();
            this.BsDrugFormUsages = new List<BsDrugFormUsage>();
            this.BsItemDrugs = new List<BsItemDrug>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsReject { get; set; }
        public bool IsSave { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<DhStore> DhStores { get; set; }
        public virtual ICollection<BsDrugFormUnit> BsDrugFormUnits { get; set; }
        public virtual ICollection<BsDrugFormUsage> BsDrugFormUsages { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
    }
}
